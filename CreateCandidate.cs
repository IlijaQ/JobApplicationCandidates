using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Krypton.Toolkit;

namespace CandidateLog
{
    public partial class CreateCandidate : KryptonForm
    {
        private Dictionary<string, string> FilesPathName {  get; set; }

        public CreateCandidate()
        {
            InitializeComponent();
            FilesPathName = new Dictionary<string, string>();
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

        private void tbDocumentDragDropArea_DragEnter(object sender, DragEventArgs e)
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

                    FilesPathName.Add(filePath, fileName);

                    string destinationPath = @".\..\..\Files\AttachmentContainer\" + fileName;
                    File.Copy(filePath, destinationPath);

                    RefreshAttachmentDisplayPanel();
                }
            }
        }
        private void RefreshAttachmentDisplayPanel()
        {
            AttachmentDisplayPanel.Visible = true;
            AttachmentDisplayPanel.Controls.Clear();
            int yOffset = 10;

            foreach (var fileName in FilesPathName.Values)
            {
                Label label = new Label
                {
                    Text = fileName,
                    Location = new Point(10, yOffset),
                    AutoSize = true,
                    BackColor = System.Drawing.Color.Transparent,
                    Font = new System.Drawing.Font("Times New Roman", 12)
                };

                AttachmentDisplayPanel.Controls.Add(label);
                yOffset += label.Height + 10;
            }
        }

        private void tbPhotoDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            CursorIconIsElementDropable(e);
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

                    FilesPathName.Add(filePath, fileName);

                    string destinationPath = @".\..\..\Files\ImageContainer\" + fileName;
                    File.Copy(filePath, destinationPath);

                    tbPhotoDragDrop.Text = "Photo uploaded\r\n" + fileName;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
