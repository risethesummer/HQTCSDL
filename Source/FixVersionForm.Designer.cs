
namespace HQTCSDL_Group01
{
    partial class FixVersionForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label1;
            this.functionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.delayTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.currentFunctionLabel = new System.Windows.Forms.Label();
            this.currentFunctionPanel = new System.Windows.Forms.Panel();
            this.loginControl = new HQTCSDL_Group01.Components.LoginControl();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            this.functionsPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // functionsPanel
            // 
            this.functionsPanel.ColumnCount = 1;
            this.functionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.functionsPanel.Controls.Add(tableLayoutPanel5, 0, 0);
            this.functionsPanel.Controls.Add(this.currentFunctionPanel, 0, 1);
            this.functionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionsPanel.Location = new System.Drawing.Point(0, 0);
            this.functionsPanel.Name = "functionsPanel";
            this.functionsPanel.RowCount = 3;
            this.functionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.functionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.functionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.functionsPanel.Size = new System.Drawing.Size(825, 540);
            this.functionsPanel.TabIndex = 2;
            this.functionsPanel.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(this.logoutButton, 2, 0);
            tableLayoutPanel5.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel5.Controls.Add(this.currentFunctionLabel, 1, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(819, 46);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.Location = new System.Drawing.Point(713, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(103, 33);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Đăng xuất";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(this.delayTimeNumeric);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(321, 40);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 23);
            label1.TabIndex = 1;
            label1.Text = "Thời gian chờ (giây)";
            // 
            // delayTimeNumeric
            // 
            this.delayTimeNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delayTimeNumeric.Location = new System.Drawing.Point(3, 26);
            this.delayTimeNumeric.Name = "delayTimeNumeric";
            this.delayTimeNumeric.Size = new System.Drawing.Size(150, 30);
            this.delayTimeNumeric.TabIndex = 2;
            // 
            // currentFunctionLabel
            // 
            this.currentFunctionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.currentFunctionLabel.AutoSize = true;
            this.currentFunctionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentFunctionLabel.Location = new System.Drawing.Point(407, 0);
            this.currentFunctionLabel.Name = "currentFunctionLabel";
            this.currentFunctionLabel.Size = new System.Drawing.Size(166, 46);
            this.currentFunctionLabel.TabIndex = 4;
            this.currentFunctionLabel.Text = "Khách hàng 1";
            // 
            // currentFunctionPanel
            // 
            this.currentFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentFunctionPanel.Location = new System.Drawing.Point(3, 55);
            this.currentFunctionPanel.Name = "currentFunctionPanel";
            this.currentFunctionPanel.Size = new System.Drawing.Size(819, 462);
            this.currentFunctionPanel.TabIndex = 2;
            // 
            // loginControl
            // 
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl.Location = new System.Drawing.Point(0, 0);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(825, 540);
            this.loginControl.TabIndex = 3;
            this.loginControl.TabStop = false;
            // 
            // FixVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 540);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.functionsPanel);
            this.Name = "FixVersionForm";
            this.Text = "FixVersionForm";
            this.functionsPanel.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTimeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel functionsPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.NumericUpDown delayTimeNumeric;
        private System.Windows.Forms.Label currentFunctionLabel;
        private System.Windows.Forms.Panel currentFunctionPanel;
        private Components.LoginControl loginControl;
    }
}