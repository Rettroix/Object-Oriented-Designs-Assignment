//KF7012 Task 3 Implementation
//Date: December 2018
//Names: Elliot Anderson, Adam Cook
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.Mail;
using Model;
namespace Presenter
{
    public partial class Program : Form
    {
        private Label lblName;
        private TextBox txtName;
        private Button btnSave;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnDelete;
        private Button btnCancel;
        private Label lblClientCompany;
        private DataGridView FactoryGrid;
        private DataGridViewTextBoxColumn FactoryID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn AvailableJobs;
        private CheckBox cbTerms;
        private Label lblTerms;
        private DataGridView ClientGrid;
    
        public Program()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void testDatabase()
        {
            ClientCompany CodeStompIndustries = new ClientCompany();
            CodeStompIndustries.ClientName = "Codestomp Industries";
            CodeStompIndustries.Email = "CodestompIndustries@gmail.com";

            Job CodeStompJob = new Job();
            CodeStompJob.MachineDescription = "Rubbish computer";
            CodeStompJob.FaultDescription = "It's broken";
            CodeStompJob.JobUrgency = 5;
            CodeStompJob.MachineComplexity = 5;

            Address CodeStompFactoryLocation = new Address();
            CodeStompFactoryLocation.HouseNumber = "54";
            CodeStompFactoryLocation.Street = "Stupid Street";
            CodeStompFactoryLocation.Town = "Newcastle";
            CodeStompFactoryLocation.PostCode = "NE11 8FM";

            CodeStompJob.FactoryLocation.Add(CodeStompFactoryLocation);
            CodeStompIndustries.Jobs.Add(CodeStompJob);

            using (var context = new UniDBContext())
            {

                //Remove everything
                //var delquery = from b in context.ClientCompanys
                //            orderby b.Name
                //            select b;

                //foreach (var item in delquery)
                //{
                //    context.ClientCompanys.Remove(item);
                //    context.SaveChanges();
                //}
                context.Database.ExecuteSqlCommand("DELETE FROM [Addresses]");
                context.Database.ExecuteSqlCommand("DELETE FROM [Jobs]");
                context.Database.ExecuteSqlCommand("DELETE FROM [ClientCompanies]");
                context.ClientCompanys.Add(CodeStompIndustries);
                context.SaveChanges();

                var query = from b in context.ClientCompanys
                            orderby b.ClientName
                            select b;

                Console.WriteLine("All Jobs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.ClientName);
                    Console.WriteLine(item.Email);
                    var queryTwo = from b in item.Jobs
                                   orderby b.JobID
                                   select b;
                    foreach (var itemTwo in queryTwo)
                    {
                        Console.WriteLine(itemTwo.MachineDescription);
                        Console.WriteLine(itemTwo.FaultDescription);
                        Console.WriteLine(itemTwo.FactoryLocation);
                        Console.WriteLine(itemTwo.JobUrgency);
                        Console.WriteLine(itemTwo.MachineComplexity);



                    }
                }
            }


            Console.WriteLine("Demo completed.");
            //Console.ReadLine();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ClientGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableJobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClientCompany = new System.Windows.Forms.Label();
            this.FactoryGrid = new System.Windows.Forms.DataGridView();
            this.FactoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTerms = new System.Windows.Forms.CheckBox();
            this.lblTerms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 105);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(76, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ClientGrid
            // 
            this.ClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClientName,
            this.Email,
            this.AvailableJobs});
            this.ClientGrid.Location = new System.Drawing.Point(483, 12);
            this.ClientGrid.Name = "ClientGrid";
            this.ClientGrid.ReadOnly = true;
            this.ClientGrid.RowTemplate.Height = 24;
            this.ClientGrid.Size = new System.Drawing.Size(625, 113);
            this.ClientGrid.TabIndex = 6;
            this.ClientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ClientID";
            this.ID.HeaderText = "ClientID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // AvailableJobs
            // 
            this.AvailableJobs.DataPropertyName = "AvailableJobs";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = "CLICK";
            this.AvailableJobs.DefaultCellStyle = dataGridViewCellStyle3;
            this.AvailableJobs.HeaderText = "AvailableJobs";
            this.AvailableJobs.Name = "AvailableJobs";
            this.AvailableJobs.ReadOnly = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(73, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(174, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblClientCompany
            // 
            this.lblClientCompany.AutoSize = true;
            this.lblClientCompany.Location = new System.Drawing.Point(74, 79);
            this.lblClientCompany.Name = "lblClientCompany";
            this.lblClientCompany.Size = new System.Drawing.Size(106, 17);
            this.lblClientCompany.TabIndex = 12;
            this.lblClientCompany.Text = "Client Company";
            // 
            // FactoryGrid
            // 
            this.FactoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FactoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FactoryID,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.FactoryGrid.Location = new System.Drawing.Point(483, 153);
            this.FactoryGrid.Name = "FactoryGrid";
            this.FactoryGrid.ReadOnly = true;
            this.FactoryGrid.RowTemplate.Height = 24;
            this.FactoryGrid.Size = new System.Drawing.Size(625, 167);
            this.FactoryGrid.TabIndex = 28;
            // 
            // FactoryID
            // 
            this.FactoryID.DataPropertyName = "FactoryID";
            this.FactoryID.HeaderText = "FactoryID";
            this.FactoryID.Name = "FactoryID";
            this.FactoryID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "HouseNumber";
            this.dataGridViewTextBoxColumn19.HeaderText = "HouseNumber";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn20.HeaderText = "Street";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Town";
            this.dataGridViewTextBoxColumn21.HeaderText = "Town";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Postcode";
            this.dataGridViewTextBoxColumn22.HeaderText = "Postcode";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // cbTerms
            // 
            this.cbTerms.AutoSize = true;
            this.cbTerms.Location = new System.Drawing.Point(278, 265);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(74, 21);
            this.cbTerms.TabIndex = 29;
            this.cbTerms.Text = "I agree";
            this.cbTerms.UseVisualStyleBackColor = true;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Location = new System.Drawing.Point(278, 246);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(144, 17);
            this.lblTerms.TabIndex = 30;
            this.lblTerms.Text = "Terms and conditions";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(1120, 352);
            this.Controls.Add(this.lblTerms);
            this.Controls.Add(this.cbTerms);
            this.Controls.Add(this.FactoryGrid);
            this.Controls.Add(this.lblClientCompany);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.ClientGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Program";
            this.Text = "Insert Update Delete";
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btnClear_Click(object sender,
                                   EventArgs e)
        {
            clearText();
        }

        public bool emailIsValid(string email)
        {

            try
            {
                MailAddress a = new MailAddress(email);
                return true;
            }
            catch
            {
                return false; 
            }

        }

        private void saveCompanyData()
        {

            if (txtName.Text != "" &&
                           txtEmail.Text != "")
            {
                if (emailIsValid(txtEmail.Text))
                {
                    if (cbTerms.Checked)
                    {
                        ClientCompany CodeStompIndustries = new ClientCompany();
                        CodeStompIndustries.ClientName = txtName.Text.Trim();
                        CodeStompIndustries.Email = txtEmail.Text.Trim();


                        using (var context = new UniDBContext())
                        {
                            context.ClientCompanys.Add(CodeStompIndustries);
                            context.SaveChanges();
                        }
                        clearText();
                        MessageBox.Show("Submitted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("you must agree to the terms and conditions to continue"); 
                    }
                }
                else
                {
                    MessageBox.Show("please enter a valid email");
                }
            }
            else
            {

                MessageBox.Show("please complete all fields");

            }

        }

        private void btnSave_Click(object sender,
                                   EventArgs e)
        {
            saveCompanyData();
        }



        private void clearText()
        { 
            txtName.Text = "";
            txtEmail.Text = ""; 

            PopulateDataGridView();
        }


        void PopulateDataGridView()
        {
            ClientGrid.AutoGenerateColumns = false;
            using (var context = new UniDBContext())
            {
                ClientGrid.DataSource = context.ClientCompanys.ToList<ClientCompany>();
                FactoryGrid.DataSource = context.Addresses.ToList<Address>();

            }
        }

        private void ClientGrid_CellClick(object sender,
                                             DataGridViewCellEventArgs e)
        {
            //if(dataGridView1.Columns["AvailableJobs"].Selected)
            //{
            //    Console.WriteLine("clicked available jobs");
            //}


            if(e.ColumnIndex.Equals(ClientGrid.Columns["AvailableJobs"].
                                    Index))
            {
                Console.WriteLine(String.Format("Row{0}, Col {1}",
                                                e.RowIndex,
                                                e.ColumnIndex));                 
                
                JobViewerPresenter jobViewPresenter = new JobViewerPresenter(e.RowIndex);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = txtEmail;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                saveCompanyData();
            }
        }
    }
}

