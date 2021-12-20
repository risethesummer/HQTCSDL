
namespace HQTCSDL_Group01.Components.PartnerControls
{
    partial class UpdateProductAmountControl
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel49;
            System.Windows.Forms.Label label40;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel50;
            System.Windows.Forms.Label label41;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel51;
            System.Windows.Forms.Label label42;
            System.Windows.Forms.Label label43;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel48;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel52;
            this.branchIDCbb = new System.Windows.Forms.ComboBox();
            this.updateTypeCbb = new System.Windows.Forms.ComboBox();
            this.increaseAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.currentAmountTb = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.productIdCbb = new System.Windows.Forms.ComboBox();
            tableLayoutPanel49 = new System.Windows.Forms.TableLayoutPanel();
            label40 = new System.Windows.Forms.Label();
            tableLayoutPanel50 = new System.Windows.Forms.TableLayoutPanel();
            label41 = new System.Windows.Forms.Label();
            tableLayoutPanel51 = new System.Windows.Forms.TableLayoutPanel();
            label42 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            tableLayoutPanel48 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel52 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel49.SuspendLayout();
            tableLayoutPanel50.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.increaseAmountNumeric)).BeginInit();
            tableLayoutPanel51.SuspendLayout();
            tableLayoutPanel48.SuspendLayout();
            tableLayoutPanel52.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel49
            // 
            tableLayoutPanel49.ColumnCount = 2;
            tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel49.Controls.Add(label40, 0, 0);
            tableLayoutPanel49.Controls.Add(this.branchIDCbb, 1, 0);
            tableLayoutPanel49.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel49.Location = new System.Drawing.Point(3, 81);
            tableLayoutPanel49.Name = "tableLayoutPanel49";
            tableLayoutPanel49.RowCount = 1;
            tableLayoutPanel49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel49.Size = new System.Drawing.Size(719, 72);
            tableLayoutPanel49.TabIndex = 4;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label40.Location = new System.Drawing.Point(3, 0);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(115, 23);
            label40.TabIndex = 0;
            label40.Text = "Mã chi nhánh";
            // 
            // branchIDCbb
            // 
            this.branchIDCbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchIDCbb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branchIDCbb.FormattingEnabled = true;
            this.branchIDCbb.Location = new System.Drawing.Point(146, 3);
            this.branchIDCbb.Name = "branchIDCbb";
            this.branchIDCbb.Size = new System.Drawing.Size(570, 31);
            this.branchIDCbb.TabIndex = 1;
            // 
            // tableLayoutPanel50
            // 
            tableLayoutPanel50.ColumnCount = 3;
            tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel50.Controls.Add(label41, 0, 0);
            tableLayoutPanel50.Controls.Add(this.updateTypeCbb, 1, 0);
            tableLayoutPanel50.Controls.Add(this.increaseAmountNumeric, 2, 0);
            tableLayoutPanel50.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel50.Location = new System.Drawing.Point(3, 237);
            tableLayoutPanel50.Name = "tableLayoutPanel50";
            tableLayoutPanel50.RowCount = 1;
            tableLayoutPanel50.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel50.Size = new System.Drawing.Size(719, 72);
            tableLayoutPanel50.TabIndex = 5;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label41.Location = new System.Drawing.Point(3, 0);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(80, 23);
            label41.TabIndex = 0;
            label41.Text = "Cập nhật";
            // 
            // updateTypeCbb
            // 
            this.updateTypeCbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTypeCbb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateTypeCbb.FormattingEnabled = true;
            this.updateTypeCbb.Items.AddRange(new object[] {
            "Tăng số lượng",
            "Giảm số lượng"});
            this.updateTypeCbb.Location = new System.Drawing.Point(146, 3);
            this.updateTypeCbb.Name = "updateTypeCbb";
            this.updateTypeCbb.Size = new System.Drawing.Size(281, 31);
            this.updateTypeCbb.TabIndex = 3;
            // 
            // increaseAmountNumeric
            // 
            this.increaseAmountNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.increaseAmountNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.increaseAmountNumeric.Location = new System.Drawing.Point(433, 3);
            this.increaseAmountNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.increaseAmountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.increaseAmountNumeric.Name = "increaseAmountNumeric";
            this.increaseAmountNumeric.Size = new System.Drawing.Size(283, 30);
            this.increaseAmountNumeric.TabIndex = 4;
            this.increaseAmountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel51
            // 
            tableLayoutPanel51.ColumnCount = 2;
            tableLayoutPanel51.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel51.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel51.Controls.Add(label42, 0, 0);
            tableLayoutPanel51.Controls.Add(this.currentAmountTb, 1, 0);
            tableLayoutPanel51.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel51.Location = new System.Drawing.Point(3, 159);
            tableLayoutPanel51.Name = "tableLayoutPanel51";
            tableLayoutPanel51.RowCount = 1;
            tableLayoutPanel51.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel51.Size = new System.Drawing.Size(719, 72);
            tableLayoutPanel51.TabIndex = 6;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label42.Location = new System.Drawing.Point(3, 0);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(121, 46);
            label42.TabIndex = 0;
            label42.Text = "Số lượng hiện tại";
            // 
            // currentAmountTb
            // 
            this.currentAmountTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentAmountTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentAmountTb.Location = new System.Drawing.Point(146, 3);
            this.currentAmountTb.Name = "currentAmountTb";
            this.currentAmountTb.ReadOnly = true;
            this.currentAmountTb.Size = new System.Drawing.Size(570, 30);
            this.currentAmountTb.TabIndex = 1;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label43.Location = new System.Drawing.Point(3, 0);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(114, 23);
            label43.TabIndex = 0;
            label43.Text = "Mã sản phẩm";
            // 
            // tableLayoutPanel48
            // 
            tableLayoutPanel48.ColumnCount = 1;
            tableLayoutPanel48.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel48.Controls.Add(tableLayoutPanel49, 0, 1);
            tableLayoutPanel48.Controls.Add(tableLayoutPanel50, 0, 2);
            tableLayoutPanel48.Controls.Add(tableLayoutPanel51, 0, 2);
            tableLayoutPanel48.Controls.Add(this.confirmButton, 0, 4);
            tableLayoutPanel48.Controls.Add(tableLayoutPanel52, 0, 0);
            tableLayoutPanel48.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel48.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel48.Name = "tableLayoutPanel48";
            tableLayoutPanel48.RowCount = 5;
            tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel48.Size = new System.Drawing.Size(725, 523);
            tableLayoutPanel48.TabIndex = 6;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmButton.AutoSize = true;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Location = new System.Drawing.Point(315, 315);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 33);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // tableLayoutPanel52
            // 
            tableLayoutPanel52.ColumnCount = 2;
            tableLayoutPanel52.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel52.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel52.Controls.Add(label43, 0, 0);
            tableLayoutPanel52.Controls.Add(this.productIdCbb, 1, 0);
            tableLayoutPanel52.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel52.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel52.Name = "tableLayoutPanel52";
            tableLayoutPanel52.RowCount = 1;
            tableLayoutPanel52.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel52.Size = new System.Drawing.Size(719, 72);
            tableLayoutPanel52.TabIndex = 8;
            // 
            // productIdCbb
            // 
            this.productIdCbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productIdCbb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdCbb.FormattingEnabled = true;
            this.productIdCbb.Location = new System.Drawing.Point(146, 3);
            this.productIdCbb.Name = "productIdCbb";
            this.productIdCbb.Size = new System.Drawing.Size(570, 31);
            this.productIdCbb.TabIndex = 1;
            // 
            // UpdateProductAmountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(tableLayoutPanel48);
            this.Name = "UpdateProductAmountControl";
            this.Size = new System.Drawing.Size(725, 523);
            tableLayoutPanel49.ResumeLayout(false);
            tableLayoutPanel49.PerformLayout();
            tableLayoutPanel50.ResumeLayout(false);
            tableLayoutPanel50.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.increaseAmountNumeric)).EndInit();
            tableLayoutPanel51.ResumeLayout(false);
            tableLayoutPanel51.PerformLayout();
            tableLayoutPanel48.ResumeLayout(false);
            tableLayoutPanel48.PerformLayout();
            tableLayoutPanel52.ResumeLayout(false);
            tableLayoutPanel52.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel48;
        private System.Windows.Forms.ComboBox branchIDCbb;
        private System.Windows.Forms.ComboBox updateTypeCbb;
        private System.Windows.Forms.TextBox currentAmountTb;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel52;
        private System.Windows.Forms.ComboBox productIdCbb;
        private System.Windows.Forms.NumericUpDown increaseAmountNumeric;
    }
}
