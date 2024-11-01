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
using DocumentFormat.OpenXml.Spreadsheet;
using Krypton.Toolkit;

namespace CandidateLog
{
    public partial class CreateCandidate : KryptonForm
    {
        private Candidates PreviousForm { get; }
        private string[] PhotoNamePath { get; set; }
        private Dictionary<string, string> FilesNamePath {  get; set; }
        private List<string> CandidateLinks { get; set; }

        public CreateCandidate(Candidates candidatesIndex)
        {
            InitializeComponent();
            PreviousForm = candidatesIndex;
            var statuses = Enum.GetValues(typeof(Resources.Status)).Cast<Resources.Status>().Skip(1).ToList(); // "All"
            cbStatus.DataSource = statuses;
            PhotoNamePath = new string[2];
            FilesNamePath = new Dictionary<string, string>();
            CandidateLinks = new List<string>();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbJmbg.Text))
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh();
            else if(tbJmbg.Text.Length == 13)
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh() + tbJmbg.Text.Substring(7);
            else
                tbJmbg.Text = GetFirstPartOfJmbgBasedOnBitrh() + tbJmbg.Text;

            if (tbJmbg.Text.Length > 13)
                tbJmbg.Text = tbJmbg.Text.Substring(0, 13);
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
                        MessageBox.Show("Invalid file format.\r\nPlease upload a jpg/jpeg, png, bmp or webp file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (fileInfo.Length > 2048000)
                    {
                        MessageBox.Show("File must be less than 2 mb.", "File to large", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    PhotoNamePath[0] = fileName;
                    PhotoNamePath[1] = filePath;

                    //string destinationPath = @".\..\..\Files\ImageContainer\" + fileName;
                    //File.Copy(filePath, destinationPath);

                    tbPhotoDragDrop.Text = "\r\n\r\n\r\nPhoto uploaded\r\n" + fileName;
                }
            }
        }
        private bool IsPhotoExtensionAllowed(string fileExtension)
        {
            string[] allowedExtensions = { ".png", ".jpg", ".jpeg", ".bmp", ".webp" };
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

                    FilesNamePath.Add(fileName, filePath);

                    //string destinationPath = @".\..\..\Files\AttachmentContainer\" + fileName;
                    //File.Copy(filePath, destinationPath);

                    RefreshAttachmentDisplayPanel();
                }
            }
        }
        private void RefreshAttachmentDisplayPanel()
        {
            AttachmentDisplayPanel.Visible = true;
            AttachmentDisplayPanel.Controls.Clear();
            int yOffset = 10;

            foreach (var fileName in FilesNamePath.Keys)
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
                    FilesNamePath.Remove(fileName);
                    RefreshAttachmentDisplayPanel();
                };

                KryptonLabel label = new KryptonLabel
                {
                    Text = fileName,
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
            tbAddLink.Text = String.Empty;
            RefreshLinkDisplayPanel();
        }
        private void RefreshLinkDisplayPanel()
        {
            LinksPanel.Visible = true;
            LinksPanel.Controls.Clear();
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
                    Text = UpdateLabelIfLeadsToSotialNetwork(url),
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
        private string UpdateLabelIfLeadsToSotialNetwork(string url)
        {
            string urlLowerCase = url.ToLower();

            if (urlLowerCase.Contains("linkedin"))
                return "LinkedIn account";
            if (urlLowerCase.Contains("github"))
                return "GitHub account";
            if (urlLowerCase.Contains("facebook"))
                return "Facebook account";
            if (urlLowerCase.Contains("instagram"))
                return "Instagram account";
            if (urlLowerCase.Contains("threads"))
                return "Threads account";
            if (urlLowerCase.Contains("x.com") || urlLowerCase.Contains("twitter"))
                return "X account";

            return url;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //List<Models.Attachment> pendintAttachments = new List<Models.Attachment>();
            //foreach(string key in FilesNamePath.Keys)
            //{
            //    pendintAttachments.Add(new Models.Attachment
            //    {
            //        FileName = key,
            //        FilePath = FilesNamePath[key]
            //    });

            //}


            Models.Candidate parameters = new Models.Candidate
            {
                Name = tbFirstName.Text,
                LastName = tbLastName.Text,
                Jmbg = tbJmbg.Text,
                BirthDate = dtpBirthDate.Value,
                Email = tbEmail.Text,
                //Links = CandidateLinks,
                PhoneNumber = tbPhoneNumber.Text,
                AdditionalInfo = tbAdditionalInfo.Text,
                LastUpdate = DateTime.Now,
                //Attachments =
                //PhotoFilePath = PhotoNamePath[1],
                Rating = (byte)numRating.Value,
                Status = (byte)(Resources.Status)cbStatus.SelectedItem


            };


            using (var db = new CandidateContext())
            {
                try
                {
                    var repo = new Repository(db);
                    repo.CreateCandidate(parameters);

                    PreviousForm.PopulateCandidatesGrid();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
