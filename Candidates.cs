using CandidateLog.Data;
using CandidateLog.Models;
using CandidateLog.QuickDialogs;
using CandidateLog.Resources;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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

namespace CandidateLog
{
    public partial class Candidates : KryptonForm
    {
        private CandidateSearchFilter SearchFilter { get; set; }
        private string LastSortedColumn {  get; set; }

        public Candidates()
        {
            InitializeComponent();

            cbStatus.DataSource = Enum.GetValues(typeof(Resources.Status));

            gbNameJmbgFilters.Text = "Filter by Name and jmbg";
            gbDateFilters.Text = "Filter by Date";
            gbStatusAndRatingFilters.Text = "Status and Rating";

            PopulateCandidatesGrid();
        }
        public void PopulateCandidatesGrid()
        {
            dgvCandidates.DataSource = null;
            dgvCandidates.Rows.Clear();
            dgvCandidates.Columns.Clear();
            GetSearchFilters();
            bgwGetCandidates.RunWorkerAsync();
        }
        private void GetSearchFilters()
        {
            SearchFilter = new CandidateSearchFilter();

            if (!string.IsNullOrEmpty(tbFirstName.Text))
                SearchFilter.FirstName = tbFirstName.Text;

            if (!string.IsNullOrEmpty(tbLastName.Text))
                SearchFilter.LastName = tbLastName.Text;

            if (!string.IsNullOrEmpty(tbJmbg.Text))
                SearchFilter.Jmbg = tbJmbg.Text;

            if (dtpUpdatedAfter.Enabled)
                SearchFilter.LastUpdateFrom = dtpUpdatedAfter.Value;

            if (dtpUpdatedBefore.Enabled)
                SearchFilter.LastUpdateTo = dtpUpdatedBefore.Value;

            if (numRatingUpper.Enabled)
                SearchFilter.RatingTo = (byte)numRatingUpper.Value;

            if (numRatingLower.Enabled)
                SearchFilter.RatingFrom = (byte)numRatingLower.Value;

            if ((Resources.Status)cbStatus.SelectedItem != Resources.Status.All)
                SearchFilter.Status = (byte)(Resources.Status)cbStatus.SelectedItem;
        }

        private void bgwGetCandidates_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgwGetCandidates.CancellationPending)
                return;

            try
            {
                using(var db = new CandidateContext())
                {
                    var repo = new Repository(db);
                    e.Result = repo.GetAllCandidates(SearchFilter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void bgwGetCandidates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                try
                {
                    var results = (List<Candidate>)e.Result;

                    if (results.Count == 0)
                    {
                        ZeroResultsUiChanges();
                        return;
                    }

                    BindingList<DisplayCandidate> dgvDisplayableResults = BindData.BindCandidates(results);
                    dgvCandidates.DataSource = dgvDisplayableResults;

                    ShowRowCountRelatedUi(results);

                    FormatGridColumns();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SearchPanel.Visible = false;
            SearchFilter = null;
        }

        private void ShowRowCountRelatedUi(List<Candidate> results)
        {
            lblCount.Text = "Count: " + results.Count;
            lblCount.Visible = true;
            btnExportToXlsx.Visible = true;
        }

        private void ZeroResultsUiChanges()
        {
            lblCount.Visible = false;
            SearchPanel.Visible = false;
            btnExportToXlsx.Visible = false;
            SearchFilter = null;

            MessageBox.Show("No Candidates in the database.\r\nClick\"New Candidate\" to insert new Candidates.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void FormatGridColumns()
        {
            dgvCandidates.Columns["DatabaseId"].HeaderText = "ID";
            dgvCandidates.Columns["LastName"].HeaderText = "Last Name";
            dgvCandidates.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvCandidates.Columns["LastUpdate"].HeaderText = "Last Update";

            dgvCandidates.Columns["LastUpdate"].DefaultCellStyle.Format = "dd.MM.yyyy.";

            dgvCandidates.Columns["DatabaseId"].Width = 40;
            dgvCandidates.Columns["DatabaseId"].MinimumWidth = 40;
            dgvCandidates.Columns["Name"].MinimumWidth = 100;
            dgvCandidates.Columns["LastName"].MinimumWidth = 100;
            dgvCandidates.Columns["Email"].Width = 250;
            dgvCandidates.Columns["Email"].MinimumWidth = 250;
            dgvCandidates.Columns["PhoneNumber"].MinimumWidth = 110;
            dgvCandidates.Columns["LastUpdate"].Width = 90;
            dgvCandidates.Columns["LastUpdate"].MinimumWidth = 90;
            dgvCandidates.Columns["Rating"].Width = 70;
            dgvCandidates.Columns["Rating"].MinimumWidth = 70;
            dgvCandidates.Columns["Status"].Width = 80;
            dgvCandidates.Columns["Status"].MinimumWidth = 80;

            KryptonDataGridViewButtonColumn editStatusRating = new KryptonDataGridViewButtonColumn();
            editStatusRating.Name = "EditStatusRating";
            editStatusRating.HeaderText = string.Empty;
            editStatusRating.DefaultCellStyle.NullValue = "Edit Status/Rating";
            editStatusRating.MinimumWidth = 120;
            dgvCandidates.Columns.Add(editStatusRating);

            KryptonDataGridViewButtonColumn viewCandidate = new KryptonDataGridViewButtonColumn();
            viewCandidate.Name = "ViewCandidate";
            viewCandidate.HeaderText = string.Empty;
            viewCandidate.DefaultCellStyle.NullValue = "View Candidate";
            viewCandidate.MinimumWidth = 110;
            dgvCandidates.Columns.Add(viewCandidate);
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
            cbStatus.SelectedItem = Resources.Status.All;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateCandidatesGrid();
        }

        private void dgvCandidates_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as KryptonDataGridView;

            DrawRowNumbers(e, grid);

            ChangeRowColorBasedOnStatus(e, grid);
        }
        private static void ChangeRowColorBasedOnStatus(DataGridViewRowPostPaintEventArgs e, DataGridView grid)
        {
            string status = grid.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            switch (status)
            {
                case "Candidate": grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.White; break;
                case "Qualified": grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow; break;
                case "Interview": grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue; break;
                case "ShortListed": grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed; break;
                case "Employee": grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow; break;
                default: grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray; break;
            }
        }
        private void DrawRowNumbers(DataGridViewRowPostPaintEventArgs e, DataGridView grid)
        {
            var rowIndex = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dgvCandidates_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = sender as KryptonDataGridView;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            if (columnName == "ViewCandidate")
                return;

            if (grid.DataSource is BindingList<DisplayCandidate> bindingList)
            {
                List<DisplayCandidate> sortedList;

                if (columnName != LastSortedColumn)
                {
                    sortedList = bindingList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                    LastSortedColumn = columnName;
                }
                else
                {
                    sortedList = bindingList.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                    LastSortedColumn = "purposely different to reverse sort order";
                }

                bindingList.Clear();
                foreach (var item in sortedList)
                    bindingList.Add(item);
            }
        }

        private void btnExportToXlsx_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Export Candidates to Excel file (xlsx)";

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    var workBook = new XLWorkbook();
                    var workSheet = workBook.Worksheets.Add("Sheet1");

                    for (int i = 0; i < dgvCandidates.Columns.Count - 1; i++)
                        workSheet.Cell(1, i + 1).Value = dgvCandidates.Columns[i].HeaderText;

                    for (int i = 0; i < dgvCandidates.Rows.Count; i++)
                    {
                        for(int j = 0; j < dgvCandidates.Columns.Count - 1; j++)
                        {
                            string cellValue = dgvCandidates.Rows[i].Cells[j].Value?.ToString();

                            if(j == 6)
                                cellValue = cellValue.Count(r => r == '*').ToString();

                            workSheet.Cell(i + 2, j + 1).Value = cellValue;
                        }
                    }

                    workSheet.Column(4).Width = 30;
                    workSheet.Column(5).Width = 16;
                    workSheet.Column(6).Width = 22;

                    workBook.SaveAs(filePath);

                    MessageBox.Show("Saved file\r\n" + filePath, "Success");
                }
            }
        }

        private void dgvCandidates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var column = e.ColumnIndex;
            var row = e.RowIndex;

            if (dgvCandidates.Columns[column].Name == "ViewCandidate")
            {
                int candidateId = (int)dgvCandidates.Rows[row].Cells["DatabaseId"].Value;

                CandidateInfo dialog = new CandidateInfo(this, candidateId);
                dialog.ShowDialog();
            }

            if (dgvCandidates.Columns[column].Name == "EditStatusRating")
            {
                int candidateId = (int)dgvCandidates.Rows[row].Cells["DatabaseId"].Value;

                QuickEditRatingStatus dialog = new QuickEditRatingStatus(this, candidateId);
                dialog.ShowDialog();
            }
        }

        private void btnNewCandidate_Click(object sender, EventArgs e)
        {
            CreateCandidate dialog = new CreateCandidate(this);
            dialog.ShowDialog();
        }
    }
}
