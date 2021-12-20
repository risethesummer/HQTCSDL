
namespace HQTCSDL_Group01.Components.PartnerControls
{
    partial class ViewContractControl
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label labrl;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
            System.Windows.Forms.Label label27;
            this.contractsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.branchGridView = new System.Windows.Forms.DataGridView();
            this.branchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewButton = new System.Windows.Forms.Button();
            tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labrl = new System.Windows.Forms.Label();
            tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            label27 = new System.Windows.Forms.Label();
            tableLayoutPanel27.SuspendLayout();
            tableLayoutPanel31.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel27
            // 
            tableLayoutPanel27.ColumnCount = 1;
            tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel27.Controls.Add(tableLayoutPanel31, 0, 1);
            tableLayoutPanel27.Controls.Add(tableLayoutPanel32, 0, 2);
            tableLayoutPanel27.Controls.Add(this.viewButton, 0, 0);
            tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel27.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.RowCount = 3;
            tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel27.Size = new System.Drawing.Size(824, 598);
            tableLayoutPanel27.TabIndex = 3;
            // 
            // tableLayoutPanel31
            // 
            tableLayoutPanel31.ColumnCount = 1;
            tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel31.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel31.Controls.Add(this.contractsPanel, 0, 1);
            tableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel31.Location = new System.Drawing.Point(3, 62);
            tableLayoutPanel31.Name = "tableLayoutPanel31";
            tableLayoutPanel31.RowCount = 2;
            tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            tableLayoutPanel31.Size = new System.Drawing.Size(818, 352);
            tableLayoutPanel31.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(labrl, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(812, 29);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(651, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(125, 23);
            label5.TabIndex = 5;
            label5.Text = "Xem chi nhánh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(448, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 23);
            label4.TabIndex = 4;
            label4.Text = "Thời gian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(286, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 23);
            label3.TabIndex = 3;
            label3.Text = "Người đại diên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(124, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 23);
            label2.TabIndex = 2;
            label2.Text = "Mã số thuế";
            // 
            // labrl
            // 
            labrl.AutoSize = true;
            labrl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labrl.Location = new System.Drawing.Point(3, 0);
            labrl.Name = "labrl";
            labrl.Size = new System.Drawing.Size(114, 23);
            labrl.TabIndex = 1;
            labrl.Text = "Mã hợp đồng";
            // 
            // contractsPanel
            // 
            this.contractsPanel.AutoScroll = true;
            this.contractsPanel.ColumnCount = 1;
            this.contractsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contractsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsPanel.Location = new System.Drawing.Point(3, 38);
            this.contractsPanel.Name = "contractsPanel";
            this.contractsPanel.RowCount = 1;
            this.contractsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contractsPanel.Size = new System.Drawing.Size(812, 311);
            this.contractsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel32
            // 
            tableLayoutPanel32.ColumnCount = 1;
            tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel32.Controls.Add(label27, 0, 0);
            tableLayoutPanel32.Controls.Add(this.branchGridView, 0, 1);
            tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel32.Location = new System.Drawing.Point(3, 420);
            tableLayoutPanel32.Name = "tableLayoutPanel32";
            tableLayoutPanel32.RowCount = 2;
            tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel32.Size = new System.Drawing.Size(818, 175);
            tableLayoutPanel32.TabIndex = 8;
            // 
            // label27
            // 
            label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label27.Location = new System.Drawing.Point(349, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(119, 23);
            label27.TabIndex = 0;
            label27.Text = "Các chi nhánh";
            // 
            // branchGridView
            // 
            this.branchGridView.AllowUserToAddRows = false;
            this.branchGridView.AllowUserToDeleteRows = false;
            this.branchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branchID,
            this.branchName,
            this.branchAddress});
            this.branchGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchGridView.Location = new System.Drawing.Point(3, 38);
            this.branchGridView.Name = "branchGridView";
            this.branchGridView.ReadOnly = true;
            this.branchGridView.RowHeadersWidth = 51;
            this.branchGridView.RowTemplate.Height = 29;
            this.branchGridView.Size = new System.Drawing.Size(812, 134);
            this.branchGridView.TabIndex = 1;
            // 
            // branchID
            // 
            this.branchID.HeaderText = "Mã chi nhánh";
            this.branchID.MinimumWidth = 6;
            this.branchID.Name = "branchID";
            this.branchID.ReadOnly = true;
            // 
            // branchName
            // 
            this.branchName.HeaderText = "Tên chi nhánh";
            this.branchName.MinimumWidth = 6;
            this.branchName.Name = "branchName";
            this.branchName.ReadOnly = true;
            // 
            // branchAddress
            // 
            this.branchAddress.HeaderText = "Địa chỉ chi nhánh";
            this.branchAddress.MinimumWidth = 6;
            this.branchAddress.Name = "branchAddress";
            this.branchAddress.ReadOnly = true;
            // 
            // viewButton
            // 
            this.viewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.viewButton.AutoSize = true;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewButton.Location = new System.Drawing.Point(330, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(164, 53);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "Xem các hợp đồng";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ViewContractControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(tableLayoutPanel27);
            this.Name = "ViewContractControl";
            this.Size = new System.Drawing.Size(824, 598);
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel27.PerformLayout();
            tableLayoutPanel31.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel32.ResumeLayout(false);
            tableLayoutPanel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.DataGridView branchGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel contractsPanel;
        private System.Windows.Forms.Button viewButton;
    }
}
