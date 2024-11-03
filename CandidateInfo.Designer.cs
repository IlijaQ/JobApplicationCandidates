namespace CandidateLog
{
    partial class CandidateInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.lblCandidateId = new Krypton.Toolkit.KryptonLabel();
            this.LinksPanel = new Krypton.Toolkit.KryptonPanel();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            this.tbPhotoDragDrop = new Krypton.Toolkit.KryptonTextBox();
            this.AttachmentDisplayPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.lblAdditionalInfo = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.tbAdditionalInfo = new Krypton.Toolkit.KryptonTextBox();
            this.lblFrstName = new Krypton.Toolkit.KryptonLabel();
            this.lblLastName = new Krypton.Toolkit.KryptonLabel();
            this.lblBirthDate = new Krypton.Toolkit.KryptonLabel();
            this.lblJmbg = new Krypton.Toolkit.KryptonLabel();
            this.lblEmail = new Krypton.Toolkit.KryptonLabel();
            this.lblPhone = new Krypton.Toolkit.KryptonLabel();
            this.lblStatus = new Krypton.Toolkit.KryptonLabel();
            this.lblRating = new Krypton.Toolkit.KryptonLabel();
            this.bgwLoadCandidate = new System.ComponentModel.BackgroundWorker();
            this.SearchPanel = new Krypton.Toolkit.KryptonPanel();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.LinksPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentDisplayPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(550, 247);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel10.TabIndex = 64;
            this.kryptonLabel10.Values.Text = "Status";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(827, 247);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel9.TabIndex = 62;
            this.kryptonLabel9.Values.Text = "Rating";
            // 
            // lblCandidateId
            // 
            this.lblCandidateId.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCandidateId.Location = new System.Drawing.Point(17, 13);
            this.lblCandidateId.Name = "lblCandidateId";
            this.lblCandidateId.Size = new System.Drawing.Size(106, 24);
            this.lblCandidateId.TabIndex = 61;
            this.lblCandidateId.Values.Text = "Candidate ID";
            // 
            // LinksPanel
            // 
            this.LinksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksPanel.AutoScroll = true;
            this.LinksPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LinksPanel.Location = new System.Drawing.Point(550, 315);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(765, 206);
            this.LinksPanel.TabIndex = 56;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1184, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 32);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(17, 547);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 32);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Values.Text = "Edit";
            // 
            // tbPhotoDragDrop
            // 
            this.tbPhotoDragDrop.AllowDrop = true;
            this.tbPhotoDragDrop.CueHint.CueHintText = "Drag and drop Photo  jpg/jpeg, png, bmp, webp";
            this.tbPhotoDragDrop.Location = new System.Drawing.Point(550, 81);
            this.tbPhotoDragDrop.Multiline = true;
            this.tbPhotoDragDrop.Name = "tbPhotoDragDrop";
            this.tbPhotoDragDrop.ReadOnly = true;
            this.tbPhotoDragDrop.Size = new System.Drawing.Size(199, 150);
            this.tbPhotoDragDrop.TabIndex = 55;
            this.tbPhotoDragDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttachmentDisplayPanel
            // 
            this.AttachmentDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentDisplayPanel.AutoScroll = true;
            this.AttachmentDisplayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AttachmentDisplayPanel.Location = new System.Drawing.Point(827, 81);
            this.AttachmentDisplayPanel.Name = "AttachmentDisplayPanel";
            this.AttachmentDisplayPanel.Size = new System.Drawing.Size(489, 150);
            this.AttachmentDisplayPanel.TabIndex = 54;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(17, 117);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(83, 24);
            this.kryptonLabel7.TabIndex = 52;
            this.kryptonLabel7.Values.Text = "Last Name";
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.Location = new System.Drawing.Point(17, 315);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(113, 24);
            this.lblAdditionalInfo.TabIndex = 51;
            this.lblAdditionalInfo.Values.Text = "Additional Info";
            this.lblAdditionalInfo.Visible = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(17, 247);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(115, 24);
            this.kryptonLabel5.TabIndex = 50;
            this.kryptonLabel5.Values.Text = "Phone Number";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(17, 214);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(48, 24);
            this.kryptonLabel4.TabIndex = 49;
            this.kryptonLabel4.Values.Text = "Email";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(17, 181);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(50, 24);
            this.kryptonLabel3.TabIndex = 48;
            this.kryptonLabel3.Values.Text = "JMBG";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(17, 151);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(80, 24);
            this.kryptonLabel2.TabIndex = 47;
            this.kryptonLabel2.Values.Text = "Bitrh Date";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 84);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 24);
            this.kryptonLabel1.TabIndex = 46;
            this.kryptonLabel1.Values.Text = "First Name";
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Location = new System.Drawing.Point(165, 315);
            this.tbAdditionalInfo.Multiline = true;
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.ReadOnly = true;
            this.tbAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdditionalInfo.Size = new System.Drawing.Size(292, 206);
            this.tbAdditionalInfo.TabIndex = 45;
            this.tbAdditionalInfo.Visible = false;
            // 
            // lblFrstName
            // 
            this.lblFrstName.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblFrstName.Location = new System.Drawing.Point(165, 84);
            this.lblFrstName.Name = "lblFrstName";
            this.lblFrstName.Size = new System.Drawing.Size(135, 24);
            this.lblFrstName.TabIndex = 66;
            this.lblFrstName.Values.Text = "no data available";
            // 
            // lblLastName
            // 
            this.lblLastName.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblLastName.Location = new System.Drawing.Point(165, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(135, 24);
            this.lblLastName.TabIndex = 67;
            this.lblLastName.Values.Text = "no data available";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBirthDate.Location = new System.Drawing.Point(165, 151);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(135, 24);
            this.lblBirthDate.TabIndex = 68;
            this.lblBirthDate.Values.Text = "no data available";
            // 
            // lblJmbg
            // 
            this.lblJmbg.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblJmbg.Location = new System.Drawing.Point(165, 181);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(135, 24);
            this.lblJmbg.TabIndex = 69;
            this.lblJmbg.Values.Text = "no data available";
            // 
            // lblEmail
            // 
            this.lblEmail.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblEmail.Location = new System.Drawing.Point(165, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 24);
            this.lblEmail.TabIndex = 70;
            this.lblEmail.Values.Text = "no data available";
            // 
            // lblPhone
            // 
            this.lblPhone.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblPhone.Location = new System.Drawing.Point(165, 247);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(135, 24);
            this.lblPhone.TabIndex = 71;
            this.lblPhone.Values.Text = "no data available";
            // 
            // lblStatus
            // 
            this.lblStatus.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblStatus.Location = new System.Drawing.Point(639, 247);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 24);
            this.lblStatus.TabIndex = 72;
            this.lblStatus.Values.Text = "no data available";
            // 
            // lblRating
            // 
            this.lblRating.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRating.Location = new System.Drawing.Point(918, 251);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(64, 24);
            this.lblRating.TabIndex = 73;
            this.lblRating.Values.Text = "* * * * *";
            this.lblRating.Visible = false;
            // 
            // bgwLoadCandidate
            // 
            this.bgwLoadCandidate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoadCandidate_DoWork);
            this.bgwLoadCandidate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadCandidate_RunWorkerCompleted);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchPanel.Controls.Add(this.lblSearch);
            this.SearchPanel.Controls.Add(this.kryptonProgressBar1);
            this.SearchPanel.Location = new System.Drawing.Point(509, 247);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(373, 85);
            this.SearchPanel.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.SearchPanel.TabIndex = 74;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(130, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 24);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Values.Text = "Fetching Data...";
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.Location = new System.Drawing.Point(24, 43);
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Size = new System.Drawing.Size(325, 27);
            this.kryptonProgressBar1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonProgressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kryptonProgressBar1.TabIndex = 0;
            this.kryptonProgressBar1.Text = "Searching...";
            this.kryptonProgressBar1.Values.Text = "Searching...";
            // 
            // CandidateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 590);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFrstName);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.lblCandidateId);
            this.Controls.Add(this.LinksPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbPhotoDragDrop);
            this.Controls.Add(this.AttachmentDisplayPanel);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.lblAdditionalInfo);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.tbAdditionalInfo);
            this.MinimumSize = new System.Drawing.Size(1350, 637);
            this.Name = "CandidateInfo";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.LinksPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentDisplayPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel lblCandidateId;
        private Krypton.Toolkit.KryptonPanel LinksPanel;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnEdit;
        private Krypton.Toolkit.KryptonTextBox tbPhotoDragDrop;
        private Krypton.Toolkit.KryptonPanel AttachmentDisplayPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel lblAdditionalInfo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox tbAdditionalInfo;
        private Krypton.Toolkit.KryptonLabel lblFrstName;
        private Krypton.Toolkit.KryptonLabel lblLastName;
        private Krypton.Toolkit.KryptonLabel lblBirthDate;
        private Krypton.Toolkit.KryptonLabel lblJmbg;
        private Krypton.Toolkit.KryptonLabel lblEmail;
        private Krypton.Toolkit.KryptonLabel lblPhone;
        private Krypton.Toolkit.KryptonLabel lblStatus;
        private Krypton.Toolkit.KryptonLabel lblRating;
        private System.ComponentModel.BackgroundWorker bgwLoadCandidate;
        private Krypton.Toolkit.KryptonPanel SearchPanel;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
    }
}