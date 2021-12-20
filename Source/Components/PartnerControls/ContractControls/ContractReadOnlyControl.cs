using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls.ContractControls
{
    public partial class ContractReadOnlyControl : UserControl
    {
        private int id = -1;

        public event Action<int> OnViewBranch;

        public ContractReadOnlyControl(DatabaseManager.Contract contract)
        {
            InitializeComponent();
            this.id = contract.ID;
            contractIDTb.Text = contract.ID.ToString();
            contractTaxTb.Text = contract.Tax;
            contractRepTb.Text = contract.Representation;
            contractDatesTb.Text = contract.StartDate.ToShortDateString() + " - " + contract.EndDate.ToShortDateString();

        }

        private void ViewBranchButton_Click(object sender, EventArgs e)
        {
            OnViewBranch?.Invoke(id);
        }
    }
}
