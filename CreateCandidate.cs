using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandidateLog.Data;
using CandidateLog.Models;
using CandidateLog.Resources;
using DocumentFormat.OpenXml.Spreadsheet;
using Krypton.Toolkit;

namespace CandidateLog
{
    public partial class CreateCandidate : KryptonForm
    {
        private Candidates PreviousForm { get; }
        private string[] PhotoNamePath { get; set; }
        private Dictionary<Attachment, string> FilesAttachmentPath {  get; set; }
        private List<string> CandidateLinks { get; set; }

        public CreateCandidate(Candidates candidatesIndex)
        {
            InitializeComponent();
            PreviousForm = candidatesIndex;
            var statuses = Enum.GetValues(typeof(Resources.Status)).Cast<Resources.Status>().Skip(1).ToList(); // "All" is skiped
            cbStatus.DataSource = statuses;
            PhotoNamePath = new string[2];
            FilesAttachmentPath = new Dictionary<Attachment, string>();
            CandidateLinks = new List<string>();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbJmbg.Text))
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh();
            else if(tbJmbg.Text.Length <= 7)
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh();
            else
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh() + tbJmbg.Text.Substring(7);
        }
        private string GetFirstPartOfJmbgBasedOnBitrh()
        {
            string birthToJmbg = dtpBirthDate.Value.ToString("dd MM yyyy");
            birthToJmbg = birthToJmbg.Replace(" ", "");
            birthToJmbg = birthToJmbg.Remove(4, 1);
            return birthToJmbg;
        }
        
        private void tbPhotoDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            CursorIconIsElementDropable(e);
        }
        private static void CursorIconIsElementDropable(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbPhotoDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    FileInfo fileInfo = new FileInfo(filePath);
                    string fileName = fileInfo.Name;
                    string fileExtension = fileInfo.Extension.ToLower();

                    if (!IsPhotoExtensionAllowed(fileExtension))
                    {
                        MessageBox.Show("Invalid picture format.\r\nPlease upload a jpg/jpeg, png or bmp file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (fileInfo.Length > 2048000)
                    {
                        MessageBox.Show("File must be less than 2 mb.", "File to large", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    PhotoNamePath[0] = fileName;
                    PhotoNamePath[1] = filePath;

                    tbPhotoDragDrop.Text = "\r\n\r\n\r\nPhoto uploaded\r\n" + fileName;
                }
            }
        }
        private bool IsPhotoExtensionAllowed(string fileExtension)
        {
            string[] allowedExtensions = { ".png", ".jpg", ".jpeg", ".bmp" };
            bool extensionAllowed = false;

            foreach (string extension in allowedExtensions)
            {
                if (extension == fileExtension)
                {
                    extensionAllowed = true;
                    break;
                }
            }

            return extensionAllowed;
        }

        private void tbDocumentDragDropArea_DragEnter(object sender, DragEventArgs e)
        {
            CursorIconIsElementDropable(e);
        }

        private void tbDocumentDragDropArea_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    FileInfo fileInfo = new FileInfo(filePath);
                    string fileName = fileInfo.Name;

                    if (fileInfo.Length > 1024000)
                    {
                        MessageBox.Show("File must be less than 1 mb.", "File to large", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Attachment attachment = new Attachment();
                    attachment.FileName = fileName;
                    SelectDocumentType dg = new SelectDocumentType(attachment);
                    dg.Show();

                    FilesAttachmentPath.Add(attachment, filePath);

                    RefreshAttachmentDisplayPanel();
                }
            }
        }
        private void RefreshAttachmentDisplayPanel()
        {
            AttachmentDisplayPanel.Controls.Clear();

            if (FilesAttachmentPath.Count == 0)
            {
                AttachmentDisplayPanel.Visible = false;
                return;
            }

            AttachmentDisplayPanel.Visible = true;
            
            int yOffset = 10;

            foreach (Attachment attachment in FilesAttachmentPath.Keys)
            {
                KryptonButton removeFileButton = new KryptonButton
                {
                    Text = "x",
                    Location = new Point(10, yOffset - 1),
                    AutoSize = true,
                    ToolTipValues = { EnableToolTips = true, Description = "remove file", Heading = string.Empty }
                };

                removeFileButton.Height = removeFileButton.Height - 5;
                removeFileButton.Width = 16;
                removeFileButton.Click += (sender, e) =>
                {
                    FilesAttachmentPath.Remove(attachment);
                    RefreshAttachmentDisplayPanel();
                };

                KryptonComboBox comboBox = new KryptonComboBox
                {
                    DataSource = Enum.GetValues(typeof(Resources.FileType))

                };

                KryptonLabel label = new KryptonLabel
                {
                    Text = attachment.FileName,
                    Location = new Point(removeFileButton.Right + 7, yOffset),
                    AutoSize = true,
                };

                AttachmentDisplayPanel.Controls.Add(removeFileButton);
                AttachmentDisplayPanel.Controls.Add(label);
                yOffset += label.Height + 10;
            }
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddLink.Text))
            {
                MessageBox.Show("Paste link into the texbox to the right.", "No Link added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CandidateLinks.Add(tbAddLink.Text.Trim());
            tbAddLink.Text = string.Empty;
            RefreshLinkDisplayPanel();
        }
        private void RefreshLinkDisplayPanel()
        {
            LinksPanel.Controls.Clear();

            if (CandidateLinks.Count == 0)
            {
                LinksPanel.Visible = false;
                return;
            }

            LinksPanel.Visible = true;

            int yOffset = 5;

            foreach (var url in CandidateLinks)
            {
                KryptonButton removeLinkButton = new KryptonButton
                {
                    Text = "x",
                    Location = new Point(10, yOffset - 1),
                    AutoSize = true,
                    ToolTipValues = {EnableToolTips = true, Description = "remove link"}
                };

                removeLinkButton.Height = removeLinkButton.Height - 5;
                removeLinkButton.Width = 16;
                removeLinkButton.Click += (sender, e) => RemoveLinkAndRefreshPanel(url);

                KryptonButton visitSiteButton = new KryptonButton
                {
                    Text = "Visit",
                    Location = new Point(removeLinkButton.Right + 10, yOffset - 1),
                    AutoSize = true
                };

                visitSiteButton.Height = removeLinkButton.Height;
                visitSiteButton.Width = 64;
                visitSiteButton.Click += (sender, e) =>
                {
                    try
                    {
                        System.Diagnostics.Process.Start(url);
                    }
                    catch
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("www." + url);
                        }
                        catch
                        {
                            InformUserUpdateUi(url);
                        }
                    }
                };

                KryptonLabel label = new KryptonLabel
                {
                    Text = MiniTools.UpdateLabelIfLeadsToSotialNetwork(url),
                    ForeColor = System.Drawing.Color.White,
                    Location = new Point(visitSiteButton.Right + 10, yOffset),
                    AutoSize = true,
                };

                LinksPanel.Controls.Add(removeLinkButton);
                LinksPanel.Controls.Add(visitSiteButton);
                LinksPanel.Controls.Add(label);

                yOffset += visitSiteButton.Height + 5;
            }
        }
        private void InformUserUpdateUi(string url)
        {
            DialogResult dialog = MessageBox.Show(
                "Could Not visit the dedicated link.\r\nPlease check the link and add it again\r\n\r\n" +
                "Do you want to remove this link from the list?",
                "Error",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (dialog == DialogResult.Yes)
                RemoveLinkAndRefreshPanel(url);
        }
        private void RemoveLinkAndRefreshPanel(string url)
        {
            CandidateLinks.Remove(url);
            RefreshLinkDisplayPanel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Models.Link> pendingLinks = new List<Models.Link>();
            foreach (string url in CandidateLinks)
                pendingLinks.Add(new Models.Link { UrlPath = url });

            List<Models.StatusHistory> statusHistories = new List<Models.StatusHistory>();
            byte currentStatus = (byte)(Resources.Status)cbStatus.SelectedItem;
            statusHistories.Add(new Models.StatusHistory { Status = currentStatus, StatusUpdate = DateTime.Now });

            Models.Candidate parameters = new Models.Candidate
            {
                Name = tbFirstName.Text,
                LastName = tbLastName.Text,
                Jmbg = tbJmbg.Text,
                BirthDate = dtpBirthDate.Value,
                Email = tbEmail.Text,
                Links = pendingLinks,
                PhoneNumber = tbPhoneNumber.Text,
                AdditionalInfo = tbAdditionalInfo.Text,
                LastUpdate = DateTime.Now,
                Rating = (byte)numRating.Value,
                Status = currentStatus,
                StatusHistories = statusHistories
            };

            using (var db = new CandidateContext())
            {
                try
                {
                    var repo = new Repository(db);
                    int newCandidateId = repo.CreateCandidate(parameters);

                    string fileNamePrefix = newCandidateId.ToString() + parameters.Name[0] + parameters.LastName[0];

                    AddAttachments(repo, newCandidateId, fileNamePrefix);
                    AddPhoto(repo, newCandidateId, fileNamePrefix);

                    MessageBox.Show("Candidate sucessfully added.\r\nID: " + newCandidateId,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                    PreviousForm.PopulateCandidatesGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        private void AddAttachments(Repository repo, int id, string fileNamePrefix)
        {
            try
            {
                foreach (Attachment attachment in FilesAttachmentPath.Keys)
                {
                    string destinationPath = @".\..\..\Files\AttachmentContainer\" + fileNamePrefix + attachment.FileName;
                    File.Copy(FilesAttachmentPath[attachment], destinationPath);

                    attachment.CandidateId = id;
                    attachment.FileName = fileNamePrefix + attachment.FileName;
                    attachment.FilePath = destinationPath;
                    attachment.LastUpdate = DateTime.Now;

                    repo.CreateAttachment(attachment);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Candidate added to database,\r\nError saving file attachmetns.\r\n\r\n" + ex.Message,
                    "Error saving Attachments",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private void AddPhoto(Repository repo, int id, string fileNamePrefix)
        {
            if (string.IsNullOrEmpty(tbPhotoDragDrop.Text))
                return;

            try
            {
                string destinationPath = @".\..\..\Files\ImageContainer\" + fileNamePrefix + PhotoNamePath[0];
                File.Copy(PhotoNamePath[1], destinationPath);

                bool success = repo.UploadPhoto(id, destinationPath);

                if(!success)
                    MessageBox.Show("Error saving photo. Candidate not found.", "Error saving photo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Candidate added to database,\r\nError saving photo.\r\n\r\n" + ex.Message,
                    "Error saving photo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
