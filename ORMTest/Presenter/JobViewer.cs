//KF7012 Task 3 Implementation
//Date: December 2018
//Names: Elliot Anderson, Adam Cook
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Presenter
{
    public partial class JobViewer : Form, IJobviewer
    {
        public int jobsIndex;
        private JobViewerPresenter jobViewerPresenterInstance;
        public JobViewer(JobViewerPresenter tjobViewerPresenter)
        {
            InitializeComponent();
            jobViewerPresenterInstance = tjobViewerPresenter;
        }

        public void jobsToView(int t_jobsIndex)
        {
            jobsIndex = t_jobsIndex;
            PopulateDataGridView();


        }

        public void PopulateDataGridView()
        {

            JobViewGrid.AutoGenerateColumns = false;
            JobViewGrid.DataSource = jobViewerPresenterInstance.GetListOfJobs();

        }

        public void clearText()
        {

            txtMachineDescription.Text = "";
            txtFaultDescription.Text = "";
            txtJobUrgency.Text = "";
            txtMachineComplexity.Text = "";
            txtHouseNumber.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtPostcode.Text = "";
            PopulateDataGridView();
        }

        private void btnSave_Click(object sender,
                                   EventArgs e)
        {
            if (txtMachineDescription.Text.Equals(String.Empty) ||
                txtFaultDescription.Text.Equals(String.Empty) ||
                txtJobUrgency.Text.Equals(String.Empty) ||
                txtMachineComplexity.Text.Equals(String.Empty) ||
                txtHouseNumber.Text.Equals(String.Empty) ||
                txtStreet.Text.Equals(String.Empty) ||
                txtTown.Text.Equals(String.Empty) ||
                txtPostcode.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                jobViewerPresenterInstance.SaveClick();
                clearText();
                MessageBox.Show("Submitted Successfully");
            }
        }

        public string GetTxtMachineDescription()
        {
            return txtMachineDescription.Text.Trim();
        }

        public string GetTxtFaultDescription()
        {
            return txtFaultDescription.Text.Trim();
        }

        public string GetTxtJobUrgency()
        {
            return txtJobUrgency.Text.Trim();
        }

        public string GetTxtMachineComplexity()
        {
            return txtMachineComplexity.Text.Trim();
        }

        public string GetTxtHouseNumber()
        {
            return txtHouseNumber.Text.Trim();
        }

        public string GetTxtStreet()
        {
            return txtStreet.Text.Trim();
        }

        public string GetTxtTown()
        {
            return txtTown.Text.Trim();
        }

        public string GetTxtPostcode()
        {
            return txtPostcode.Text.Trim();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(JobViewGrid.Columns["AssignStaff"].Index))
            {
                Console.WriteLine(String.Format("Row{0}, Col {1}", e.RowIndex, e.ColumnIndex));
                StaffAssigner staffAssigner = new StaffAssigner(e.RowIndex, jobsIndex);
                staffAssigner.Show();


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText(); 
        }

        private void txtJobUrgency_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJobUrgency.Text, "[^0-5]"))
            {
                MessageBox.Show("Please enter a value between 0 to 5");
                txtJobUrgency.Text = String.Empty;
            }
        }

        private void txtMachineComplexity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMachineComplexity.Text, "[^0-5]"))
            {
                MessageBox.Show("Please enter a value between 0 to 5");
                txtMachineComplexity.Text = String.Empty;
            }
        }
    }
}
