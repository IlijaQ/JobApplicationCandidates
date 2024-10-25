using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidates
{
    public partial class Candidates : KryptonForm
    {
        public Candidates()
        {
            InitializeComponent();

            cbStatus.Items.Clear();
            cbStatus.Items.Add("All");
            string[] statuses = Enum.GetNames(typeof(Resources.Status));
            cbStatus.Items.AddRange(statuses);

            gbNameJmbgFilters.Text = "Filter by Name and jmbg";
            gbDateFilters.Text = "Filter by Date";
            gbStatusAndRatingFilters.Text = "Status and Rating";
        }

        private void btnResetNameJmbgFilters_Click(object sender, EventArgs e)
        {
            ResetNameJmbgFilters();
        }
        private void ResetNameJmbgFilters()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbJmbg.Text = string.Empty;
        }

        private void btnResetDateFilters_Click(object sender, EventArgs e)
        {
            ResetDateFilters();
        }
        private void ResetDateFilters()
        {
            dtpUpdatedAfter.Enabled = false;
            dtpUpdatedBefore.Enabled = false;

            dtpUpdatedAfter.Value = DateTime.Parse("1/1/2024");
            dtpUpdatedBefore.Value = DateTime.Now;
        }

        private void btnResetStatusRatingFilters_Click(object sender, EventArgs e)
        {
            ResetStatusRating();
        }
        private void ResetStatusRating()
        {
            cbStatus.SelectedItem = "All";
            numRatingUpper.Enabled = false;
            numRatingLower.Enabled = false;
            numRatingUpper.Value = 5;
            numRatingLower.Value = 1;
        }

        private void btnResetAllFilters_Click(object sender, EventArgs e)
        {
            ResetNameJmbgFilters();
            ResetDateFilters();
            ResetStatusRating();
        }

        private void btnEnableFilterUpdatedBefore_Click(object sender, EventArgs e)
        {
            dtpUpdatedBefore.Enabled = !dtpUpdatedBefore.Enabled;
        }

        private void btnEnableFilterUpdatedAfter_Click(object sender, EventArgs e)
        {
            dtpUpdatedAfter.Enabled = !dtpUpdatedAfter.Enabled;
        }

        private void btnEnableFilterUpperRating_Click(object sender, EventArgs e)
        {
            numRatingUpper.Enabled= !numRatingUpper.Enabled;
        }

        private void btnEnableFilterLowerRating_Click(object sender, EventArgs e)
        {
            numRatingLower.Enabled = !numRatingLower.Enabled;
        }

        private void dtpUpdatedBefore_ValueChanged(object sender, EventArgs e)
        {
            if (dtpUpdatedBefore.Value > DateTime.Now)
                dtpUpdatedBefore.Value = DateTime.Now;

            if (dtpUpdatedBefore.Value < dtpUpdatedAfter.Value)
                dtpUpdatedAfter.Value = dtpUpdatedBefore.Value;
        }

        private void dtpUpdatedAfter_ValueChanged(object sender, EventArgs e)
        {
            if (dtpUpdatedAfter.Value > dtpUpdatedBefore.Value)
                dtpUpdatedBefore.Value = dtpUpdatedAfter.Value;
        }

        private void numRatingUpper_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingUpper.Value < numRatingLower.Value)
                numRatingLower.Value = numRatingUpper.Value;
        }

        private void numRatingLower_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingLower.Value > numRatingUpper.Value)
                numRatingUpper.Value = numRatingLower.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
