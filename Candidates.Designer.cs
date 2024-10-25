namespace Candidates
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
            this.dgwCandidates = new Krypton.Toolkit.KryptonDataGridView();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.lblCount = new Krypton.Toolkit.KryptonLabel();
            this.tbFirstName = new Krypton.Toolkit.KryptonTextBox();
            this.tbLastName = new Krypton.Toolkit.KryptonTextBox();
            this.numRatingUpper = new Krypton.Toolkit.KryptonNumericUpDown();
            this.numRatingLower = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
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
            this.btnResetNameJmbgFilters = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnResetAllFilters = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.btnNewCandidate = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
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
            this.SuspendLayout();
            // 
            // dgwCandidates
            // 
            this.dgwCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCandidates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwCandidates.ColumnHeadersHeight = 36;
            this.dgwCandidates.Location = new System.Drawing.Point(12, 216);
            this.dgwCandidates.Name = "dgwCandidates";
            this.dgwCandidates.RowHeadersWidth = 51;
            this.dgwCandidates.RowTemplate.Height = 24;
            this.dgwCandidates.Size = new System.Drawing.Size(1298, 391);
            this.dgwCandidates.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1185, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Values.Text = "Close";
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
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(213, 27);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.CueHint.CueHintText = "Last Name";
            this.tbLastName.Location = new System.Drawing.Point(242, 12);
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
            0,
            0,
            0,
            0});
            this.numRatingUpper.Name = "numRatingUpper";
            this.numRatingUpper.Size = new System.Drawing.Size(63, 26);
            this.numRatingUpper.TabIndex = 5;
            this.numRatingUpper.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            0,
            0,
            0,
            0});
            this.numRatingLower.Name = "numRatingLower";
            this.numRatingLower.Size = new System.Drawing.Size(63, 26);
            this.numRatingLower.TabIndex = 6;
            this.numRatingLower.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 206;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Location = new System.Drawing.Point(167, 16);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(206, 26);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 7;
            this.kryptonComboBox1.Text = "cbStatus";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Enabled = false;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(161, 16);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(215, 25);
            this.kryptonDateTimePicker1.TabIndex = 8;
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.Enabled = false;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(161, 47);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(215, 25);
            this.kryptonDateTimePicker2.TabIndex = 9;
            // 
            // gbStatusAndRatingFilters
            // 
            this.gbStatusAndRatingFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatusAndRatingFilters.Location = new System.Drawing.Point(909, 63);
            this.gbStatusAndRatingFilters.Name = "gbStatusAndRatingFilters";
            // 
            // gbStatusAndRatingFilters.Panel
            // 
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.btnEnableFilterLowerRating);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.btnEnableFilterUpperRating);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.kryptonLabel1);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.btnResetStatusRatingFilters);
            this.gbStatusAndRatingFilters.Panel.Controls.Add(this.kryptonComboBox1);
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
            // 
            // btnEnableFilterUpperRating
            // 
            this.btnEnableFilterUpperRating.Location = new System.Drawing.Point(26, 48);
            this.btnEnableFilterUpperRating.Name = "btnEnableFilterUpperRating";
            this.btnEnableFilterUpperRating.Size = new System.Drawing.Size(119, 28);
            this.btnEnableFilterUpperRating.TabIndex = 13;
            this.btnEnableFilterUpperRating.Values.Text = "Upper Rating";
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
            // 
            // gbDateFilters
            // 
            this.gbDateFilters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDateFilters.Location = new System.Drawing.Point(502, 63);
            this.gbDateFilters.Name = "gbDateFilters";
            // 
            // gbDateFilters.Panel
            // 
            this.gbDateFilters.Panel.Controls.Add(this.btnEnableFilterUpdatedAfter);
            this.gbDateFilters.Panel.Controls.Add(this.btnResetDateFilters);
            this.gbDateFilters.Panel.Controls.Add(this.btnEnableFilterUpdatedBefore);
            this.gbDateFilters.Panel.Controls.Add(this.kryptonDateTimePicker2);
            this.gbDateFilters.Panel.Controls.Add(this.kryptonDateTimePicker1);
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
            // 
            // btnResetDateFilters
            // 
            this.btnResetDateFilters.Location = new System.Drawing.Point(266, 77);
            this.btnResetDateFilters.Name = "btnResetDateFilters";
            this.btnResetDateFilters.Size = new System.Drawing.Size(110, 28);
            this.btnResetDateFilters.TabIndex = 15;
            this.btnResetDateFilters.Values.Text = "Reset Filters";
            // 
            // btnEnableFilterUpdatedBefore
            // 
            this.btnEnableFilterUpdatedBefore.Location = new System.Drawing.Point(22, 16);
            this.btnEnableFilterUpdatedBefore.Name = "btnEnableFilterUpdatedBefore";
            this.btnEnableFilterUpdatedBefore.Size = new System.Drawing.Size(119, 28);
            this.btnEnableFilterUpdatedBefore.TabIndex = 15;
            this.btnEnableFilterUpdatedBefore.Values.Text = "Updated before";
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
            this.gbNameJmbgFilters.Location = new System.Drawing.Point(12, 64);
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
            // btnResetNameJmbgFilters
            // 
            this.btnResetNameJmbgFilters.Location = new System.Drawing.Point(345, 79);
            this.btnResetNameJmbgFilters.Name = "btnResetNameJmbgFilters";
            this.btnResetNameJmbgFilters.Size = new System.Drawing.Size(110, 28);
            this.btnResetNameJmbgFilters.TabIndex = 17;
            this.btnResetNameJmbgFilters.Values.Text = "Reset Filters";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 82);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(299, 24);
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "Leave empty textbox(es) to disable filter(s)";
            // 
            // btnResetAllFilters
            // 
            this.btnResetAllFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAllFilters.Location = new System.Drawing.Point(1170, 12);
            this.btnResetAllFilters.Name = "btnResetAllFilters";
            this.btnResetAllFilters.Size = new System.Drawing.Size(135, 26);
            this.btnResetAllFilters.TabIndex = 14;
            this.btnResetAllFilters.Values.Text = "Reset All Filters";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(153, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 26);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Values.Text = "Search";
            // 
            // btnNewCandidate
            // 
            this.btnNewCandidate.Location = new System.Drawing.Point(12, 12);
            this.btnNewCandidate.Name = "btnNewCandidate";
            this.btnNewCandidate.Size = new System.Drawing.Size(135, 26);
            this.btnNewCandidate.TabIndex = 16;
            this.btnNewCandidate.Values.Text = "New Candidate";
            // 
            // Candidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1322, 653);
            this.Controls.Add(this.btnNewCandidate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnResetAllFilters);
            this.Controls.Add(this.gbNameJmbgFilters);
            this.Controls.Add(this.gbDateFilters);
            this.Controls.Add(this.gbStatusAndRatingFilters);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgwCandidates);
            this.MinimumSize = new System.Drawing.Size(1340, 700);
            this.Name = "Candidates";
            this.Text = "Candidates";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgwCandidates;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel lblCount;
        private Krypton.Toolkit.KryptonTextBox tbFirstName;
        private Krypton.Toolkit.KryptonTextBox tbLastName;
        private Krypton.Toolkit.KryptonNumericUpDown numRatingUpper;
        private Krypton.Toolkit.KryptonNumericUpDown numRatingLower;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
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
    }
}

