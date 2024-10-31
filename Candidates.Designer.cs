namespace CandidateLog
{
    partial class Candidates
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
            this.dgvCandidates = new Krypton.Toolkit.KryptonDataGridView();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.lblCount = new Krypton.Toolkit.KryptonLabel();
            this.tbFirstName = new Krypton.Toolkit.KryptonTextBox();
            this.tbLastName = new Krypton.Toolkit.KryptonTextBox();
            this.numRatingUpper = new Krypton.Toolkit.KryptonNumericUpDown();
            this.numRatingLower = new Krypton.Toolkit.KryptonNumericUpDown();
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.dtpUpdatedBefore = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpUpdatedAfter = new Krypton.Toolkit.KryptonDateTimePicker();
            this.gbStatusAndRatingFilters = new Krypton.Toolkit.KryptonGroupBox();
            this.btnEnableFilterLowerRating = new Krypton.Toolkit.KryptonButton();
            this.btnEnableFilterUpperRating = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnResetStatusRatingFilters = new Krypton.Toolkit.KryptonButton();
            this.gbDateFilters = new Krypton.Toolkit.KryptonGroupBox();
            this.btnEnableFilterUpdatedAfter = new Krypton.Toolkit.KryptonButton();
            this.btnResetDateFilters = new Krypton.Toolkit.KryptonButton();
            this.btnEnableFilterUpdatedBefore = new Krypton.Toolkit.KryptonButton();
            this.tbJmbg = new Krypton.Toolkit.KryptonTextBox();
            this.gbNameJmbgFilters = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnResetNameJmbgFilters = new Krypton.Toolkit.KryptonButton();
            this.btnResetAllFilters = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.btnNewCandidate = new Krypton.Toolkit.KryptonButton();
            this.SearchPanel = new Krypton.Toolkit.KryptonPanel();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            this.bgwGetCandidates = new System.ComponentModel.BackgroundWorker();
            this.btnExportToXlsx = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatusAndRatingFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatusAndRatingFilters.Panel)).BeginInit();
            this.gbStatusAndRatingFilters.Panel.SuspendLayout();
            this.gbStatusAndRatingFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDateFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDateFilters.Panel)).BeginInit();
            this.gbDateFilters.Panel.SuspendLayout();
            this.gbDateFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNameJmbgFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNameJmbgFilters.Panel)).BeginInit();
            this.gbNameJmbgFilters.Panel.SuspendLayout();
            this.gbNameJmbgFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AllowUserToOrderColumns = true;
            this.dgvCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCandidates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidates.ColumnHeadersHeight = 36;
            this.dgvCandidates.Location = new System.Drawing.Point(12, 216);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.RowHeadersWidth = 51;
            this.dgvCandidates.RowTemplate.Height = 24;
            this.dgvCandidates.Size = new System.Drawing.Size(1324, 391);
            this.dgvCandidates.TabIndex = 0;
            this.dgvCandidates.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCandidates_ColumnHeaderMouseClick);
            this.dgvCandidates.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCandidates_RowPostPaint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1211, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.Location = new System.Drawing.Point(12, 617);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(56, 24);
            this.lblCount.TabIndex = 2;
            this.lblCount.Values.Text = "Count:";
            this.lblCount.Visible = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.CueHint.CueHintText = "First Name";
            this.tbFirstName.Location = new System.Drawing.Point(23, 12);
            this.tbFirstName.MaxLength = 100;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(213, 27);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.CueHint.CueHintText = "Last Name";
            this.tbLastName.Location = new System.Drawing.Point(242, 12);
            this.tbLastName.MaxLength = 100;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(213, 27);
            this.tbLastName.TabIndex = 4;
            // 
            // numRatingUpper
            // 
            this.numRatingUpper.Enabled = false;
            this.numRatingUpper.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatingUpper.Location = new System.Drawing.Point(167, 48);
            this.numRatingUpper.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatingUpper.Name = "numRatingUpper";
            this.numRatingUpper.Size = new System.Drawing.Size(63, 26);
            this.numRatingUpper.TabIndex = 5;
            this.numRatingUpper.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingUpper.ValueChanged += new System.EventHandler(this.numRatingUpper_ValueChanged);
            // 
            // numRatingLower
            // 
            this.numRatingLower.Enabled = false;
            this.numRatingLower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatingLower.Location = new System.Drawing.Point(167, 80);
            this.numRatingLower.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatingLower.Name = "numRatingLower";
            this.numRatingLower.Size = new System.Drawing.Size(63, 26);
            this.numRatingLower.TabIndex = 6;
            this.numRatingLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatingLower.ValueChanged += new System.EventHandler(this.numRatingLower_ValueChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 206;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(167, 16);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(206, 26);
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Text = "All";
            // 
            // dtpUpdatedBefore
            // 
            this.dtpUpdatedBefore.Enabled = false;
            this.dtpUpdatedBefore.Location = new System.Drawing.Point(161, 16);
            this.dtpUpdatedBefore.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpUpdatedBefore.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpUpdatedBefore.Name = "dtpUpdatedBefore";
            this.dtpUpdatedBefore.Size = new System.Drawing.Size(215, 25);
            this.dtpUpdatedBefore.TabIndex = 8;
            this.dtpUpdatedBefore.ValueChanged += new System.EventHandler(this.dtpUpdatedBefore_ValueChanged);
            // 
            // dtpUpdatedAfter
            // 
            this.dtpUpdatedAfter.Enabled = false;
            this.dtpUpdatedAfter.Location = new System.Drawing.Point(161, 47);
            this.dtpUpdatedAfter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpUpdatedAfter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpUpdatedAfter.Name = "dtpUpdatedAfter";
            this.dtpUpdatedAfter.Size = new System.Drawing.Size(215, 25);
            this.dtpUpdatedAfter.TabIndex = 9;
            this.dtpUpdatedAfter.ValueChanged += new System.EventHandler(this.dtpUpdatedAfter_ValueChanged);
            // 
            // gbStatusAndRatingFilters
            // 
            this.gbStatusAndRatingFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatusAndRatingFilters.Location = new System.Drawing.Point(935, 63);
            this.gbStatusAndRatingFilters.Name = "gbStatusAndRatingFilters";
            // 
            // gbStatusAndRatingFilters.Panel
            // 
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.btnEnableFilterLowerRating);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.btnEnableFilterUpperRating);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.kryptonLabel1);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.btnResetStatusRatingFilters);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.cbStatus);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.numRatingUpper);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.numRatingLower);
            this.gbStatusAndRatingFilters.Size = new System.Drawing.Size(401, 147);
            this.gbStatusAndRatingFilters.TabIndex = 10;
            // 
            // btnEnableFilterLowerRating
            // 
            this.btnEnableFilterLowerRating.Location = new System.Drawing.Point(26, 80);
            this.btnEnableFilterLowerRating.Name = "btnEnableFilterLowerRating";
            this.btnEnableFilterLowerRating.Size = new System.Drawing.Size(119, 28);
            this.btnEnableFilterLowerRating.TabIndex = 14;
            this.btnEnableFilterLowerRating.Values.Text = "Lower Rating";
            this.btnEnableFilterLowerRating.Click += new System.EventHandler(this.btnEnableFilterLowerRating_Click);
            // 
            // btnEnableFilterUpperRating
            // 
            this.btnEnableFilterUpperRating.Location = new System.Drawing.Point(26, 48);
            this.btnEnableFilterUpperRating.Name = "btnEnableFilterUpperRating";
            this.btnEnableFilterUpperRating.Size = new System.Drawing.Size(119, 28);
            this.btnEnableFilterUpperRating.TabIndex = 13;
            this.btnEnableFilterUpperRating.Values.Text = "Upper Rating";
            this.btnEnableFilterUpperRating.Click += new System.EventHandler(this.btnEnableFilterUpperRating_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(47, 16);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 24);
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "Select Status";
            // 
            // btnResetStatusRatingFilters
            // 
            this.btnResetStatusRatingFilters.Location = new System.Drawing.Point(263, 78);
            this.btnResetStatusRatingFilters.Name = "btnResetStatusRatingFilters";
            this.btnResetStatusRatingFilters.Size = new System.Drawing.Size(110, 28);
            this.btnResetStatusRatingFilters.TabIndex = 11;
            this.btnResetStatusRatingFilters.Values.Text = "Reset Filters";
            this.btnResetStatusRatingFilters.Click += new System.EventHandler(this.btnResetStatusRatingFilters_Click);
            // 
            // gbDateFilters
            // 
            this.gbDateFilters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDateFilters.Location = new System.Drawing.Point(515, 63);
            this.gbDateFilters.Name = "gbDateFilters";
            // 
            // gbDateFilters.Panel
            // 
            this.gbDateFilters.Panel.Controls.Add(this.btnEnableFilterUpdatedAfter);
            this.gbDateFilters.Panel.Controls.Add(this.btnResetDateFilters);
            this.gbDateFilters.Panel.Controls.Add(this.btnEnableFilterUpdatedBefore);
            this.gbDateFilters.Panel.Controls.Add(this.dtpUpdatedAfter);
            this.gbDateFilters.Panel.Controls.Add(this.dtpUpdatedBefore);
            this.gbDateFilters.Size = new System.Drawing.Size(401, 146);
            this.gbDateFilters.TabIndex = 11;
            // 
            // btnEnableFilterUpdatedAfter
            // 
            this.btnEnableFilterUpdatedAfter.Location = new System.Drawing.Point(22, 48);
            this.btnEnableFilterUpdatedAfter.Name = "btnEnableFilterUpdatedAfter";
            this.btnEnableFilterUpdatedAfter.Size = new System.Drawing.Size(119, 28);
            this.btnEnableFilterUpdatedAfter.TabIndex = 16;
            this.btnEnableFilterUpdatedAfter.Values.Text = "Updated after";
            this.btnEnableFilterUpdatedAfter.Click += new System.EventHandler(this.btnEnableFilterUpdatedAfter_Click);
            // 
            // btnResetDateFilters
            // 
            this.btnResetDateFilters.Location = new System.Drawing.Point(266, 77);
            this.btnResetDateFilters.Name = "btnResetDateFilters";
            this.btnResetDateFilters.Size = new System.Drawing.Size(110, 28);
            this.btnResetDateFilters.TabIndex = 15;
            this.btnResetDateFilters.Values.Text = "Reset Filters";
            this.btnResetDateFilters.Click += new System.EventHandler(this.btnResetDateFilters_Click);
            // 
            // btnEnableFilterUpdatedBefore
            // 
            this.btnEnableFilterUpdatedBefore.Location = new System.Drawing.Point(22, 16);
            this.btnEnableFilterUpdatedBefore.Name = "btnEnableFilterUpdatedBefore";
            this.btnEnableFilterUpdatedBefore.Size = new System.Drawing.Size(119, 28);
            this.btnEnableFilterUpdatedBefore.TabIndex = 15;
            this.btnEnableFilterUpdatedBefore.Values.Text = "Updated before";
            this.btnEnableFilterUpdatedBefore.Click += new System.EventHandler(this.btnEnableFilterUpdatedBefore_Click);
            // 
            // tbJmbg
            // 
            this.tbJmbg.CueHint.CueHintText = "JMBG";
            this.tbJmbg.Location = new System.Drawing.Point(23, 49);
            this.tbJmbg.MaxLength = 13;
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(432, 27);
            this.tbJmbg.TabIndex = 12;
            // 
            // gbNameJmbgFilters
            // 
            this.gbNameJmbgFilters.Location = new System.Drawing.Point(12, 63);
            this.gbNameJmbgFilters.Name = "gbNameJmbgFilters";
            // 
            // gbNameJmbgFilters.Panel
            // 
            this.gbNameJmbgFilters.Panel.Controls.Add(this.kryptonLabel2);
            this.gbNameJmbgFilters.Panel.Controls.Add(this.btnResetNameJmbgFilters);
            this.gbNameJmbgFilters.Panel.Controls.Add(this.tbFirstName);
            this.gbNameJmbgFilters.Panel.Controls.Add(this.tbJmbg);
            this.gbNameJmbgFilters.Panel.Controls.Add(this.tbLastName);
            this.gbNameJmbgFilters.Size = new System.Drawing.Size(484, 146);
            this.gbNameJmbgFilters.TabIndex = 13;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 82);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(299, 24);
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "Leave empty textbox(es) to disable filter(s)";
            // 
            // btnResetNameJmbgFilters
            // 
            this.btnResetNameJmbgFilters.Location = new System.Drawing.Point(345, 79);
            this.btnResetNameJmbgFilters.Name = "btnResetNameJmbgFilters";
            this.btnResetNameJmbgFilters.Size = new System.Drawing.Size(110, 28);
            this.btnResetNameJmbgFilters.TabIndex = 17;
            this.btnResetNameJmbgFilters.Values.Text = "Reset Filters";
            this.btnResetNameJmbgFilters.Click += new System.EventHandler(this.btnResetNameJmbgFilters_Click);
            // 
            // btnResetAllFilters
            // 
            this.btnResetAllFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAllFilters.Location = new System.Drawing.Point(1196, 12);
            this.btnResetAllFilters.Name = "btnResetAllFilters";
            this.btnResetAllFilters.Size = new System.Drawing.Size(135, 26);
            this.btnResetAllFilters.TabIndex = 14;
            this.btnResetAllFilters.Values.Text = "Reset All Filters";
            this.btnResetAllFilters.Click += new System.EventHandler(this.btnResetAllFilters_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(153, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 26);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewCandidate
            // 
            this.btnNewCandidate.Location = new System.Drawing.Point(12, 12);
            this.btnNewCandidate.Name = "btnNewCandidate";
            this.btnNewCandidate.Size = new System.Drawing.Size(135, 26);
            this.btnNewCandidate.TabIndex = 16;
            this.btnNewCandidate.Values.Text = "New Candidate";
            this.btnNewCandidate.Click += new System.EventHandler(this.btnNewCandidate_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchPanel.Controls.Add(this.lblSearch);
            this.SearchPanel.Controls.Add(this.kryptonProgressBar1);
            this.SearchPanel.Location = new System.Drawing.Point(515, 332);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(361, 85);
            this.SearchPanel.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.SearchPanel.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(124, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 24);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Values.Text = "Fetching Data...";
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.Location = new System.Drawing.Point(24, 43);
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Size = new System.Drawing.Size(315, 27);
            this.kryptonProgressBar1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonProgressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kryptonProgressBar1.TabIndex = 0;
            this.kryptonProgressBar1.Text = "Searching...";
            this.kryptonProgressBar1.Values.Text = "Searching...";
            // 
            // bgwGetCandidates
            // 
            this.bgwGetCandidates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetCandidates_DoWork);
            this.bgwGetCandidates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetCandidates_RunWorkerCompleted);
            // 
            // btnExportToXlsx
            // 
            this.btnExportToXlsx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportToXlsx.Location = new System.Drawing.Point(163, 613);
            this.btnExportToXlsx.Name = "btnExportToXlsx";
            this.btnExportToXlsx.Size = new System.Drawing.Size(125, 28);
            this.btnExportToXlsx.TabIndex = 18;
            this.btnExportToXlsx.Values.Text = "Export to xlsx";
            this.btnExportToXlsx.Visible = false;
            this.btnExportToXlsx.Click += new System.EventHandler(this.btnExportToXlsx_Click);
            // 
            // Candidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 653);
            this.Controls.Add(this.btnExportToXlsx);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.btnNewCandidate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnResetAllFilters);
            this.Controls.Add(this.gbNameJmbgFilters);
            this.Controls.Add(this.gbDateFilters);
            this.Controls.Add(this.gbStatusAndRatingFilters);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCandidates);
            this.MinimumSize = new System.Drawing.Size(1340, 700);
            this.Name = "Candidates";
            this.Text = "Candidates";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatusAndRatingFilters.Panel)).EndInit();
            this.gbStatusAndRatingFilters.Panel.ResumeLayout(false);
            this.gbStatusAndRatingFilters.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatusAndRatingFilters)).EndInit();
            this.gbStatusAndRatingFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbDateFilters.Panel)).EndInit();
            this.gbDateFilters.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbDateFilters)).EndInit();
            this.gbDateFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbNameJmbgFilters.Panel)).EndInit();
            this.gbNameJmbgFilters.Panel.ResumeLayout(false);
            this.gbNameJmbgFilters.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNameJmbgFilters)).EndInit();
            this.gbNameJmbgFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvCandidates;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel lblCount;
        private Krypton.Toolkit.KryptonTextBox tbFirstName;
        private Krypton.Toolkit.KryptonTextBox tbLastName;
        private Krypton.Toolkit.KryptonNumericUpDown numRatingUpper;
        private Krypton.Toolkit.KryptonNumericUpDown numRatingLower;
        private Krypton.Toolkit.KryptonComboBox cbStatus;
        private Krypton.Toolkit.KryptonDateTimePicker dtpUpdatedBefore;
        private Krypton.Toolkit.KryptonDateTimePicker dtpUpdatedAfter;
        private Krypton.Toolkit.KryptonGroupBox gbStatusAndRatingFilters;
        private Krypton.Toolkit.KryptonButton btnResetStatusRatingFilters;
        private Krypton.Toolkit.KryptonButton btnEnableFilterUpperRating;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnEnableFilterLowerRating;
        private Krypton.Toolkit.KryptonGroupBox gbDateFilters;
        private Krypton.Toolkit.KryptonButton btnResetDateFilters;
        private Krypton.Toolkit.KryptonTextBox tbJmbg;
        private Krypton.Toolkit.KryptonButton btnEnableFilterUpdatedAfter;
        private Krypton.Toolkit.KryptonButton btnEnableFilterUpdatedBefore;
        private Krypton.Toolkit.KryptonGroupBox gbNameJmbgFilters;
        private Krypton.Toolkit.KryptonButton btnResetNameJmbgFilters;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnResetAllFilters;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonButton btnNewCandidate;
        private Krypton.Toolkit.KryptonPanel SearchPanel;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
        private System.ComponentModel.BackgroundWorker bgwGetCandidates;
        private Krypton.Toolkit.KryptonButton btnExportToXlsx;
    }
}

