namespace CandidateLog.QuickDialogs
{
    partial class QuickEditRatingStatus
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
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.numRating = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblCandidateInfo = new Krypton.Toolkit.KryptonLabel();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStatus.DropDownWidth = 159;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(289, 88);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(143, 26);
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 42;
            this.cbStatus.Text = "Candidate";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel10.Location = new System.Drawing.Point(202, 88);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel10.TabIndex = 41;
            this.kryptonLabel10.Values.Text = "Status";
            // 
            // numRating
            // 
            this.numRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Location = new System.Drawing.Point(94, 88);
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
            this.numRating.TabIndex = 40;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 90);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel9.TabIndex = 39;
            this.kryptonLabel9.Values.Text = "Rating";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(239, 24);
            this.kryptonLabel1.TabIndex = 43;
            this.kryptonLabel1.Values.Text = "Quick edit Rating and/or status ";
            // 
            // lblCandidateInfo
            // 
            this.lblCandidateInfo.Location = new System.Drawing.Point(12, 42);
            this.lblCandidateInfo.Name = "lblCandidateInfo";
            this.lblCandidateInfo.Size = new System.Drawing.Size(164, 24);
            this.lblCandidateInfo.TabIndex = 44;
            this.lblCandidateInfo.Values.Text = "ID 01 Name LastName";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(567, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 34);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // QuickEditRatingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 132);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCandidateInfo);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.kryptonLabel9);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(727, 179);
            this.Name = "QuickEditRatingStatus";
            this.Text = "Quick Edit";
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cbStatus;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonNumericUpDown numRating;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblCandidateInfo;
        private Krypton.Toolkit.KryptonButton btnUpdate;
    }
}