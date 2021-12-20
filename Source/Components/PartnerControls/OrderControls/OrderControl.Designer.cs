
namespace HQTCSDL_Group01.Components.PartnerControls.OrderControls
{
    partial class OrderControl
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
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.shippingPriceTb = new System.Windows.Forms.TextBox();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.orderStateTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.shippingMethodTb = new System.Windows.Forms.TextBox();
            this.shipperIDTb = new System.Windows.Forms.TextBox();
            this.customerIDTb = new System.Windows.Forms.TextBox();
            this.branchIDTb = new System.Windows.Forms.TextBox();
            this.orderIDTb = new System.Windows.Forms.TextBox();
            this.viewProductButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.ColumnCount = 10;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.panel.Controls.Add(this.shippingPriceTb, 8, 0);
            this.panel.Controls.Add(this.productPriceTb, 7, 0);
            this.panel.Controls.Add(this.orderStateTb, 6, 0);
            this.panel.Controls.Add(this.addressTb, 5, 0);
            this.panel.Controls.Add(this.shippingMethodTb, 4, 0);
            this.panel.Controls.Add(this.shipperIDTb, 3, 0);
            this.panel.Controls.Add(this.customerIDTb, 2, 0);
            this.panel.Controls.Add(this.branchIDTb, 1, 0);
            this.panel.Controls.Add(this.orderIDTb, 0, 0);
            this.panel.Controls.Add(this.viewProductButton, 9, 0);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.RowCount = 1;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel.Size = new System.Drawing.Size(850, 36);
            this.panel.TabIndex = 0;
            // 
            // shippingPriceTb
            // 
            this.shippingPriceTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shippingPriceTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingPriceTb.Location = new System.Drawing.Point(664, 3);
            this.shippingPriceTb.Name = "shippingPriceTb";
            this.shippingPriceTb.ReadOnly = true;
            this.shippingPriceTb.Size = new System.Drawing.Size(79, 30);
            this.shippingPriceTb.TabIndex = 8;
            // 
            // productPriceTb
            // 
            this.productPriceTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPriceTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(579, 3);
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.ReadOnly = true;
            this.productPriceTb.Size = new System.Drawing.Size(79, 30);
            this.productPriceTb.TabIndex = 7;
            // 
            // orderStateTb
            // 
            this.orderStateTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderStateTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderStateTb.Location = new System.Drawing.Point(494, 3);
            this.orderStateTb.Name = "orderStateTb";
            this.orderStateTb.ReadOnly = true;
            this.orderStateTb.Size = new System.Drawing.Size(79, 30);
            this.orderStateTb.TabIndex = 6;
            // 
            // addressTb
            // 
            this.addressTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTb.Location = new System.Drawing.Point(324, 3);
            this.addressTb.Name = "addressTb";
            this.addressTb.ReadOnly = true;
            this.addressTb.Size = new System.Drawing.Size(164, 30);
            this.addressTb.TabIndex = 5;
            // 
            // shippingMethodTb
            // 
            this.shippingMethodTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shippingMethodTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingMethodTb.Location = new System.Drawing.Point(239, 3);
            this.shippingMethodTb.Name = "shippingMethodTb";
            this.shippingMethodTb.ReadOnly = true;
            this.shippingMethodTb.Size = new System.Drawing.Size(79, 30);
            this.shippingMethodTb.TabIndex = 4;
            // 
            // shipperIDTb
            // 
            this.shipperIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shipperIDTb.Location = new System.Drawing.Point(180, 3);
            this.shipperIDTb.Name = "shipperIDTb";
            this.shipperIDTb.ReadOnly = true;
            this.shipperIDTb.Size = new System.Drawing.Size(53, 30);
            this.shipperIDTb.TabIndex = 3;
            // 
            // customerIDTb
            // 
            this.customerIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerIDTb.Location = new System.Drawing.Point(121, 3);
            this.customerIDTb.Name = "customerIDTb";
            this.customerIDTb.ReadOnly = true;
            this.customerIDTb.Size = new System.Drawing.Size(53, 30);
            this.customerIDTb.TabIndex = 2;
            // 
            // branchIDTb
            // 
            this.branchIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branchIDTb.Location = new System.Drawing.Point(62, 3);
            this.branchIDTb.Name = "branchIDTb";
            this.branchIDTb.ReadOnly = true;
            this.branchIDTb.Size = new System.Drawing.Size(53, 30);
            this.branchIDTb.TabIndex = 1;
            // 
            // orderIDTb
            // 
            this.orderIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderIDTb.Location = new System.Drawing.Point(3, 3);
            this.orderIDTb.Name = "orderIDTb";
            this.orderIDTb.ReadOnly = true;
            this.orderIDTb.Size = new System.Drawing.Size(53, 30);
            this.orderIDTb.TabIndex = 0;
            // 
            // viewProductButton
            // 
            this.viewProductButton.AutoSize = true;
            this.viewProductButton.Location = new System.Drawing.Point(749, 3);
            this.viewProductButton.Name = "viewProductButton";
            this.viewProductButton.Size = new System.Drawing.Size(94, 30);
            this.viewProductButton.TabIndex = 9;
            this.viewProductButton.Text = "Chi tiết";
            this.viewProductButton.UseVisualStyleBackColor = true;
            this.viewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(850, 36);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.TextBox shippingPriceTb;
        private System.Windows.Forms.TextBox productPriceTb;
        private System.Windows.Forms.TextBox orderStateTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox shippingMethodTb;
        private System.Windows.Forms.TextBox shipperIDTb;
        private System.Windows.Forms.TextBox customerIDTb;
        private System.Windows.Forms.TextBox branchIDTb;
        private System.Windows.Forms.TextBox orderIDTb;
        private System.Windows.Forms.Button viewProductButton;
    }
}
