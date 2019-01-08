namespace Presenter
{
    partial class StaffAssigner
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.StaffViewGrid = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignStaffTitle = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffRole = new System.Windows.Forms.TextBox();
            this.mtxtJobDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 457);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(131, 457);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 457);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StaffViewGrid
            // 
            this.StaffViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.StaffViewGrid.Location = new System.Drawing.Point(597, 39);
            this.StaffViewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.StaffViewGrid.Name = "StaffViewGrid";
            this.StaffViewGrid.ReadOnly = true;
            this.StaffViewGrid.RowTemplate.Height = 24;
            this.StaffViewGrid.Size = new System.Drawing.Size(879, 446);
            this.StaffViewGrid.TabIndex = 7;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StaffName";
            this.dataGridViewTextBoxColumn4.HeaderText = "StaffName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StaffRole";
            this.dataGridViewTextBoxColumn5.HeaderText = "StaffRole";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JobDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "JobDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // AssignStaffTitle
            // 
            this.AssignStaffTitle.AutoSize = true;
            this.AssignStaffTitle.Location = new System.Drawing.Point(39, 44);
            this.AssignStaffTitle.Name = "AssignStaffTitle";
            this.AssignStaffTitle.Size = new System.Drawing.Size(83, 17);
            this.AssignStaffTitle.TabIndex = 72;
            this.AssignStaffTitle.Text = "Assign Staff";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(39, 94);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(78, 17);
            this.lblStaffName.TabIndex = 73;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Location = new System.Drawing.Point(39, 130);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(70, 17);
            this.lblStaffRole.TabIndex = 74;
            this.lblStaffRole.Text = "Staff Role";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Location = new System.Drawing.Point(39, 165);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(65, 17);
            this.lblJobDate.TabIndex = 75;
            this.lblJobDate.Text = "Job Date";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(131, 94);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(409, 22);
            this.txtStaffName.TabIndex = 1;
            // 
            // txtStaffRole
            // 
            this.txtStaffRole.Location = new System.Drawing.Point(131, 128);
            this.txtStaffRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffRole.Name = "txtStaffRole";
            this.txtStaffRole.Size = new System.Drawing.Size(409, 22);
            this.txtStaffRole.TabIndex = 2;
            // 
            // mtxtJobDate
            // 
            this.mtxtJobDate.Location = new System.Drawing.Point(131, 165);
            this.mtxtJobDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtJobDate.Mask = "00/00/0000";
            this.mtxtJobDate.Name = "mtxtJobDate";
            this.mtxtJobDate.Size = new System.Drawing.Size(409, 22);
            this.mtxtJobDate.TabIndex = 3;
            this.mtxtJobDate.ValidatingType = typeof(System.DateTime);
            this.mtxtJobDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtJobDate_KeyPress);
            // 
            // StaffAssigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 567);
            this.Controls.Add(this.mtxtJobDate);
            this.Controls.Add(this.txtStaffRole);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblStaffRole);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.AssignStaffTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.StaffViewGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StaffAssigner";
            this.Text = "StaffAssigner";
            ((System.ComponentModel.ISupportInitialize)(this.StaffViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView StaffViewGrid;
        private System.Windows.Forms.Label AssignStaffTitle;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MaskedTextBox mtxtJobDate;
    }
}