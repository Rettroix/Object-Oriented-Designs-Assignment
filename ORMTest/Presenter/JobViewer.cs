using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace Presenter
{
    public partial class JobViewer : Form
    {
        public int jobsIndex;
        public JobViewer()
        {
            InitializeComponent();
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

        void PopulateDataGridView()
        {
            using (var context = new UniDBContext())
            {
                var query = from b in context.ClientCompanys
                            orderby b.ClientID
                            select b;

                JobViewGrid.AutoGenerateColumns = false;

                JobViewGrid.DataSource = query.ToList()[jobsIndex].Jobs.ToList();

            }
        }

        private void txtMachineDescription_TextChanged(object sender,
                                                       EventArgs e)
        {

        }

        private void clearText()
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
            Job CodeStompJob = new Job();
            CodeStompJob.MachineDescription = txtMachineDescription.Text.Trim();
            CodeStompJob.FaultDescription = txtFaultDescription.Text.Trim();
            CodeStompJob.JobUrgency = Convert.ToInt32(txtJobUrgency.Text.Trim());
            CodeStompJob.MachineComplexity = Convert.ToInt32(txtMachineComplexity.Text.Trim());

            Address CodeStompFactoryLocation = new Address();
            CodeStompFactoryLocation.HouseNumber = txtHouseNumber.Text.Trim();
            CodeStompFactoryLocation.Street = txtStreet.Text.Trim();
            CodeStompFactoryLocation.Town = txtTown.Text.Trim();
            CodeStompFactoryLocation.PostCode = txtPostcode.Text.Trim();

            CodeStompJob.FactoryLocation.Add(CodeStompFactoryLocation);

            using (var context = new UniDBContext())
            {

                var query = from b in context.ClientCompanys
                            orderby b.ClientID
                            select b;


                CodeStompJob.FactoryLocation.Add(CodeStompFactoryLocation);
                query.ToList()[jobsIndex].Jobs.Add(CodeStompJob);
                context.SaveChanges();
            }
            clearText();
            MessageBox.Show("Submitted Successfully");
        }


    }
}
