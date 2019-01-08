namespace Presenter
{
    partial class JobViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.JobViewGrid = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtMachineComplexity = new System.Windows.Forms.TextBox();
            this.txtJobUrgency = new System.Windows.Forms.TextBox();
            this.lblComplex = new System.Windows.Forms.Label();
            this.lblUrgancy = new System.Windows.Forms.Label();
            this.lblFault = new System.Windows.Forms.Label();
            this.txtFaultDescription = new System.Windows.Forms.TextBox();
            this.lblMachineDescription = new System.Windows.Forms.Label();
            this.txtMachineDescription = new System.Windows.Forms.TextBox();
            this.lblJobs = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JobViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // JobViewGrid
            // 
            this.JobViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.AssignStaff});
            this.JobViewGrid.Location = new System.Drawing.Point(597, 25);
            this.JobViewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.JobViewGrid.Name = "JobViewGrid";
            this.JobViewGrid.ReadOnly = true;
            this.JobViewGrid.RowTemplate.Height = 24;
            this.JobViewGrid.Size = new System.Drawing.Size(879, 446);
            this.JobViewGrid.TabIndex = 12;
            this.JobViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // JobID
            // 
            this.JobID.DataPropertyName = "JobID";
            this.JobID.HeaderText = "JobID";
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MachineDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "MachineDescription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FaultDescription";
            this.dataGridViewTextBoxColumn5.HeaderText = "FaultDescription";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JobUrgency";
            this.dataGridViewTextBoxColumn6.HeaderText = "JobUrgency";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MachineComplexity";
            this.dataGridViewTextBoxColumn7.HeaderText = "MachineComplexity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // AssignStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Assign";
            this.AssignStaff.DefaultCellStyle = dataGridViewCellStyle1;
            this.AssignStaff.HeaderText = "AssignStaff";
            this.AssignStaff.Name = "AssignStaff";
            this.AssignStaff.ReadOnly = true;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(237, 368);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(303, 22);
            this.txtPostcode.TabIndex = 8;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(237, 334);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(303, 22);
            this.txtTown.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(237, 299);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(303, 22);
            this.txtStreet.TabIndex = 6;
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(237, 265);
            this.txtHouseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(303, 22);
            this.txtHouseNumber.TabIndex = 5;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(16, 368);
            this.lblPostCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(67, 17);
            this.lblPostCode.TabIndex = 42;
            this.lblPostCode.Text = "Postcode";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(15, 334);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(42, 17);
            this.lblTown.TabIndex = 41;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(16, 298);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 40;
            this.lblStreet.Text = "Street";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Location = new System.Drawing.Point(15, 265);
            this.lblHouseNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(161, 17);
            this.lblHouseNo.TabIndex = 39;
            this.lblHouseNo.Text = "House Number or Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(16, 228);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(113, 17);
            this.lblLocation.TabIndex = 38;
            this.lblLocation.Text = "Factory Location";
            // 
            // txtMachineComplexity
            // 
            this.txtMachineComplexity.Location = new System.Drawing.Point(216, 170);
            this.txtMachineComplexity.Margin = new System.Windows.Forms.Padding(4);
            this.txtMachineComplexity.MaxLength = 1;
            this.txtMachineComplexity.Name = "txtMachineComplexity";
            this.txtMachineComplexity.Size = new System.Drawing.Size(303, 22);
            this.txtMachineComplexity.TabIndex = 4;
            this.txtMachineComplexity.TextChanged += new System.EventHandler(this.txtMachineComplexity_TextChanged);
            // 
            // txtJobUrgency
            // 
            this.txtJobUrgency.Location = new System.Drawing.Point(216, 132);
            this.txtJobUrgency.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobUrgency.MaxLength = 1;
            this.txtJobUrgency.Name = "txtJobUrgency";
            this.txtJobUrgency.Size = new System.Drawing.Size(303, 22);
            this.txtJobUrgency.TabIndex = 3;
            this.txtJobUrgency.TextChanged += new System.EventHandler(this.txtJobUrgency_TextChanged);
            // 
            // lblComplex
            // 
            this.lblComplex.AutoSize = true;
            this.lblComplex.Location = new System.Drawing.Point(19, 170);
            this.lblComplex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplex.Name = "lblComplex";
            this.lblComplex.Size = new System.Drawing.Size(167, 17);
            this.lblComplex.TabIndex = 35;
            this.lblComplex.Text = "Machine Complexity (0-5)";
            // 
            // lblUrgancy
            // 
            this.lblUrgancy.AutoSize = true;
            this.lblUrgancy.Location = new System.Drawing.Point(19, 132);
            this.lblUrgancy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrgancy.Name = "lblUrgancy";
            this.lblUrgancy.Size = new System.Drawing.Size(123, 17);
            this.lblUrgancy.TabIndex = 34;
            this.lblUrgancy.Text = "Job Urgency (0-5)";
            // 
            // lblFault
            // 
            this.lblFault.AutoSize = true;
            this.lblFault.Location = new System.Drawing.Point(20, 92);
            this.lblFault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFault.Name = "lblFault";
            this.lblFault.Size = new System.Drawing.Size(114, 17);
            this.lblFault.TabIndex = 33;
            this.lblFault.Text = "Fault Description";
            // 
            // txtFaultDescription
            // 
            this.txtFaultDescription.Location = new System.Drawing.Point(216, 92);
            this.txtFaultDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaultDescription.Name = "txtFaultDescription";
            this.txtFaultDescription.Size = new System.Drawing.Size(303, 22);
            this.txtFaultDescription.TabIndex = 2;
            // 
            // lblMachineDescription
            // 
            this.lblMachineDescription.AutoSize = true;
            this.lblMachineDescription.Location = new System.Drawing.Point(19, 59);
            this.lblMachineDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachineDescription.Name = "lblMachineDescription";
            this.lblMachineDescription.Size = new System.Drawing.Size(136, 17);
            this.lblMachineDescription.TabIndex = 31;
            this.lblMachineDescription.Text = "Machine Description";
            // 
            // txtMachineDescription
            // 
            this.txtMachineDescription.Location = new System.Drawing.Point(216, 59);
            this.txtMachineDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtMachineDescription.Name = "txtMachineDescription";
            this.txtMachineDescription.Size = new System.Drawing.Size(303, 22);
            this.txtMachineDescription.TabIndex = 1;
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Location = new System.Drawing.Point(19, 25);
            this.lblJobs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(38, 17);
            this.lblJobs.TabIndex = 29;
            this.lblJobs.Text = "Jobs";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 442);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(129, 442);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 442);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // JobViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 513);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtMachineComplexity);
            this.Controls.Add(this.txtJobUrgency);
            this.Controls.Add(this.lblComplex);
            this.Controls.Add(this.lblUrgancy);
            this.Controls.Add(this.lblFault);
            this.Controls.Add(this.txtFaultDescription);
            this.Controls.Add(this.lblMachineDescription);
            this.Controls.Add(this.txtMachineDescription);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.JobViewGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "JobViewer";
            this.Text = "JobViewer";
            ((System.ComponentModel.ISupportInitialize)(this.JobViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JobViewGrid;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtMachineComplexity;
        private System.Windows.Forms.TextBox txtJobUrgency;
        private System.Windows.Forms.Label lblComplex;
        private System.Windows.Forms.Label lblUrgancy;
        private System.Windows.Forms.Label lblFault;
        private System.Windows.Forms.TextBox txtFaultDescription;
        private System.Windows.Forms.Label lblMachineDescription;
        private System.Windows.Forms.TextBox txtMachineDescription;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignStaff;

    }
}