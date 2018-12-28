﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ORMTest
{
    public partial class Program : Form
    {
        private Label label1;
        private TextBox txtName;
        private Button Save;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtMachineDescription;
        private Label label3;
        private Button button2;
        private Button btnCancel;
        private TextBox txtFaultDescription;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtJobUrgency;
        private TextBox txtMachineComplexity;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtHouseNumber;
        private TextBox txtStreet;
        private TextBox txtTown;
        private TextBox txtPostcode;
        private DataGridView dataGridView1;
    
        public Program()
        {
            testDatabase();
            InitializeComponent();
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
            CodeStompIndustries.Name = "Codestomp Industries";
            CodeStompIndustries.Email = "CodestompIndustries@gmail.com";

            Job CodeStompJob = new Job();
            CodeStompJob.MachineDescription = "Rubbish computer";
            CodeStompJob.FaultDescription = "It's broken";
            CodeStompJob.JobUrgency = 5;
            CodeStompJob.MachineComplexity = 5;

            Address CodeStompFactoryLocation = new Address();
            CodeStompFactoryLocation.NumberOrName = "54";
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
                            orderby b.Name
                            select b;

                Console.WriteLine("All Jobs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Email);
                    var queryTwo = from b in item.Jobs
                                   orderby b.PrimaryKey
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMachineDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFaultDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJobUrgency = new System.Windows.Forms.TextBox();
            this.txtMachineComplexity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(56, 437);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 448);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // txtMachineDescription
            // 
            this.txtMachineDescription.Location = new System.Drawing.Point(186, 126);
            this.txtMachineDescription.Name = "txtMachineDescription";
            this.txtMachineDescription.Size = new System.Drawing.Size(228, 22);
            this.txtMachineDescription.TabIndex = 7;
            this.txtMachineDescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jobs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtFaultDescription
            // 
            this.txtFaultDescription.Location = new System.Drawing.Point(186, 153);
            this.txtFaultDescription.Name = "txtFaultDescription";
            this.txtFaultDescription.Size = new System.Drawing.Size(228, 22);
            this.txtFaultDescription.TabIndex = 11;
            this.txtFaultDescription.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Machine Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Client Company";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fault Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Job Urgency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Machine Complexity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtJobUrgency
            // 
            this.txtJobUrgency.Location = new System.Drawing.Point(186, 185);
            this.txtJobUrgency.Name = "txtJobUrgency";
            this.txtJobUrgency.Size = new System.Drawing.Size(228, 22);
            this.txtJobUrgency.TabIndex = 16;
            // 
            // txtMachineComplexity
            // 
            this.txtMachineComplexity.Location = new System.Drawing.Point(186, 216);
            this.txtMachineComplexity.Name = "txtMachineComplexity";
            this.txtMachineComplexity.Size = new System.Drawing.Size(228, 22);
            this.txtMachineComplexity.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Factory Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "House Number or Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Street";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Town";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Postcode";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(210, 295);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(228, 22);
            this.txtHouseNumber.TabIndex = 23;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(210, 323);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(228, 22);
            this.txtStreet.TabIndex = 24;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(210, 351);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(228, 22);
            this.txtTown.TabIndex = 25;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(210, 379);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(228, 22);
            this.txtPostcode.TabIndex = 26;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(990, 472);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMachineComplexity);
            this.Controls.Add(this.txtJobUrgency);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFaultDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMachineDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Program";
            this.Text = "Insert Update Delete";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void clearText()
        { 
            txtName.Text = "";
            txtEmail.Text = ""; 
            txtMachineDescription.Text = "";
            txtFaultDescription.Text = "";
            txtJobUrgency.Text = ""; 
            txtMachineComplexity.Text = "";
            txtHouseNumber.Text = ""; 
            txtStreet.Text = "";
            txtTown.Text = "";
            txtPostcode.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
