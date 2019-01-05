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
    public partial class StaffAssigner : Form
    {
        private int staffIndex;
        private int jobIndex;
        public StaffAssigner(int rowIndex, int clientIndex)
        {
            InitializeComponent();
            staffIndex = rowIndex;
            jobIndex = clientIndex;

            PopulateDataGridView();

        }

        private void JobViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SaveJobData()
        {
            if (txtStaffName.Text != "" &&
               txtStaffRole.Text != "")
            {
                Staff NewStaff = new Staff();
                NewStaff.StaffName = txtStaffName.Text.Trim();
                NewStaff.StaffRole = txtStaffRole.Text.Trim();
                NewStaff.JobDate = mtxtJobDate.Text.Trim();

                using (var context = new UniDBContext())
                {

                    var query = from b in context.ClientCompanys
                                orderby b.ClientID
                                select b;


                    query.ToList()[jobIndex].Jobs.ToList()[staffIndex].AssignedStaff.Add(NewStaff);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("please enter all data!"); 
            }
        }

        public void SaveClick()
        {
            SaveJobData(); 
        }


        public void PopulateDataGridView()
        {

            StaffViewGrid.AutoGenerateColumns = false;
            using (var context = new UniDBContext())
            {
                var query = from b in context.ClientCompanys
                            orderby b.ClientID
                            select b;

                StaffViewGrid.DataSource = query.ToList()[jobIndex].Jobs.ToList()[staffIndex].AssignedStaff.ToList();
            }

        }

        public void clearText()
        {

            txtStaffName.Text = "";
            txtStaffRole.Text = "";
            mtxtJobDate.Text = "";

            PopulateDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClick();
            clearText();
            MessageBox.Show("Submitted Successfully");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void txtStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = txtStaffRole;
        }

        private void txtStaffRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ActiveControl = mtxtJobDate;
        }

        private void mtxtJobDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SaveJobData();
            }
        }
    }
}
