namespace CandidateLog
{
    partial class SelectDocumentType
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnResume = new Krypton.Toolkit.KryptonButton();
            this.btnCoverLetter = new Krypton.Toolkit.KryptonButton();
            this.btnCertificate = new Krypton.Toolkit.KryptonButton();
            this.btnOther = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(29, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(209, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Please select document type.";
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(29, 74);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(138, 34);
            this.btnResume.TabIndex = 1;
            this.btnResume.Values.Text = "Resume";
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnCoverLetter
            // 
            this.btnCoverLetter.Location = new System.Drawing.Point(173, 74);
            this.btnCoverLetter.Name = "btnCoverLetter";
            this.btnCoverLetter.Size = new System.Drawing.Size(138, 34);
            this.btnCoverLetter.TabIndex = 3;
            this.btnCoverLetter.Values.Text = "Cover Letter";
            this.btnCoverLetter.Click += new System.EventHandler(this.btnCoverLetter_Click);
            // 
            // btnCertificate
            // 
            this.btnCertificate.Location = new System.Drawing.Point(317, 74);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(138, 34);
            this.btnCertificate.TabIndex = 4;
            this.btnCertificate.Values.Text = "Certificate";
            this.btnCertificate.Click += new System.EventHandler(this.btnCertificate_Click);
            // 
            // btnOther
            // 
            this.btnOther.Location = new System.Drawing.Point(461, 74);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(138, 34);
            this.btnOther.TabIndex = 5;
            this.btnOther.Values.Text = "Other";
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // SelectDocumentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 125);
            this.CloseBox = false;
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnCertificate);
            this.Controls.Add(this.btnCoverLetter);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 212);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(635, 172);
            this.Name = "SelectDocumentType";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnResume;
        private Krypton.Toolkit.KryptonButton btnCoverLetter;
        private Krypton.Toolkit.KryptonButton btnCertificate;
        private Krypton.Toolkit.KryptonButton btnOther;
    }
}