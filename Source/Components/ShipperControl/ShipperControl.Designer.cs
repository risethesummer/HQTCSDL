
namespace HQTCSDL_Group01.Components.ShipperControl
{
    partial class ShipperControl
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
            System.Windows.Forms.TabPage tabPage11;
            System.Windows.Forms.TabPage tabPage12;
            System.Windows.Forms.TabPage tabPage13;
            this.acceptOrderGridView = new System.Windows.Forms.TabControl();
            this.acceptOrderControl = new HQTCSDL_Group01.Components.ShipperControl.AcceptOrderControl();
            this.updateOrderControl = new HQTCSDL_Group01.Components.ShipperControl.UpdateOrderControl();
            this.shipperViewStatisticsControl = new HQTCSDL_Group01.Components.ShipperControl.ShipperViewStatisticsControl();
            tabPage11 = new System.Windows.Forms.TabPage();
            tabPage12 = new System.Windows.Forms.TabPage();
            tabPage13 = new System.Windows.Forms.TabPage();
            this.acceptOrderGridView.SuspendLayout();
            tabPage11.SuspendLayout();
            tabPage12.SuspendLayout();
            tabPage13.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceptOrderGridView
            // 
            this.acceptOrderGridView.Controls.Add(tabPage11);
            this.acceptOrderGridView.Controls.Add(tabPage12);
            this.acceptOrderGridView.Controls.Add(tabPage13);
            this.acceptOrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptOrderGridView.Location = new System.Drawing.Point(0, 0);
            this.acceptOrderGridView.Name = "acceptOrderGridView";
            this.acceptOrderGridView.SelectedIndex = 0;
            this.acceptOrderGridView.Size = new System.Drawing.Size(556, 527);
            this.acceptOrderGridView.TabIndex = 1;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(this.acceptOrderControl);
            tabPage11.Location = new System.Drawing.Point(4, 29);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new System.Windows.Forms.Padding(3);
            tabPage11.Size = new System.Drawing.Size(548, 494);
            tabPage11.TabIndex = 0;
            tabPage11.Text = "Nhận đơn hàng";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // acceptOrderControl
            // 
            this.acceptOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptOrderControl.Location = new System.Drawing.Point(3, 3);
            this.acceptOrderControl.Name = "acceptOrderControl";
            this.acceptOrderControl.Size = new System.Drawing.Size(542, 488);
            this.acceptOrderControl.TabIndex = 0;
            // 
            // tabPage12
            // 
            tabPage12.Controls.Add(this.updateOrderControl);
            tabPage12.Location = new System.Drawing.Point(4, 29);
            tabPage12.Name = "tabPage12";
            tabPage12.Padding = new System.Windows.Forms.Padding(3);
            tabPage12.Size = new System.Drawing.Size(542, 417);
            tabPage12.TabIndex = 1;
            tabPage12.Text = "Cập nhật đơn hàng";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // updateOrderControl
            // 
            this.updateOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateOrderControl.Location = new System.Drawing.Point(3, 3);
            this.updateOrderControl.Name = "updateOrderControl";
            this.updateOrderControl.Size = new System.Drawing.Size(536, 411);
            this.updateOrderControl.TabIndex = 0;
            // 
            // tabPage13
            // 
            tabPage13.Controls.Add(this.shipperViewStatisticsControl);
            tabPage13.Location = new System.Drawing.Point(4, 29);
            tabPage13.Name = "tabPage13";
            tabPage13.Size = new System.Drawing.Size(542, 417);
            tabPage13.TabIndex = 2;
            tabPage13.Text = "Thống kê thu nhập";
            tabPage13.UseVisualStyleBackColor = true;
            // 
            // shipperViewStatisticsControl
            // 
            this.shipperViewStatisticsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperViewStatisticsControl.Location = new System.Drawing.Point(0, 0);
            this.shipperViewStatisticsControl.Name = "shipperViewStatisticsControl";
            this.shipperViewStatisticsControl.Size = new System.Drawing.Size(542, 417);
            this.shipperViewStatisticsControl.TabIndex = 0;
            // 
            // ShipperControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acceptOrderGridView);
            this.Name = "ShipperControl";
            this.Size = new System.Drawing.Size(556, 527);
            this.acceptOrderGridView.ResumeLayout(false);
            tabPage11.ResumeLayout(false);
            tabPage12.ResumeLayout(false);
            tabPage13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl acceptOrderGridView;
        private AcceptOrderControl acceptOrderControl;
        private UpdateOrderControl updateOrderControl;
        private ShipperViewStatisticsControl shipperViewStatisticsControl;
    }
}
