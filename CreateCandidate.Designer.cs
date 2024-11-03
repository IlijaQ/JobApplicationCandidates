namespace CandidateLog
{
    partial class CreateCandidate
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
            this.tbFirstName = new Krypton.Toolkit.KryptonTextBox();
            this.tbJmbg = new Krypton.Toolkit.KryptonTextBox();
            this.tbLastName = new Krypton.Toolkit.KryptonTextBox();
            this.dtpBirthDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.tbEmail = new Krypton.Toolkit.KryptonTextBox();
            this.tbPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            this.tbAdditionalInfo = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.tbDocumentDragDropArea = new Krypton.Toolkit.KryptonTextBox();
            this.AttachmentDisplayPanel = new Krypton.Toolkit.KryptonPanel();
            this.tbPhotoDragDrop = new Krypton.Toolkit.KryptonTextBox();
            this.btnAddLink = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.tbAddLink = new Krypton.Toolkit.KryptonTextBox();
            this.LinksPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.numRating = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentDisplayPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinksPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(169, 80);
            this.tbFirstName.MaxLength = 100;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(292, 27);
            this.tbFirstName.TabIndex = 13;
            // 
            // tbJmbg
            // 
            this.tbJmbg.Location = new System.Drawing.Point(169, 177);
            this.tbJmbg.MaxLength = 13;
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(292, 27);
            this.tbJmbg.TabIndex = 15;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(169, 113);
            this.tbLastName.MaxLength = 100;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(292, 27);
            this.tbLastName.TabIndex = 14;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(169, 146);
            this.dtpBirthDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(292, 25);
            this.dtpBirthDate.TabIndex = 16;
            this.dtpBirthDate.ValueNullable = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(169, 210);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(292, 27);
            this.tbEmail.TabIndex = 17;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(169, 243);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(292, 27);
            this.tbPhoneNumber.TabIndex = 18;
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAdditionalInfo.Location = new System.Drawing.Point(169, 314);
            this.tbAdditionalInfo.Multiline = true;
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdditionalInfo.Size = new System.Drawing.Size(292, 206);
            this.tbAdditionalInfo.TabIndex = 19;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(21, 83);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 24);
            this.kryptonLabel1.TabIndex = 20;
            this.kryptonLabel1.Values.Text = "First Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 150);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(80, 24);
            this.kryptonLabel2.TabIndex = 21;
            this.kryptonLabel2.Values.Text = "Bitrh Date";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(21, 180);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(50, 24);
            this.kryptonLabel3.TabIndex = 22;
            this.kryptonLabel3.Values.Text = "JMBG";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(21, 213);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(48, 24);
            this.kryptonLabel4.TabIndex = 23;
            this.kryptonLabel4.Values.Text = "Email";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(21, 246);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(115, 24);
            this.kryptonLabel5.TabIndex = 24;
            this.kryptonLabel5.Values.Text = "Phone Number";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(21, 314);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(113, 24);
            this.kryptonLabel6.TabIndex = 25;
            this.kryptonLabel6.Values.Text = "Additional Info";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(21, 116);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(83, 24);
            this.kryptonLabel7.TabIndex = 26;
            this.kryptonLabel7.Values.Text = "Last Name";
            // 
            // tbDocumentDragDropArea
            // 
            this.tbDocumentDragDropArea.AllowDrop = true;
            this.tbDocumentDragDropArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocumentDragDropArea.CueHint.CueHintText = "Drag and drop CV, Cover letter and other documents here...";
            this.tbDocumentDragDropArea.Location = new System.Drawing.Point(770, 80);
            this.tbDocumentDragDropArea.Multiline = true;
            this.tbDocumentDragDropArea.Name = "tbDocumentDragDropArea";
            this.tbDocumentDragDropArea.ReadOnly = true;
            this.tbDocumentDragDropArea.Size = new System.Drawing.Size(204, 150);
            this.tbDocumentDragDropArea.TabIndex = 27;
            this.tbDocumentDragDropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbDocumentDragDropArea_DragDrop);
            this.tbDocumentDragDropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbDocumentDragDropArea_DragEnter);
            // 
            // AttachmentDisplayPanel
            // 
            this.AttachmentDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentDisplayPanel.AutoScroll = true;
            this.AttachmentDisplayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AttachmentDisplayPanel.Location = new System.Drawing.Point(980, 80);
            this.AttachmentDisplayPanel.Name = "AttachmentDisplayPanel";
            this.AttachmentDisplayPanel.Size = new System.Drawing.Size(340, 150);
            this.AttachmentDisplayPanel.TabIndex = 28;
            this.AttachmentDisplayPanel.Visible = false;
            // 
            // tbPhotoDragDrop
            // 
            this.tbPhotoDragDrop.AllowDrop = true;
            this.tbPhotoDragDrop.CueHint.CueHintText = "Drag and drop Photo  jpg/jpeg, png, bmp, webp";
            this.tbPhotoDragDrop.Location = new System.Drawing.Point(554, 80);
            this.tbPhotoDragDrop.Multiline = true;
            this.tbPhotoDragDrop.Name = "tbPhotoDragDrop";
            this.tbPhotoDragDrop.ReadOnly = true;
            this.tbPhotoDragDrop.Size = new System.Drawing.Size(199, 150);
            this.tbPhotoDragDrop.TabIndex = 29;
            this.tbPhotoDragDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhotoDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbPhotoDragDrop_DragDrop);
            this.tbPhotoDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbPhotoDragDrop_DragEnter);
            // 
            // btnAddLink
            // 
            this.btnAddLink.Location = new System.Drawing.Point(554, 273);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(132, 29);
            this.btnAddLink.TabIndex = 30;
            this.btnAddLink.Values.Text = "Add Link";
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(21, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 32);
            this.btnSave.TabIndex = 31;
            this.btnSave.Values.Text = "Create";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1188, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 32);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbAddLink
            // 
            this.tbAddLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddLink.CueHint.CueHintText = "Paste Link here and than click \"Add Link\" to queue it for new Candidate";
            this.tbAddLink.Location = new System.Drawing.Point(692, 275);
            this.tbAddLink.Name = "tbAddLink";
            this.tbAddLink.Size = new System.Drawing.Size(627, 27);
            this.tbAddLink.TabIndex = 33;
            // 
            // LinksPanel
            // 
            this.LinksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksPanel.AutoScroll = true;
            this.LinksPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LinksPanel.Location = new System.Drawing.Point(554, 314);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(765, 206);
            this.LinksPanel.TabIndex = 29;
            this.LinksPanel.Visible = false;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(21, 12);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(173, 24);
            this.kryptonLabel8.TabIndex = 34;
            this.kryptonLabel8.Values.Text = "Create New Candidate";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(554, 12);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel9.TabIndex = 35;
            this.kryptonLabel9.Values.Text = "Rating";
            // 
            // numRating
            // 
            this.numRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Location = new System.Drawing.Point(636, 10);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(71, 26);
            this.numRating.TabIndex = 36;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(744, 10);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel10.TabIndex = 37;
            this.kryptonLabel10.Values.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 159;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(831, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(143, 26);
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 38;
            this.cbStatus.Text = "Candidate";
            // 
            // CreateCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1332, 590);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.LinksPanel);
            this.Controls.Add(this.tbAddLink);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.tbPhotoDragDrop);
            this.Controls.Add(this.AttachmentDisplayPanel);
            this.Controls.Add(this.tbDocumentDragDropArea);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.tbAdditionalInfo);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbJmbg);
            this.Controls.Add(this.tbLastName);
            this.MinimumSize = new System.Drawing.Size(1350, 637);
            this.Name = "CreateCandidate";
            this.Text = "Create Candidate";
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentDisplayPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinksPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox tbFirstName;
        private Krypton.Toolkit.KryptonTextBox tbJmbg;
        private Krypton.Toolkit.KryptonTextBox tbLastName;
        private Krypton.Toolkit.KryptonDateTimePicker dtpBirthDate;
        private Krypton.Toolkit.KryptonTextBox tbEmail;
        private Krypton.Toolkit.KryptonTextBox tbPhoneNumber;
        private Krypton.Toolkit.KryptonTextBox tbAdditionalInfo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox tbDocumentDragDropArea;
        private Krypton.Toolkit.KryptonPanel AttachmentDisplayPanel;
        private Krypton.Toolkit.KryptonTextBox tbPhotoDragDrop;
        private Krypton.Toolkit.KryptonButton btnAddLink;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonTextBox tbAddLink;
        private Krypton.Toolkit.KryptonPanel LinksPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonNumericUpDown numRating;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonComboBox cbStatus;
    }
}