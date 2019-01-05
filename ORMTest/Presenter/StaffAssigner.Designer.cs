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
            this.txtJobDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
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
            this.StaffViewGrid.Location = new System.Drawing.Point(448, 32);
            this.StaffViewGrid.Name = "StaffViewGrid";
            this.StaffViewGrid.ReadOnly = true;
            this.StaffViewGrid.RowTemplate.Height = 24;
            this.StaffViewGrid.Size = new System.Drawing.Size(659, 362);
            this.StaffViewGrid.TabIndex = 7;
            this.StaffViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobViewGrid_CellClick);
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
            this.AssignStaffTitle.Location = new System.Drawing.Point(29, 36);
            this.AssignStaffTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignStaffTitle.Name = "AssignStaffTitle";
            this.AssignStaffTitle.Size = new System.Drawing.Size(63, 13);
            this.AssignStaffTitle.TabIndex = 72;
            this.AssignStaffTitle.Text = "Assign Staff";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(29, 76);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 73;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Location = new System.Drawing.Point(29, 106);
            this.lblStaffRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(54, 13);
            this.lblStaffRole.TabIndex = 74;
            this.lblStaffRole.Text = "Staff Role";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Location = new System.Drawing.Point(29, 134);
            this.lblJobDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(50, 13);
            this.lblJobDate.TabIndex = 75;
            this.lblJobDate.Text = "Job Date";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(98, 76);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(308, 20);
            this.txtStaffName.TabIndex = 1;
            // 
            // txtStaffRole
            // 
            this.txtStaffRole.Location = new System.Drawing.Point(98, 104);
            this.txtStaffRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffRole.Name = "txtStaffRole";
            this.txtStaffRole.Size = new System.Drawing.Size(308, 20);
            this.txtStaffRole.TabIndex = 2;
            // 
            // txtJobDate
            // 
            this.txtJobDate.Location = new System.Drawing.Point(98, 134);
            this.txtJobDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobDate.Name = "txtJobDate";
            this.txtJobDate.Size = new System.Drawing.Size(308, 20);
            this.txtJobDate.TabIndex = 3;
            // 
            // StaffAssigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 461);
            this.Controls.Add(this.txtJobDate);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtJobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}