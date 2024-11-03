using CandidateLog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CandidateLog
{
    public partial class SelectDocumentType : KryptonForm
    {
        public Attachment Sender { get; set; }
        public SelectDocumentType(Attachment sender)
        {
            InitializeComponent();
            Sender = sender;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Sender.Type = (byte)Resources.FileType.Resume;
            this.Close();
        }

        private void btnCoverLetter_Click(object sender, EventArgs e)
        {
            Sender.Type = (byte)Resources.FileType.CoverLetter;
            this.Close();
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            Sender.Type = (byte)Resources.FileType.Certificate;
            this.Close();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            Sender.Type = (byte)Resources.FileType.Other;
            this.Close();
        }
    }
}
