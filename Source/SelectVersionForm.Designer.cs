
namespace HQTCSDL_Group01
{
    partial class SelectVersionForm
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
            System.Windows.Forms.TableLayoutPanel versionsPanel;
            this.errorVersionButton = new System.Windows.Forms.Button();
            this.fixVersionButton = new System.Windows.Forms.Button();
            versionsPanel = new System.Windows.Forms.TableLayoutPanel();
            versionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionsPanel
            // 
            versionsPanel.ColumnCount = 1;
            versionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.Controls.Add(this.errorVersionButton, 0, 0);
            versionsPanel.Controls.Add(this.fixVersionButton, 0, 1);
            versionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            versionsPanel.Location = new System.Drawing.Point(0, 0);
            versionsPanel.Name = "versionsPanel";
            versionsPanel.RowCount = 2;
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            versionsPanel.Size = new System.Drawing.Size(800, 450);
            versionsPanel.TabIndex = 0;
            // 
            // errorVersionButton
            // 
            this.errorVersionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorVersionButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorVersionButton.Location = new System.Drawing.Point(3, 3);
            this.errorVersionButton.Name = "errorVersionButton";
            this.errorVersionButton.Size = new System.Drawing.Size(794, 219);
            this.errorVersionButton.TabIndex = 0;
            this.errorVersionButton.Text = "Phiên bản lỗi";
            this.errorVersionButton.UseVisualStyleBackColor = true;
            this.errorVersionButton.Click += new System.EventHandler(this.errorVersionButton_Click);
            // 
            // fixVersionButton
            // 
            this.fixVersionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixVersionButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fixVersionButton.Location = new System.Drawing.Point(3, 228);
            this.fixVersionButton.Name = "fixVersionButton";
            this.fixVersionButton.Size = new System.Drawing.Size(794, 219);
            this.fixVersionButton.TabIndex = 1;
            this.fixVersionButton.Text = "Phiên bản sửa lỗi";
            this.fixVersionButton.UseVisualStyleBackColor = true;
            this.fixVersionButton.Click += new System.EventHandler(this.fixVersionButton_Click);
            // 
            // SelectVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(versionsPanel);
            this.Name = "SelectVersionForm";
            this.Text = "Chọn phiên bản";
            versionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button errorVersionButton;
        private System.Windows.Forms.Button fixVersionButton;
    }
}