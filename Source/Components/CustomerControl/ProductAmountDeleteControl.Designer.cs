
namespace HQTCSDL_Group01.Components
{
    partial class ProductAmountDeleteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.productIDCbb = new System.Windows.Forms.ComboBox();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.productPriceTb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productIDCbb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productNameTb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.amountNumeric, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // productPriceTb
            // 
            this.productPriceTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPriceTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(317, 3);
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.ReadOnly = true;
            this.productPriceTb.Size = new System.Drawing.Size(151, 30);
            this.productPriceTb.TabIndex = 2;
            // 
            // productIDCbb
            // 
            this.productIDCbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productIDCbb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIDCbb.FormattingEnabled = true;
            this.productIDCbb.Location = new System.Drawing.Point(3, 3);
            this.productIDCbb.Name = "productIDCbb";
            this.productIDCbb.Size = new System.Drawing.Size(151, 31);
            this.productIDCbb.TabIndex = 0;
            // 
            // productNameTb
            // 
            this.productNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(160, 3);
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.ReadOnly = true;
            this.productNameTb.Size = new System.Drawing.Size(151, 30);
            this.productNameTb.TabIndex = 1;
            // 
            // amountNumeric
            // 
            this.amountNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountNumeric.Location = new System.Drawing.Point(474, 3);
            this.amountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(150, 30);
            this.amountNumeric.TabIndex = 3;
            this.amountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(631, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(151, 33);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Xóa sản phẩm";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // ProductAmountDeleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductAmountDeleteControl";
            this.Size = new System.Drawing.Size(785, 39);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox productPriceTb;
        private System.Windows.Forms.ComboBox productIDCbb;
        private System.Windows.Forms.TextBox productNameTb;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Button deleteButton;
    }
}
