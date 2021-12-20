using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class ViewContractControl : UserControl
    {
        public int CurrentID { get; set; }
        public ViewContractControl()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var control in contractsPanel.Controls)
                    (control as ContractControls.ContractReadOnlyControl).Dispose();
                contractsPanel.Controls.Clear();
                contractsPanel.RowCount = 1;

                foreach (var contract in DatabaseManager.DBManager.Init.Partner.GetContracts(CurrentID))
                {
                    var contractControl = new ContractControls.ContractReadOnlyControl(contract);
                    contractControl.OnViewBranch += (contractID) =>
                    {
                        branchGridView.Rows.Clear();
                        foreach (var branch in DatabaseManager.DBManager.Init.Partner.GetBranches(contractID))
                            branchGridView.Rows.Add(branch.ID, branch.Name, branch.Address);
                    };

                    contractsPanel.Controls.Add(contractControl, 0, contractsPanel.RowCount - 1);
                    contractsPanel.RowStyles[contractsPanel.RowCount - 1].SizeType = SizeType.AutoSize;
                    contractControl.Dock = DockStyle.Fill;
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
