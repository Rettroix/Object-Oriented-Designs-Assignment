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

                MessageBox.Show("Submitted Successfully");
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
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
