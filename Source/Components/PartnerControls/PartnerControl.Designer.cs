
namespace HQTCSDL_Group01.Components.PartnerControls
{
    partial class PartnerControl
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
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.TabPage contractTab;
            System.Windows.Forms.TabPage productTab;
            System.Windows.Forms.TabPage orderTab;
            System.Windows.Forms.TabControl tabControl6;
            System.Windows.Forms.TabPage tabPage14;
            System.Windows.Forms.TabPage tabPage15;
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extendContractControl = new HQTCSDL_Group01.Components.PartnerControls.ExtendContractControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.viewContractControl = new HQTCSDL_Group01.Components.PartnerControls.ViewContractControl();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.addProductControl = new HQTCSDL_Group01.Components.PartnerControls.AddProductControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.deleteProductControl = new HQTCSDL_Group01.Components.PartnerControls.DeleteProductControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.updateProductControl = new HQTCSDL_Group01.Components.PartnerControls.UpdateProductControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.updateProductAmountControl = new HQTCSDL_Group01.Components.PartnerControls.UpdateProductAmountControl();
            this.partnerViewOrderControl = new HQTCSDL_Group01.Components.PartnerControls.OrderControls.PartnerViewOrderControl();
            this.partnerStatisticsControl = new HQTCSDL_Group01.Components.PartnerControls.PartnerStatisticsControl();
            tabControl1 = new System.Windows.Forms.TabControl();
            contractTab = new System.Windows.Forms.TabPage();
            productTab = new System.Windows.Forms.TabPage();
            orderTab = new System.Windows.Forms.TabPage();
            tabControl6 = new System.Windows.Forms.TabControl();
            tabPage14 = new System.Windows.Forms.TabPage();
            tabPage15 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            contractTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            productTab.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            orderTab.SuspendLayout();
            tabControl6.SuspendLayout();
            tabPage14.SuspendLayout();
            tabPage15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(contractTab);
            tabControl1.Controls.Add(productTab);
            tabControl1.Controls.Add(orderTab);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(686, 497);
            tabControl1.TabIndex = 1;
            // 
            // contractTab
            // 
            contractTab.Controls.Add(this.tabControl3);
            contractTab.Location = new System.Drawing.Point(4, 29);
            contractTab.Name = "contractTab";
            contractTab.Padding = new System.Windows.Forms.Padding(3);
            contractTab.Size = new System.Drawing.Size(678, 464);
            contractTab.TabIndex = 1;
            contractTab.Text = "Hợp đồng";
            contractTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(672, 458);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.extendContractControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gia hạn hợp đồng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // extendContractControl
            // 
            this.extendContractControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            this.extendContractControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendContractControl.Error = false;
            this.extendContractControl.Location = new System.Drawing.Point(3, 3);
            this.extendContractControl.Name = "extendContractControl";
            this.extendContractControl.Size = new System.Drawing.Size(658, 419);
            this.extendContractControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.viewContractControl);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem hợp đồng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewContractControl
            // 
            this.viewContractControl.CurrentID = 0;
            this.viewContractControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewContractControl.Location = new System.Drawing.Point(0, 0);
            this.viewContractControl.Name = "viewContractControl";
            this.viewContractControl.Size = new System.Drawing.Size(664, 425);
            this.viewContractControl.TabIndex = 0;
            // 
            // productTab
            // 
            productTab.Controls.Add(this.tabControl4);
            productTab.Location = new System.Drawing.Point(4, 29);
            productTab.Name = "productTab";
            productTab.Size = new System.Drawing.Size(678, 464);
            productTab.TabIndex = 2;
            productTab.Text = "Sản phẩm";
            productTab.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Controls.Add(this.tabPage5);
            this.tabControl4.Controls.Add(this.tabPage6);
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(678, 464);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.addProductControl);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(670, 431);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Thêm sản phẩm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // addProductControl
            // 
            this.addProductControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductControl.Location = new System.Drawing.Point(3, 3);
            this.addProductControl.Name = "addProductControl";
            this.addProductControl.Size = new System.Drawing.Size(664, 425);
            this.addProductControl.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.deleteProductControl);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(184, 34);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Xóa sản phẩm";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // deleteProductControl
            // 
            this.deleteProductControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteProductControl.Location = new System.Drawing.Point(3, 3);
            this.deleteProductControl.Name = "deleteProductControl";
            this.deleteProductControl.Size = new System.Drawing.Size(178, 28);
            this.deleteProductControl.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.updateProductControl);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(184, 34);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Cập nhật thông tin sản phẩm";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // updateProductControl
            // 
            this.updateProductControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateProductControl.Location = new System.Drawing.Point(0, 0);
            this.updateProductControl.Name = "updateProductControl";
            this.updateProductControl.Size = new System.Drawing.Size(184, 34);
            this.updateProductControl.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.updateProductAmountControl);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(184, 34);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Cập nhật số lượng sản phẩm";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // updateProductAmountControl
            // 
            this.updateProductAmountControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            this.updateProductAmountControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateProductAmountControl.Error = false;
            this.updateProductAmountControl.Location = new System.Drawing.Point(0, 0);
            this.updateProductAmountControl.Name = "updateProductAmountControl";
            this.updateProductAmountControl.Size = new System.Drawing.Size(184, 34);
            this.updateProductAmountControl.TabIndex = 0;
            // 
            // orderTab
            // 
            orderTab.Controls.Add(tabControl6);
            orderTab.Location = new System.Drawing.Point(4, 29);
            orderTab.Name = "orderTab";
            orderTab.Size = new System.Drawing.Size(678, 464);
            orderTab.TabIndex = 3;
            orderTab.Text = "Đơn hàng";
            orderTab.UseVisualStyleBackColor = true;
            // 
            // tabControl6
            // 
            tabControl6.Controls.Add(tabPage14);
            tabControl6.Controls.Add(tabPage15);
            tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl6.Location = new System.Drawing.Point(0, 0);
            tabControl6.Name = "tabControl6";
            tabControl6.SelectedIndex = 0;
            tabControl6.Size = new System.Drawing.Size(678, 464);
            tabControl6.TabIndex = 0;
            // 
            // tabPage14
            // 
            tabPage14.Controls.Add(this.partnerViewOrderControl);
            tabPage14.Location = new System.Drawing.Point(4, 29);
            tabPage14.Name = "tabPage14";
            tabPage14.Padding = new System.Windows.Forms.Padding(3);
            tabPage14.Size = new System.Drawing.Size(670, 431);
            tabPage14.TabIndex = 0;
            tabPage14.Text = "Xem đơn hàng";
            tabPage14.UseVisualStyleBackColor = true;
            // 
            // partnerViewOrderControl
            // 
            this.partnerViewOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partnerViewOrderControl.Location = new System.Drawing.Point(3, 3);
            this.partnerViewOrderControl.Name = "partnerViewOrderControl";
            this.partnerViewOrderControl.Size = new System.Drawing.Size(664, 425);
            this.partnerViewOrderControl.TabIndex = 0;
            // 
            // tabPage15
            // 
            tabPage15.Controls.Add(this.partnerStatisticsControl);
            tabPage15.Location = new System.Drawing.Point(4, 29);
            tabPage15.Name = "tabPage15";
            tabPage15.Padding = new System.Windows.Forms.Padding(3);
            tabPage15.Size = new System.Drawing.Size(184, 34);
            tabPage15.TabIndex = 1;
            tabPage15.Text = "Thống kê đơn hàng";
            tabPage15.UseVisualStyleBackColor = true;
            // 
            // partnerStatisticsControl
            // 
            this.partnerStatisticsControl.CurrentDelay = System.TimeSpan.Parse("00:00:00");
            this.partnerStatisticsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partnerStatisticsControl.Error = false;
            this.partnerStatisticsControl.Location = new System.Drawing.Point(3, 3);
            this.partnerStatisticsControl.Name = "partnerStatisticsControl";
            this.partnerStatisticsControl.Size = new System.Drawing.Size(178, 28);
            this.partnerStatisticsControl.TabIndex = 0;
            // 
            // PartnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(tabControl1);
            this.Name = "PartnerControl";
            this.Size = new System.Drawing.Size(686, 497);
            tabControl1.ResumeLayout(false);
            contractTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            productTab.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            orderTab.ResumeLayout(false);
            tabControl6.ResumeLayout(false);
            tabPage14.ResumeLayout(false);
            tabPage15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage2;
        private ExtendContractControl extendContractControl;
        private System.Windows.Forms.TabPage tabPage3;
        private ViewContractControl viewContractControl;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private AddProductControl addProductControl;
        private DeleteProductControl deleteProductControl;
        private UpdateProductControl updateProductControl;
        private UpdateProductAmountControl updateProductAmountControl;
        private OrderControls.PartnerViewOrderControl partnerViewOrderControl;
        private PartnerStatisticsControl partnerStatisticsControl;
    }
}
