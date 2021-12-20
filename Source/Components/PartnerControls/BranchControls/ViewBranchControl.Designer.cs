
namespace HQTCSDL_Group01.Components
{
    partial class ViewBranchControl
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
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.viewButton = new System.Windows.Forms.Button();
            this.branchGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.viewButton, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.branchGridView, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(491, 425);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // viewButton
            // 
            this.viewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewButton.Location = new System.Drawing.Point(3, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(485, 36);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "Xem danh sách các chi nhánh";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // branchGridView
            // 
            this.branchGridView.AllowUserToAddRows = false;
            this.branchGridView.AllowUserToDeleteRows = false;
            this.branchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchGridView.Location = new System.Drawing.Point(3, 45);
            this.branchGridView.Name = "branchGridView";
            this.branchGridView.RowHeadersWidth = 51;
            this.branchGridView.RowTemplate.Height = 29;
            this.branchGridView.Size = new System.Drawing.Size(485, 377);
            this.branchGridView.TabIndex = 1;
            // 
            // ViewBranchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel16);
            this.Name = "ViewBranchControl";
            this.Size = new System.Drawing.Size(491, 425);
            this.tableLayoutPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView branchGridView;
    }
}
