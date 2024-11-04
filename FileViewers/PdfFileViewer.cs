using Krypton.Toolkit;
using Spire.PdfViewer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidateLog.FileViewers
{
    public partial class PdfFileViewer : KryptonForm
    {
        public PdfFileViewer(string path)
        {
            InitializeComponent();

            PdfViewer pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.LoadFromFile(path);

            this.Text = Path.GetFileName(path);
            this.Controls.Add(pdfViewer);
            this.AutoScroll = true;
        }
    }
}
