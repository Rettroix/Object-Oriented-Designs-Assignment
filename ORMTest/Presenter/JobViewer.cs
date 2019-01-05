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

        private void dataGridView2_CellContentClick(object sender,
                                                    DataGridViewCellEventArgs e)
        {

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
            jobViewerPresenterInstance.SaveClick();
            clearText();
            MessageBox.Show("Submitted Successfully");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText(); 
        }

        private void txtMachineDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtFaultDescription;
        }

        private void txtFaultDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtJobUrgency;
        }

        private void txtMachineComplexity_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtHouseNumber;
        }
        private void txtJobUrgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtMachineComplexity;
        }

        private void txtHouseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtStreet;
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtTown;
        }

        private void txtTown_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtPostcode;
        }

        private void txtPostcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            jobViewerPresenterInstance.SaveClick();
            clearText();
            MessageBox.Show("Submitted Successfully");
        }
    }
}
