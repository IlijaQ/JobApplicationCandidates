using CandidateLog.Data;
using CandidateLog.Models;
using CandidateLog.Resources;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidateLog
{
    public partial class CandidateInfo : KryptonForm
    {
        private int CandidateId { get; }
        private Candidate CandidateData { get; set; }
        public CandidateInfo(int candidateId)
        {
            InitializeComponent();
            CandidateId = candidateId;
            bgwLoadCandidate.RunWorkerAsync();
        }

        private void bgwLoadCandidate_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgwLoadCandidate.CancellationPending)
                return;

            try
            {
                using(var db = new CandidateContext())
                {
                    var repo = new Repository(db);
                    e.Result = repo.GetCandidate(CandidateId);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void bgwLoadCandidate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                try
                {
                    var result = (Candidate)e.Result;
                    CandidateData = result;
                    FillUiWithResults();
                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SearchPanel.Visible = false;
        }
        private void FillUiWithResults()
        {
            lblCandidateId.Text = "Candidate ID " + CandidateData.Id;

            if (!string.IsNullOrEmpty(CandidateData.Name))
                lblFrstName.Text = CandidateData.Name;

            if (!string.IsNullOrEmpty(CandidateData.LastName))
                lblLastName.Text = CandidateData.LastName;

            if (CandidateData.BirthDate != DateTime.MinValue)
                lblBirthDate.Text = CandidateData.BirthDate.ToString("dd.MM.yyyy.");

            if (!string.IsNullOrEmpty(CandidateData.Jmbg))
                lblJmbg.Text = CandidateData.Jmbg;

            if (!string.IsNullOrEmpty(CandidateData.Email))
                lblEmail.Text = CandidateData.Email;

            if (!string.IsNullOrEmpty(CandidateData.PhoneNumber))
                lblPhone.Text = CandidateData.PhoneNumber;

            if (!string.IsNullOrEmpty(CandidateData.AdditionalInfo))
            {
                lblAdditionalInfo.Visible = true;
                tbAdditionalInfo.Visible = true;
                tbAdditionalInfo.Text = CandidateData.AdditionalInfo;
            }

            if (CandidateData.Status != 0)
                lblStatus.Text = Enum.GetName(typeof(Resources.Status), CandidateData.Status);

            if (CandidateData.Rating != 0)
            {
                lblRating.Text = ConvertToStars(CandidateData.Rating);
                lblRating.Visible = true;
            }

            DisplayPhoto();

            if(CandidateData.Links.Count > 0)
                DisplayLinks();

            if (CandidateData.StatusHistories.Count > 0)
                PopulateStatusHistoryToolTip();

            if (CandidateData.Attachments.Count > 0)
                DispayAttachments();
        }
        private string ConvertToStars(byte rating)
        {
            switch (rating)
            {
                case 1: return "*";
                case 2: return "* *";
                case 3: return "* * *";
                case 4: return "* * * *";
                case 5: return "* * * * *";
                default: return string.Empty;
            }
        }
        private void DisplayPhoto()
        {
            if (string.IsNullOrEmpty(CandidateData.PhotoFilePath))
                lblPhotoNotUploaded.Visible = true;
            else
            {
                PicturePanel.Controls.Clear();
                PicturePanel.Controls.Add(new PictureBox
                {
                    ImageLocation = CandidateData.PhotoFilePath,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                });
            }
        }
        private void DisplayLinks()
        {
            lblLinksPanelHeader.Visible = true;
            LinksPanel.Visible = true;

            int yOffset = 5;

            foreach (var linkObject in CandidateData.Links)
            {
                KryptonButton visitSiteButton = new KryptonButton
                {
                    Text = "Visit",
                    Location = new Point(10, yOffset - 1),
                    AutoSize = true
                };

                visitSiteButton.Height = visitSiteButton.Height - 5;
                visitSiteButton.Width = 64;
                visitSiteButton.Click += (sender, e) =>
                {
                    try
                    {
                        System.Diagnostics.Process.Start(linkObject.UrlPath);
                    }
                    catch
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("www." + linkObject.UrlPath);
                        }
                        catch
                        {
                            DialogResult dialog = MessageBox.Show(
                                "Link not working.\r\nCould Not visit the dedicated url.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                };

                KryptonLabel label = new KryptonLabel
                {
                    Text = MiniTools.UpdateLabelIfLeadsToSotialNetwork(linkObject.UrlPath),
                    Location = new Point(visitSiteButton.Right + 10, yOffset),
                    AutoSize = true,
                };

                LinksPanel.Controls.Add(visitSiteButton);
                LinksPanel.Controls.Add(label);

                yOffset += visitSiteButton.Height + 5;
            }
        }
        private void PopulateStatusHistoryToolTip()
        {
            lblStatusHistoryViewInfo.Visible = true;

            string toolTipHeader = "StatusUpdated\t\t SatusName";

            List<StatusHistory> orderedStatusHistory = CandidateData.StatusHistories.OrderByDescending(d => d.StatusUpdate).ToList();
            List<string> formatedStatusHistory = new List<string>();
            
            foreach (StatusHistory status in orderedStatusHistory)
                formatedStatusHistory.Add(status.StatusUpdate.ToString("dd.MM.yyyy. HH:mm\t") + Enum.GetName(typeof(Resources.Status), status.Status));
            
            string toolTipContent = string.Join("\r\n", formatedStatusHistory);

            lblStatusHeader.ToolTipValues.EnableToolTips = true;
            lblStatusHeader.ToolTipValues.Heading = toolTipHeader;
            lblStatusHeader.ToolTipValues.Description = toolTipContent;

            lblStatus.ToolTipValues.EnableToolTips = true;
            lblStatus.ToolTipValues.Heading = toolTipHeader;
            lblStatus.ToolTipValues.Description = toolTipContent;
        }
        private void DispayAttachments()
        {
            }
        }
    }
}
