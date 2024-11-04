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

namespace CandidateLog
{
    public partial class PhotoFileView : KryptonForm
    {
        public PhotoFileView(string path)
        {
            InitializeComponent();
            this.Text = Path.GetFileName(path);
            this.Controls.Add(new PictureBox
            {
                ImageLocation = path,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            });
        }
    }
}
