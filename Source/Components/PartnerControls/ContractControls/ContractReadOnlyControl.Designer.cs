
namespace HQTCSDL_Group01.Components.PartnerControls.ContractControls
{
    partial class ContractReadOnlyControl
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.contractIDTb = new System.Windows.Forms.TextBox();
            this.contractTaxTb = new System.Windows.Forms.TextBox();
            this.viewBranchButton = new System.Windows.Forms.Button();
            this.contractRepTb = new System.Windows.Forms.TextBox();
            this.contractDatesTb = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(this.contractIDTb, 0, 0);
            tableLayoutPanel1.Controls.Add(this.contractTaxTb, 1, 0);
            tableLayoutPanel1.Controls.Add(this.viewBranchButton, 4, 0);
            tableLayoutPanel1.Controls.Add(this.contractRepTb, 2, 0);
            tableLayoutPanel1.Controls.Add(this.contractDatesTb, 3, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(900, 36);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // contractIDTb
            // 
            this.contractIDTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractIDTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractIDTb.Location = new System.Drawing.Point(3, 3);
            this.contractIDTb.Name = "contractIDTb";
            this.contractIDTb.ReadOnly = true;
            this.contractIDTb.Size = new System.Drawing.Size(129, 30);
            this.contractIDTb.TabIndex = 0;
            // 
            // contractTaxTb
            // 
            this.contractTaxTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractTaxTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractTaxTb.Location = new System.Drawing.Point(138, 3);
            this.contractTaxTb.Name = "contractTaxTb";
            this.contractTaxTb.ReadOnly = true;
            this.contractTaxTb.Size = new System.Drawing.Size(129, 30);
            this.contractTaxTb.TabIndex = 1;
            // 
            // viewBranchButton
            // 
            this.viewBranchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewBranchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewBranchButton.Location = new System.Drawing.Point(723, 3);
            this.viewBranchButton.Name = "viewBranchButton";
            this.viewBranchButton.Size = new System.Drawing.Size(174, 30);
            this.viewBranchButton.TabIndex = 3;
            this.viewBranchButton.Text = "Xem chi nhánh";
            this.viewBranchButton.UseVisualStyleBackColor = true;
            this.viewBranchButton.Click += new System.EventHandler(this.ViewBranchButton_Click);
            // 
            // contractRepTb
            // 
            this.contractRepTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractRepTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractRepTb.Location = new System.Drawing.Point(273, 3);
            this.contractRepTb.Name = "contractRepTb";
            this.contractRepTb.ReadOnly = true;
            this.contractRepTb.Size = new System.Drawing.Size(129, 30);
            this.contractRepTb.TabIndex = 4;
            // 
            // contractDatesTb
            // 
            this.contractDatesTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractDatesTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractDatesTb.Location = new System.Drawing.Point(408, 3);
            this.contractDatesTb.Name = "contractDatesTb";
            this.contractDatesTb.ReadOnly = true;
            this.contractDatesTb.Size = new System.Drawing.Size(309, 30);
            this.contractDatesTb.TabIndex = 5;
            // 
            // ContractReadOnlyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(tableLayoutPanel1);
            this.Name = "ContractReadOnlyControl";
            this.Size = new System.Drawing.Size(900, 36);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox contractIDTb;
        private System.Windows.Forms.TextBox contractTaxTb;
        private System.Windows.Forms.Button viewBranchButton;
        private System.Windows.Forms.TextBox contractRepTb;
        private System.Windows.Forms.TextBox contractDatesTb;
    }
}
