namespace HomeCenterL.Presentation
{
    partial class frmReports1
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
            this.btnPurchasesPerSupplier = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnSalesPerBranch = new System.Windows.Forms.Button();
            this.btnSalesByCategory = new System.Windows.Forms.Button();
            this.btnTop5Employees = new System.Windows.Forms.Button();
            this.btnSalesBeetweenDates = new System.Windows.Forms.Button();
            this.btnSalesByCustomer = new System.Windows.Forms.Button();
            this.btnSalesByEmployee = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerSalesE1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSalesE2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPurchasesPerSupplier
            // 
            this.btnPurchasesPerSupplier.BackColor = System.Drawing.Color.Maroon;
            this.btnPurchasesPerSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPurchasesPerSupplier.FlatAppearance.BorderSize = 0;
            this.btnPurchasesPerSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasesPerSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasesPerSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurchasesPerSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchasesPerSupplier.Location = new System.Drawing.Point(45, 40);
            this.btnPurchasesPerSupplier.Name = "btnPurchasesPerSupplier";
            this.btnPurchasesPerSupplier.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPurchasesPerSupplier.Size = new System.Drawing.Size(339, 34);
            this.btnPurchasesPerSupplier.TabIndex = 84;
            this.btnPurchasesPerSupplier.Text = "Total Purchases by Supplier";
            this.btnPurchasesPerSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchasesPerSupplier.UseVisualStyleBackColor = false;
            this.btnPurchasesPerSupplier.Click += new System.EventHandler(this.btnSaveReports1_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AllowUserToOrderColumns = true;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(433, 176);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(409, 364);
            this.dgvReports.TabIndex = 94;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // btnSalesPerBranch
            // 
            this.btnSalesPerBranch.BackColor = System.Drawing.Color.Maroon;
            this.btnSalesPerBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesPerBranch.FlatAppearance.BorderSize = 0;
            this.btnSalesPerBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesPerBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesPerBranch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesPerBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesPerBranch.Location = new System.Drawing.Point(45, 80);
            this.btnSalesPerBranch.Name = "btnSalesPerBranch";
            this.btnSalesPerBranch.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalesPerBranch.Size = new System.Drawing.Size(339, 34);
            this.btnSalesPerBranch.TabIndex = 95;
            this.btnSalesPerBranch.Text = "Total Sales by Branch";
            this.btnSalesPerBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesPerBranch.UseVisualStyleBackColor = false;
            this.btnSalesPerBranch.Click += new System.EventHandler(this.btnSalesPerBranch_Click_1);
            // 
            // btnSalesByCategory
            // 
            this.btnSalesByCategory.BackColor = System.Drawing.Color.Maroon;
            this.btnSalesByCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesByCategory.FlatAppearance.BorderSize = 0;
            this.btnSalesByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesByCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesByCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesByCategory.Location = new System.Drawing.Point(45, 120);
            this.btnSalesByCategory.Name = "btnSalesByCategory";
            this.btnSalesByCategory.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalesByCategory.Size = new System.Drawing.Size(339, 34);
            this.btnSalesByCategory.TabIndex = 96;
            this.btnSalesByCategory.Text = "Total Sales by Category";
            this.btnSalesByCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesByCategory.UseVisualStyleBackColor = false;
            this.btnSalesByCategory.Click += new System.EventHandler(this.btnSalesByCategory_Click);
            // 
            // btnTop5Employees
            // 
            this.btnTop5Employees.BackColor = System.Drawing.Color.Maroon;
            this.btnTop5Employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTop5Employees.FlatAppearance.BorderSize = 0;
            this.btnTop5Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop5Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop5Employees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTop5Employees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTop5Employees.Location = new System.Drawing.Point(45, 160);
            this.btnTop5Employees.Name = "btnTop5Employees";
            this.btnTop5Employees.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnTop5Employees.Size = new System.Drawing.Size(339, 34);
            this.btnTop5Employees.TabIndex = 97;
            this.btnTop5Employees.Text = "Top 5 Employees by Sales";
            this.btnTop5Employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTop5Employees.UseVisualStyleBackColor = false;
            this.btnTop5Employees.Click += new System.EventHandler(this.btnTop5Employees_Click);
            // 
            // btnSalesBeetweenDates
            // 
            this.btnSalesBeetweenDates.BackColor = System.Drawing.Color.Maroon;
            this.btnSalesBeetweenDates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesBeetweenDates.FlatAppearance.BorderSize = 0;
            this.btnSalesBeetweenDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesBeetweenDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesBeetweenDates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesBeetweenDates.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesBeetweenDates.Location = new System.Drawing.Point(45, 200);
            this.btnSalesBeetweenDates.Name = "btnSalesBeetweenDates";
            this.btnSalesBeetweenDates.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalesBeetweenDates.Size = new System.Drawing.Size(339, 34);
            this.btnSalesBeetweenDates.TabIndex = 98;
            this.btnSalesBeetweenDates.Text = "Sales Between Dates";
            this.btnSalesBeetweenDates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesBeetweenDates.UseVisualStyleBackColor = false;
            this.btnSalesBeetweenDates.Click += new System.EventHandler(this.btnSalesBeetweenDates_Click);
            // 
            // btnSalesByCustomer
            // 
            this.btnSalesByCustomer.BackColor = System.Drawing.Color.Maroon;
            this.btnSalesByCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesByCustomer.FlatAppearance.BorderSize = 0;
            this.btnSalesByCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesByCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesByCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesByCustomer.Location = new System.Drawing.Point(45, 310);
            this.btnSalesByCustomer.Name = "btnSalesByCustomer";
            this.btnSalesByCustomer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalesByCustomer.Size = new System.Drawing.Size(339, 34);
            this.btnSalesByCustomer.TabIndex = 99;
            this.btnSalesByCustomer.Text = "Total Sales by Customer";
            this.btnSalesByCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesByCustomer.UseVisualStyleBackColor = false;
            this.btnSalesByCustomer.Click += new System.EventHandler(this.btnSalesByCustomer_Click);
            // 
            // btnSalesByEmployee
            // 
            this.btnSalesByEmployee.BackColor = System.Drawing.Color.Maroon;
            this.btnSalesByEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesByEmployee.FlatAppearance.BorderSize = 0;
            this.btnSalesByEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesByEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesByEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesByEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesByEmployee.Location = new System.Drawing.Point(45, 412);
            this.btnSalesByEmployee.Name = "btnSalesByEmployee";
            this.btnSalesByEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalesByEmployee.Size = new System.Drawing.Size(339, 34);
            this.btnSalesByEmployee.TabIndex = 100;
            this.btnSalesByEmployee.Text = "Sales by Employee";
            this.btnSalesByEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesByEmployee.UseVisualStyleBackColor = false;
            this.btnSalesByEmployee.Click += new System.EventHandler(this.btnSalesByEmployee_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(189, 242);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(123, 22);
            this.dtpStartDate.TabIndex = 101;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(189, 270);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(123, 22);
            this.dtpEndDate.TabIndex = 102;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(189, 350);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(138, 22);
            this.txtCustomerName.TabIndex = 105;
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(189, 384);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(138, 22);
            this.txtCustomerLastname.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Customer Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Start Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "End Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "Employee Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(189, 459);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(138, 22);
            this.txtEmployeeName.TabIndex = 114;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(189, 489);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(138, 22);
            this.txtEmployeeLastName.TabIndex = 115;
            // 
            // dateTimePickerSalesE1
            // 
            this.dateTimePickerSalesE1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSalesE1.Location = new System.Drawing.Point(189, 519);
            this.dateTimePickerSalesE1.Name = "dateTimePickerSalesE1";
            this.dateTimePickerSalesE1.Size = new System.Drawing.Size(138, 22);
            this.dateTimePickerSalesE1.TabIndex = 119;
            // 
            // dateTimePickerSalesE2
            // 
            this.dateTimePickerSalesE2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSalesE2.Location = new System.Drawing.Point(189, 549);
            this.dateTimePickerSalesE2.Name = "dateTimePickerSalesE2";
            this.dateTimePickerSalesE2.Size = new System.Drawing.Size(138, 22);
            this.dateTimePickerSalesE2.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 121;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 123;
            this.label9.Text = "End Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 122;
            this.label10.Text = "Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(519, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 70);
            this.label11.TabIndex = 124;
            this.label11.Text = "Reports";
            // 
            // frmReports1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 604);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerSalesE2);
            this.Controls.Add(this.dateTimePickerSalesE1);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerLastname);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnSalesByEmployee);
            this.Controls.Add(this.btnSalesByCustomer);
            this.Controls.Add(this.btnSalesBeetweenDates);
            this.Controls.Add(this.btnTop5Employees);
            this.Controls.Add(this.btnSalesByCategory);
            this.Controls.Add(this.btnSalesPerBranch);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnPurchasesPerSupplier);
            this.Name = "frmReports1";
            this.Text = "frmReports1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPurchasesPerSupplier;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnSalesPerBranch;
        private System.Windows.Forms.Button btnSalesByCategory;
        private System.Windows.Forms.Button btnTop5Employees;
        private System.Windows.Forms.Button btnSalesBeetweenDates;
        private System.Windows.Forms.Button btnSalesByCustomer;
        private System.Windows.Forms.Button btnSalesByEmployee;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalesE1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalesE2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}