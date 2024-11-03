using CandidateLog.Data;
using CandidateLog.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidateLog.QuickDialogs
{
    public partial class QuickEditRatingStatus : KryptonForm
    {
        private Candidate Candidate { get; set; }
        private Candidates PreviousForm { get; }
        public QuickEditRatingStatus(Candidates previousForm, int id)
        {
            InitializeComponent();

            PreviousForm = previousForm;

            GetCandidate(id);
            PopulateUiWithCandidateData();
            this.PreviousForm = previousForm;
        }

        private void PopulateUiWithCandidateData()
        {
            lblCandidateInfo.Text = $"ID {Candidate.Id}  {Candidate.Name} {Candidate.LastName}";

            var statuses = Enum.GetValues(typeof(Resources.Status)).Cast<Resources.Status>().Skip(1).ToList(); // "All" is skiped
            cbStatus.DataSource = statuses;
            cbStatus.SelectedIndex = Candidate.Status - 1;

            numRating.Value = Candidate.Rating;
        }

        private void GetCandidate(int id)
        {
            try
            {
                using (var db = new CandidateContext())
                {
                    var repo = new Repository(db);
                    Candidate = repo.GetCandidate(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CandidateContext())
                {
                    var repo = new Repository(db);
                    byte currentStatus = (byte)(Resources.Status)cbStatus.SelectedItem;
                    repo.UpdateRatingAndStatus(Candidate.Id, (byte)numRating.Value, currentStatus);
                }
                PreviousForm.PopulateCandidatesGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
