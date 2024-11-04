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
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Krypton.Toolkit;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CandidateLog
{
    public partial class EditCandidate : KryptonForm
    {
        private CandidateInfo PreviousForm { get; }
        private Candidate CandidateData { get; set; }
        private string[] PhotoNamePath { get; set; }
        private Dictionary<Attachment, string> FilesAttachmentPath { get; set; }
        private Dictionary<Attachment, string> InitialFilesAttachmentPath { get; set; }
        private List<string> CandidateLinks { get; set; }
        private List<string> InitialCandidateLinks { get; set; }
        private byte InitialStatus { get; set; }

        public EditCandidate(CandidateInfo form, Candidate candidate)
        {
            InitializeComponent();
            CandidateData = candidate;
            PreviousForm = form;
            var statuses = Enum.GetValues(typeof(Resources.Status)).Cast<Resources.Status>().Skip(1).ToList(); // "All" is skiped
            cbStatus.DataSource = statuses;
            InitialStatus = CandidateData.Status;
            PhotoNamePath = new string[2];

            LoadInitialAttachmentData();
            LoadInitialLinksData();

            PopulateUi();
        }
        private void LoadInitialAttachmentData()
        {
            InitialFilesAttachmentPath = new Dictionary<Attachment, string>();
            FilesAttachmentPath = new Dictionary<Attachment, string>();
            foreach (var file in CandidateData.Attachments)
            {
                InitialFilesAttachmentPath.Add(file, file.FilePath);
                FilesAttachmentPath.Add(file, file.FilePath);
            }
        }
        private void LoadInitialLinksData()
        {
            InitialCandidateLinks = new List<string>();
            CandidateLinks = new List<string>();
            foreach (var link in CandidateData.Links)
            {
                InitialCandidateLinks.Add(link.UrlPath);
                CandidateLinks.Add(link.UrlPath);
            }
        }
        private void PopulateUi()
        {
            lblCandidateId.Text = lblCandidateId.Text + CandidateData.Id;
            lblLastUpdate.Text = lblLastUpdate.Text + CandidateData.LastUpdate.ToString("dd.MM.yyyy.");

            if (!string.IsNullOrEmpty(CandidateData.Name))
                tbFirstName.Text = CandidateData.Name;

            if (!string.IsNullOrEmpty(CandidateData.LastName))
                tbLastName.Text = CandidateData.LastName;

            if (CandidateData.BirthDate != DateTime.MinValue)
                dtpBirthDate.Text = CandidateData.BirthDate.ToString("dd.MM.yyyy.");

            if (!string.IsNullOrEmpty(CandidateData.Jmbg))
                tbJmbg.Text = CandidateData.Jmbg;

            if (!string.IsNullOrEmpty(CandidateData.Email))
                tbEmail.Text = CandidateData.Email;

            if (!string.IsNullOrEmpty(CandidateData.PhoneNumber))
                tbPhoneNumber.Text = CandidateData.PhoneNumber;

            if (!string.IsNullOrEmpty(CandidateData.AdditionalInfo))
                tbAdditionalInfo.Text = CandidateData.AdditionalInfo;

            if (CandidateData.Rating != 0)
                numRating.Value = CandidateData.Rating;

            if (CandidateData.Status != 0)
            {
                var statuses = Enum.GetValues(typeof(Resources.Status)).Cast<Resources.Status>().Skip(1).ToList(); // "All" is skiped
                cbStatus.DataSource = statuses;
                cbStatus.SelectedIndex = CandidateData.Status - 1;
            }

            DisplayPhoto();

            if (CandidateData.Attachments.Count > 0)
                DispayAttachments();

            RefreshLinkDisplayPanel();
        }
        private void DisplayPhoto()
        {
            if (!string.IsNullOrEmpty(CandidateData.PhotoFilePath))
            {
                PicturePanel.Visible = true;
                btnChangePhoto.Visible = true;
                PicturePanel.Controls.Clear();
                PicturePanel.Controls.Add(new PictureBox
                {
                    ImageLocation = CandidateData.PhotoFilePath,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                });
            }
        }
        private void DispayAttachments()
        {
            foreach (Attachment file in CandidateData.Attachments)
                FilesAttachmentPath.Add(file, file.FilePath);

            RefreshAttachmentDisplayPanel();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbJmbg.Text))
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh();
            else if (tbJmbg.Text.Length <= 7)
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
                    ToolTipValues = { EnableToolTips = true, Description = "remove link" }
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

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            PicturePanel.Visible = false;
            btnChangePhoto.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fileNamePrefix = $"{CandidateData.Id}{CandidateData.Name[0]}{CandidateData.LastName[0]}";
            byte modifiedStatus = (byte)(Resources.Status)cbStatus.SelectedItem;

            Models.Candidate parameters = new Models.Candidate
            {
                Name = tbFirstName.Text,
                LastName = tbLastName.Text,
                Jmbg = tbJmbg.Text,
                BirthDate = dtpBirthDate.Value,
                Email = tbEmail.Text,
                PhoneNumber = tbPhoneNumber.Text,
                AdditionalInfo = tbAdditionalInfo.Text,
                PhotoFilePath = PreparePhotoForUpdate(fileNamePrefix),
                LastUpdate = DateTime.Now,
                Rating = (byte)numRating.Value,
                Status = modifiedStatus
            };

            using (var db = new CandidateContext())
            {
                try
                {
                    var repo = new Repository(db);
                    bool success = repo.UpdateCandidate(parameters);

                    AddAttachments(repo, CandidateData.Id, fileNamePrefix);

                    if (InitialStatus != modifiedStatus)
                        repo.UpdateRatingAndStatus(CandidateData.Id, CandidateData.Rating, modifiedStatus);

                    UpdateLinks(repo);

                    UpdateAttachments(repo, fileNamePrefix);

                    MessageBox.Show($"ID: {CandidateData.Id}\r\nCandidate sucessfully updated.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            PreviousForm.LoadData();
            this.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show("Candidate added to database,\r\nError saving file attachmetns.\r\n\r\n" + ex.Message,
                    "Error saving Attachments",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private string PreparePhotoForUpdate(string fileNamePrefix)
        {
            if (string.IsNullOrEmpty(tbPhotoDragDrop.Text))
                return CandidateData.PhotoFilePath;

            if (CandidateData.PhotoFilePath != null)
                File.Delete(CandidateData.PhotoFilePath);

            string destinationPath = @".\..\..\Files\ImageContainer\" + fileNamePrefix + PhotoNamePath[0];
            File.Copy(PhotoNamePath[1], destinationPath);

            return destinationPath;
        }
        private void UpdateLinks(Repository repo)
        {
            List<string> LinksToAdd = CandidateLinks.Except(InitialCandidateLinks).ToList();
            List<string> LinksForRemoval = InitialCandidateLinks.Except(CandidateLinks).ToList();

            foreach (string link in LinksToAdd)
            {
                repo.CreateLink(new Link
                {
                    CandidateId = CandidateData.Id,
                    UrlPath = link,
                });
            }

            foreach (string link in LinksForRemoval)
                repo.DeleteLink(CandidateData.Id, link);
        }
        private void UpdateAttachments(Repository repo, string fileNamePrefix)
        {
            var entriesToAdd = FilesAttachmentPath
                    .Where(a => !InitialFilesAttachmentPath.Any(i => i.Key.Id == a.Key.Id))
                    .ToDictionary(a => a.Key, a => a.Value);

            foreach (Attachment attachment in entriesToAdd.Keys)
            {
                string destinationPath = @".\..\..\Files\AttachmentContainer\" + fileNamePrefix + attachment.FileName;
                File.Copy(FilesAttachmentPath[attachment], destinationPath);

                attachment.CandidateId = CandidateData.Id;
                attachment.FileName = fileNamePrefix + attachment.FileName;
                attachment.FilePath = destinationPath;
                attachment.LastUpdate = DateTime.Now;

                repo.CreateAttachment(attachment);
            }

            List<Attachment> filesToBeDeleted = InitialFilesAttachmentPath
                    .Where(i => !FilesAttachmentPath.Any(a => a.Key.Id == a.Key.Id))
                    .Select(i => i.Key)
                    .ToList();

            foreach (Attachment attachment in filesToBeDeleted)
            {
                repo.DeleteAttachment(CandidateData.Id, attachment.FilePath);
                File.Delete(attachment.FilePath);
            }
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
