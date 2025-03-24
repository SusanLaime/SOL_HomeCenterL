namespace HomeCenterL.Presentation
{
    partial class frmRegisterPurchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitaryCost1 = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.cmdSupplierName = new System.Windows.Forms.ComboBox();
            this.txtQuantity1 = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSavePurchase = new System.Windows.Forms.Button();
            this.btnCancelPurchase = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmbProductName2 = new System.Windows.Forms.ComboBox();
            this.txtUnitaryCost2 = new System.Windows.Forms.TextBox();
            this.txtQuantity2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(759, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 574);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 81);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Purchases";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Detail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unitary Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity:";
            // 
            // txtUnitaryCost1
            // 
            this.txtUnitaryCost1.Location = new System.Drawing.Point(444, 190);
            this.txtUnitaryCost1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitaryCost1.Name = "txtUnitaryCost1";
            this.txtUnitaryCost1.Size = new System.Drawing.Size(132, 22);
            this.txtUnitaryCost1.TabIndex = 8;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(115, 194);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(219, 88);
            this.txtDetail.TabIndex = 9;
            this.txtDetail.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(115, 149);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(219, 22);
            this.dtpPurchaseDate.TabIndex = 10;
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(444, 102);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(132, 24);
            this.cmbProductName.TabIndex = 11;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // cmdSupplierName
            // 
            this.cmdSupplierName.FormattingEnabled = true;
            this.cmdSupplierName.Location = new System.Drawing.Point(115, 105);
            this.cmdSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSupplierName.Name = "cmdSupplierName";
            this.cmdSupplierName.Size = new System.Drawing.Size(219, 24);
            this.cmdSupplierName.TabIndex = 12;
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.Location = new System.Drawing.Point(444, 151);
            this.txtQuantity1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity1.TabIndex = 13;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 338);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(741, 234);
            this.dgvList.TabIndex = 14;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // btnSavePurchase
            // 
            this.btnSavePurchase.BackColor = System.Drawing.Color.Maroon;
            this.btnSavePurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSavePurchase.FlatAppearance.BorderSize = 0;
            this.btnSavePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavePurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePurchase.Location = new System.Drawing.Point(347, 238);
            this.btnSavePurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePurchase.Name = "btnSavePurchase";
            this.btnSavePurchase.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.btnSavePurchase.Size = new System.Drawing.Size(151, 34);
            this.btnSavePurchase.TabIndex = 4;
            this.btnSavePurchase.Text = "Save";
            this.btnSavePurchase.UseVisualStyleBackColor = false;
            this.btnSavePurchase.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelPurchase
            // 
            this.btnCancelPurchase.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelPurchase.FlatAppearance.BorderSize = 0;
            this.btnCancelPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelPurchase.Location = new System.Drawing.Point(503, 238);
            this.btnCancelPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelPurchase.Name = "btnCancelPurchase";
            this.btnCancelPurchase.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.btnCancelPurchase.Size = new System.Drawing.Size(171, 34);
            this.btnCancelPurchase.TabIndex = 15;
            this.btnCancelPurchase.Text = "Cancel";
            this.btnCancelPurchase.UseVisualStyleBackColor = false;
            this.btnCancelPurchase.Click += new System.EventHandler(this.btnCancelPurchase_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(72, 299);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(537, 22);
            this.txtSearch.TabIndex = 17;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Maroon;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGo.Location = new System.Drawing.Point(615, 294);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(59, 33);
            this.btnGo.TabIndex = 18;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmbProductName2
            // 
            this.cmbProductName2.FormattingEnabled = true;
            this.cmbProductName2.Location = new System.Drawing.Point(581, 102);
            this.cmbProductName2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductName2.Name = "cmbProductName2";
            this.cmbProductName2.Size = new System.Drawing.Size(135, 24);
            this.cmbProductName2.TabIndex = 19;
            this.cmbProductName2.SelectedIndexChanged += new System.EventHandler(this.cmbProductName2_SelectedIndexChanged);
            // 
            // txtUnitaryCost2
            // 
            this.txtUnitaryCost2.Location = new System.Drawing.Point(581, 190);
            this.txtUnitaryCost2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitaryCost2.Name = "txtUnitaryCost2";
            this.txtUnitaryCost2.Size = new System.Drawing.Size(135, 22);
            this.txtUnitaryCost2.TabIndex = 20;
            // 
            // txtQuantity2
            // 
            this.txtQuantity2.Location = new System.Drawing.Point(581, 151);
            this.txtQuantity2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity2.Name = "txtQuantity2";
            this.txtQuantity2.Size = new System.Drawing.Size(135, 22);
            this.txtQuantity2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(681, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegisterPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(885, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuantity2);
            this.Controls.Add(this.txtUnitaryCost2);
            this.Controls.Add(this.cmbProductName2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelPurchase);
            this.Controls.Add(this.btnSavePurchase);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtQuantity1);
            this.Controls.Add(this.cmdSupplierName);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtUnitaryCost1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegisterPurchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitaryCost1;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmdSupplierName;
        private System.Windows.Forms.TextBox txtQuantity1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSavePurchase;
        private System.Windows.Forms.Button btnCancelPurchase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cmbProductName2;
        private System.Windows.Forms.TextBox txtUnitaryCost2;
        private System.Windows.Forms.TextBox txtQuantity2;
        private System.Windows.Forms.Button button1;
    }
}