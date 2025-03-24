using System;

namespace HomeCenterL.Presentation
{
    partial class frmInsertProducts
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
            this.txtStockProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblidCat = new System.Windows.Forms.Label();
            this.txtnameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidCategory = new System.Windows.Forms.TextBox();
            this.btnSavePrroduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelIProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.Location = new System.Drawing.Point(368, 328);
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.Size = new System.Drawing.Size(208, 22);
            this.txtStockProduct.TabIndex = 19;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(368, 300);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(208, 22);
            this.txtPriceProduct.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price:";
            // 
            // lblidCat
            // 
            this.lblidCat.AutoSize = true;
            this.lblidCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCat.Location = new System.Drawing.Point(271, 243);
            this.lblidCat.Name = "lblidCat";
            this.lblidCat.Size = new System.Drawing.Size(97, 16);
            this.lblidCat.TabIndex = 14;
            this.lblidCat.Text = "Category ID: ";
            this.lblidCat.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtnameProduct
            // 
            this.txtnameProduct.Location = new System.Drawing.Point(368, 271);
            this.txtnameProduct.Name = "txtnameProduct";
            this.txtnameProduct.Size = new System.Drawing.Size(208, 22);
            this.txtnameProduct.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // txtidCategory
            // 
            this.txtidCategory.Location = new System.Drawing.Point(368, 243);
            this.txtidCategory.Name = "txtidCategory";
            this.txtidCategory.Size = new System.Drawing.Size(208, 22);
            this.txtidCategory.TabIndex = 22;
            // 
            // btnSavePrroduct
            // 
            this.btnSavePrroduct.BackColor = System.Drawing.Color.Maroon;
            this.btnSavePrroduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSavePrroduct.FlatAppearance.BorderSize = 0;
            this.btnSavePrroduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrroduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrroduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavePrroduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePrroduct.Location = new System.Drawing.Point(297, 378);
            this.btnSavePrroduct.Name = "btnSavePrroduct";
            this.btnSavePrroduct.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSavePrroduct.Size = new System.Drawing.Size(151, 34);
            this.btnSavePrroduct.TabIndex = 23;
            this.btnSavePrroduct.Text = "Save";
            this.btnSavePrroduct.UseVisualStyleBackColor = false;
            this.btnSavePrroduct.Click += new System.EventHandler(this.BtnSaveProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(212, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 70);
            this.label3.TabIndex = 61;
            this.label3.Text = "Insert a Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "(3 first letters)";
            // 
            // btnCancelIProduct
            // 
            this.btnCancelIProduct.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelIProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelIProduct.FlatAppearance.BorderSize = 0;
            this.btnCancelIProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelIProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelIProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelIProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelIProduct.Location = new System.Drawing.Point(454, 378);
            this.btnCancelIProduct.Name = "btnCancelIProduct";
            this.btnCancelIProduct.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCancelIProduct.Size = new System.Drawing.Size(151, 34);
            this.btnCancelIProduct.TabIndex = 63;
            this.btnCancelIProduct.Text = "Cancel";
            this.btnCancelIProduct.UseVisualStyleBackColor = false;
            this.btnCancelIProduct.Click += new System.EventHandler(this.btnCancelIProduct_Click);
            // 
            // frmInsertProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 556);
            this.Controls.Add(this.btnCancelIProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSavePrroduct);
            this.Controls.Add(this.txtidCategory);
            this.Controls.Add(this.txtnameProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockProduct);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblidCat);
            this.Name = "frmInsertProducts";
            this.Text = "InsertProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblidCat;
        private System.Windows.Forms.TextBox txtnameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidCategory;
        private System.Windows.Forms.Button btnSavePrroduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelIProduct;
    }
}