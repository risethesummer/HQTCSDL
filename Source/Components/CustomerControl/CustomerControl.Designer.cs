
namespace HQTCSDL_Group01.Components.CustomerControl
{
    partial class CustomerControl
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
            System.Windows.Forms.TabControl tabControl5;
            System.Windows.Forms.TabPage tabPage8;
            System.Windows.Forms.TabPage tabPage9;
            System.Windows.Forms.TabPage tabPage10;
            this.createOrderControl = new HQTCSDL_Group01.Components.CustomerControl.CreateOrderControl();
            this.customerViewOrderControl = new HQTCSDL_Group01.Components.CustomerControl.CustomerViewOrderControl();
            this.customerOrderStatisticsControl = new HQTCSDL_Group01.Components.CustomerControl.CustomerOrderStatisticsControl();
            tabControl5 = new System.Windows.Forms.TabControl();
            tabPage8 = new System.Windows.Forms.TabPage();
            tabPage9 = new System.Windows.Forms.TabPage();
            tabPage10 = new System.Windows.Forms.TabPage();
            tabControl5.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl5
            // 
            tabControl5.Controls.Add(tabPage8);
            tabControl5.Controls.Add(tabPage9);
            tabControl5.Controls.Add(tabPage10);
            tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl5.Location = new System.Drawing.Point(0, 0);
            tabControl5.Name = "tabControl5";
            tabControl5.SelectedIndex = 0;
            tabControl5.Size = new System.Drawing.Size(501, 553);
            tabControl5.TabIndex = 1;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(this.createOrderControl);
            tabPage8.Location = new System.Drawing.Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new System.Windows.Forms.Padding(3);
            tabPage8.Size = new System.Drawing.Size(493, 520);
            tabPage8.TabIndex = 0;
            tabPage8.Text = "Tạo đơn hàng";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // createOrderControl
            // 
            this.createOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createOrderControl.Location = new System.Drawing.Point(3, 3);
            this.createOrderControl.Name = "createOrderControl";
            this.createOrderControl.Size = new System.Drawing.Size(487, 514);
            this.createOrderControl.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(this.customerViewOrderControl);
            tabPage9.Location = new System.Drawing.Point(4, 29);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new System.Windows.Forms.Padding(3);
            tabPage9.Size = new System.Drawing.Size(487, 440);
            tabPage9.TabIndex = 1;
            tabPage9.Text = "Xem đơn hàng hiện tại";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // customerViewOrderControl
            // 
            this.customerViewOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerViewOrderControl.Location = new System.Drawing.Point(3, 3);
            this.customerViewOrderControl.Name = "customerViewOrderControl";
            this.customerViewOrderControl.Size = new System.Drawing.Size(481, 434);
            this.customerViewOrderControl.TabIndex = 0;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(this.customerOrderStatisticsControl);
            tabPage10.Location = new System.Drawing.Point(4, 29);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new System.Drawing.Size(487, 440);
            tabPage10.TabIndex = 2;
            tabPage10.Text = "Thống kê các đơn hàng";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // customerOrderStatisticsControl
            // 
            this.customerOrderStatisticsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerOrderStatisticsControl.Location = new System.Drawing.Point(0, 0);
            this.customerOrderStatisticsControl.Name = "customerOrderStatisticsControl";
            this.customerOrderStatisticsControl.Size = new System.Drawing.Size(487, 440);
            this.customerOrderStatisticsControl.TabIndex = 0;
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(tabControl5);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(501, 553);
            tabControl5.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CreateOrderControl createOrderControl;
        private CustomerViewOrderControl customerViewOrderControl;
        private CustomerOrderStatisticsControl customerOrderStatisticsControl;
    }
}
