namespace CandidateLog.FileViewers
{
    partial class TextFileView
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
            this.tbTextArea = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // tbTextArea
            // 
            this.tbTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextArea.Location = new System.Drawing.Point(12, 12);
            this.tbTextArea.Multiline = true;
            this.tbTextArea.Name = "tbTextArea";
            this.tbTextArea.ReadOnly = true;
            this.tbTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextArea.Size = new System.Drawing.Size(1023, 578);
            this.tbTextArea.TabIndex = 0;
            // 
            // TextFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1047, 602);
            this.Controls.Add(this.tbTextArea);
            this.MinimumSize = new System.Drawing.Size(961, 572);
            this.Name = "TextFileView";
            this.Text = "TextFileView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox tbTextArea;
    }
}