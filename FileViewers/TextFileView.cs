using Krypton.Toolkit;
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
    public partial class TextFileView : KryptonForm
    {
        public TextFileView(string path)
        {
            InitializeComponent();
            string[] textlines = File.ReadAllLines(path);
            tbTextArea.Text = string.Join("\r\n", textlines);
            this.Text = Path.GetFileName(path);
        }
    }
}
