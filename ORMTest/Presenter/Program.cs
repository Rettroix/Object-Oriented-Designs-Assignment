using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Model;
namespace Presenter
{
    public partial class Program : Form
    {
        private Label label1;
        private TextBox txtName;
        private Button btnSave;
        private TextBox txtEmail;
        private Label label2;
        private Button button2;
        private Button btnCancel;
        private Label label5;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn FactoryID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn AvailableJobs;
        private DataGridView dataGridView1;
    
        public Program()
        {
            //testDatabase();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                    new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = 
                    new System.Windows.Forms.Label();
            this.txtName = 
                    new System.Windows.Forms.TextBox();
            this.btnSave = 
                    new System.Windows.Forms.Button();
            this.dataGridView1 = 
                    new System.Windows.Forms.DataGridView();
            this.txtEmail = 
                    new System.Windows.Forms.TextBox();
            this.label2 = 
                    new System.Windows.Forms.Label();
            this.button2 = 
                    new System.Windows.Forms.Button();
            this.btnCancel = 
                    new System.Windows.Forms.Button();
            this.label5 = 
                    new System.Windows.Forms.Label();
            this.dataGridView3 = 
                    new System.Windows.Forms.DataGridView();
            this.FactoryID = 
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 =
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 =
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 =
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = 
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName =
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = 
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableJobs = 
                    new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)
                        (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                        (this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = 
                    new System.Drawing.Point(73, 105);
            this.label1.Name = "label1";
            this.label1.Size = 
                    new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += 
                    new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = 
                    new System.Drawing.Point(125, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = 
                    new System.Drawing.Size(228, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += 
                    new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = 
                    new System.Drawing.Point(76, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = 
                    new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += 
                    new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = 
                    System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] 
            {
                this.ID,
                this.ClientName,
                this.Email,
                this.AvailableJobs
            });

            this.dataGridView1.Location = 
                    new System.Drawing.Point(483, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = 
                    new System.Drawing.Size(625, 113);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += 
                    new System.Windows.Forms.DataGridViewCellEventHandler
                                            (this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += 
                    new System.Windows.Forms.DataGridViewCellEventHandler
                                            (this.dataGridView1_CellContentClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location =
                    new System.Drawing.Point(125, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size =
                    new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += 
                    new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = 
                    new System.Drawing.Point(73, 133);
            this.label2.Name = "label2";
            this.label2.Size = 
                    new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // button2
            // 
            this.button2.Location = 
                    new System.Drawing.Point(174, 186);
            this.button2.Name = "button2";
            this.button2.Size = 
                    new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = 
                    new System.Drawing.Point(278, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = 
                    new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += 
                    new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = 
                    new System.Drawing.Point(74, 79);
            this.label5.Name = "label5";
            this.label5.Size = 
                    new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Client Company";
            this.label5.Click += 
                    new System.EventHandler(this.label5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = 
                    System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.
                                         AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.
                                                    DataGridViewColumn[] 
            {
                this.FactoryID,
                this.dataGridViewTextBoxColumn19,
                this.dataGridViewTextBoxColumn20,
                this.dataGridViewTextBoxColumn21,
                this.dataGridViewTextBoxColumn22
            });
            this.dataGridView3.Location = 
                    new System.Drawing.Point(483, 153);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size =
                    new System.Drawing.Size(625, 167);
            this.dataGridView3.TabIndex = 28;
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
            this.dataGridViewTextBoxColumn19.DataPropertyName = 
                                                        "HouseNumber";
            this.dataGridViewTextBoxColumn19.HeaderText = 
                                                        "HouseNumber";
            this.dataGridViewTextBoxColumn19.Name = 
                                        "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn20.HeaderText = "Street";
            this.dataGridViewTextBoxColumn20.Name =
                                        "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Town";
            this.dataGridViewTextBoxColumn21.HeaderText = "Town";
            this.dataGridViewTextBoxColumn21.Name = 
                                        "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Postcode";
            this.dataGridViewTextBoxColumn22.HeaderText = "Postcode";
            this.dataGridViewTextBoxColumn22.Name =
                                        "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
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
            dataGridViewCellStyle1.BackColor = 
                            System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = 
                        new System.Drawing.Font("Microsoft Sans Serif",
                                           8.25F,
                                           System.Drawing.FontStyle.Bold,
                                           System.Drawing.GraphicsUnit.Point,
                                           ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "CLICK";
            this.AvailableJobs.DefaultCellStyle = dataGridViewCellStyle1;
            this.AvailableJobs.HeaderText = "AvailableJobs";
            this.AvailableJobs.Name = "AvailableJobs";
            this.AvailableJobs.ReadOnly = true;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(1120, 352);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Program";
            this.Text = "Insert Update Delete";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)
             (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
             (this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender,
                                  EventArgs e)
        {

        }

        private void button3_Click(object sender,
                                   EventArgs e)
        {
            clearText();
        }

        private void textBox3_TextChanged(object sender,
                                          EventArgs e)
        {

        }

        private void Program_Load(object sender,
                                  EventArgs e)
        {

        }

        private void button1_Click(object sender,
                                   EventArgs e)
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

        private void label5_Click(object sender,
                                  EventArgs e)
        {

        }

        private void label3_Click(object sender,
                                  EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender,
                                          EventArgs e)
        {

        }

        private void label4_Click(object sender,
                                  EventArgs e)
        {

        }

        private void label6_Click(object sender,
                                  EventArgs e)
        {

        }

        private void label8_Click(object sender,
                                  EventArgs e)
        {

        }

        private void clearText()
        { 
            txtName.Text = "";
            txtEmail.Text = ""; 

            PopulateDataGridView();
        }

        private void textBox2_TextChanged(object sender,
                                          EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender,
                                         EventArgs e)
        {

        }

        private void txtJobUrgency_TextChanged(object sender,
                                               EventArgs e)
        {

        }

        private void txtMachineComplexity_TextChanged(object sender,
                                                      EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender,
                                           EventArgs e)
        {

        }

        private void txtTown_TextChanged(object sender,
                                         EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender,
                                                    DataGridViewCellEventArgs e)
        {

        }

        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (var context = new UniDBContext())
            {
                dataGridView1.DataSource = context.ClientCompanys.ToList<ClientCompany>();
                dataGridView3.DataSource = context.Addresses.ToList<Address>();

            }
        }

        private void dataGridView1_CellClick(object sender,
                                             DataGridViewCellEventArgs e)
        {
            //if(dataGridView1.Columns["AvailableJobs"].Selected)
            //{
            //    Console.WriteLine("clicked available jobs");
            //}


            if(e.ColumnIndex.Equals(dataGridView1.Columns["AvailableJobs"].
                                    Index))
            {
                Console.WriteLine(String.Format("Row{0}, Col {1}",
                                                e.RowIndex,
                                                e.ColumnIndex));
                using (var context = new UniDBContext())
                {
                    var query = from b in context.ClientCompanys
                                orderby b.ClientID
                                select b;

                    Console.WriteLine("All Jobs in the database:");
                    Console.WriteLine(query.ToList()[e.RowIndex].Jobs.ToList()
                                        [0].MachineDescription);
                    JobViewer jobView = new JobViewer();
                    jobView.jobsToView(e.RowIndex);
                    jobView.Show();

                }
                Console.WriteLine(String.Format("Row{0}, Col {1}",
                                                e.RowIndex,
                                                e.ColumnIndex));
            }
        }

        private void dataGridView2_CellContentClick(object sender,
                                                    DataGridViewCellEventArgs e)
        {

        }
    }
}

