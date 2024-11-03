using CandidateLog.Data;
using CandidateLog.Models;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            if(CandidateData.Status != 0)
                lblStatus.Text = Enum.GetName(typeof(Resources.Status), CandidateData.Status);

            if (CandidateData.Rating != 0)
            {
                lblRating.Text = ConvertToStars(CandidateData.Rating);
                lblRating.Visible = true;
            }

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
    }
}
