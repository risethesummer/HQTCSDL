
namespace HQTCSDL_Group01.Components.PartnerControls
{
    partial class ExtendContractControl
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
            System.Windows.Forms.Label label20;
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.yearsNumeric = new System.Windows.Forms.NumericUpDown();
            this.monthsNumeric = new System.Windows.Forms.NumericUpDown();
            this.daysNumeric = new System.Windows.Forms.NumericUpDown();
            this.durationTb = new System.Windows.Forms.TextBox();
            this.contractIDCbb = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            label21 = new System.Windows.Forms.Label();
            tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            label20 = new System.Windows.Forms.Label();
            tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).BeginInit();
            tableLayoutPanel25.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.ColumnCount = 1;
            tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel23.Controls.Add(this.tableLayoutPanel2, 0, 2);
            tableLayoutPanel23.Controls.Add(tableLayoutPanel25, 0, 1);
            tableLayoutPanel23.Controls.Add(tableLayoutPanel26, 0, 0);
            tableLayoutPanel23.Controls.Add(this.confirmButton, 0, 3);
            tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel23.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.RowCount = 4;
            tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel23.Size = new System.Drawing.Size(647, 488);
            tableLayoutPanel23.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.yearsNumeric, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.monthsNumeric, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.daysNumeric, 2, 0);
            this.tableLayoutPanel2.Controls.Add(label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(label6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(label7, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 197);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(641, 91);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // yearsNumeric
            // 
            this.yearsNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearsNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearsNumeric.Location = new System.Drawing.Point(515, 3);
            this.yearsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yearsNumeric.Name = "yearsNumeric";
            this.yearsNumeric.Size = new System.Drawing.Size(123, 30);
            this.yearsNumeric.TabIndex = 5;
            // 
            // monthsNumeric
            // 
            this.monthsNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthsNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthsNumeric.Location = new System.Drawing.Point(323, 3);
            this.monthsNumeric.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.monthsNumeric.Name = "monthsNumeric";
            this.monthsNumeric.Size = new System.Drawing.Size(122, 30);
            this.monthsNumeric.TabIndex = 4;
            // 
            // daysNumeric
            // 
            this.daysNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysNumeric.Location = new System.Drawing.Point(131, 3);
            this.daysNumeric.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.daysNumeric.Name = "daysNumeric";
            this.daysNumeric.Size = new System.Drawing.Size(122, 30);
            this.daysNumeric.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(75, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 23);
            label5.TabIndex = 1;
            label5.Text = "Ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 46);
            label1.TabIndex = 0;
            label1.Text = "Thời hạn";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(259, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 23);
            label6.TabIndex = 2;
            label6.Text = "Tháng";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(462, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 23);
            label7.TabIndex = 3;
            label7.Text = "Năm";
            // 
            // tableLayoutPanel25
            // 
            tableLayoutPanel25.ColumnCount = 2;
            tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel25.Controls.Add(label21, 0, 0);
            tableLayoutPanel25.Controls.Add(this.durationTb, 1, 0);
            tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel25.Location = new System.Drawing.Point(3, 100);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.RowCount = 2;
            tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel25.Size = new System.Drawing.Size(641, 91);
            tableLayoutPanel25.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.Location = new System.Drawing.Point(3, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(115, 46);
            label21.TabIndex = 0;
            label21.Text = "Thời hạn còn lại";
            // 
            // durationTb
            // 
            this.durationTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durationTb.Location = new System.Drawing.Point(131, 3);
            this.durationTb.Name = "durationTb";
            this.durationTb.ReadOnly = true;
            this.durationTb.Size = new System.Drawing.Size(507, 30);
            this.durationTb.TabIndex = 1;
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 2;
            tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel26.Controls.Add(label20, 0, 0);
            tableLayoutPanel26.Controls.Add(this.contractIDCbb, 1, 0);
            tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel26.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.RowCount = 1;
            tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel26.Size = new System.Drawing.Size(641, 91);
            tableLayoutPanel26.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.Location = new System.Drawing.Point(3, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(114, 23);
            label20.TabIndex = 0;
            label20.Text = "Mã hợp đồng";
            // 
            // contractIDCbb
            // 
            this.contractIDCbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractIDCbb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractIDCbb.FormattingEnabled = true;
            this.contractIDCbb.Location = new System.Drawing.Point(131, 3);
            this.contractIDCbb.Name = "contractIDCbb";
            this.contractIDCbb.Size = new System.Drawing.Size(507, 31);
            this.contractIDCbb.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmButton.AutoSize = true;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Location = new System.Drawing.Point(276, 294);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 33);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Gia hạn";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // ExtendContractControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(tableLayoutPanel23);
            this.Name = "ExtendContractControl";
            this.Size = new System.Drawing.Size(647, 488);
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).EndInit();
            tableLayoutPanel25.ResumeLayout(false);
            tableLayoutPanel25.PerformLayout();
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox durationTb;
        private System.Windows.Forms.ComboBox contractIDCbb;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown yearsNumeric;
        private System.Windows.Forms.NumericUpDown monthsNumeric;
        private System.Windows.Forms.NumericUpDown daysNumeric;
    }
}
