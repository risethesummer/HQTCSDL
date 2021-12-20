using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls.ContractControls
{
    public partial class CreateContractControl : UserControl
    {
        public CreateContractControl()
        {
            InitializeComponent();
            //branchGridView.CellClick += (o, e) =>
            //{
            //    if (e.ColumnIndex == 0)
            //    {
            //        var currentBranch = GetCurrentBranch();
            //        List<string> ids = new List<string>();
            //        //BranchID.Items.Clear();
            //        foreach (var id in DBManager.Init.GetBranchIDs(ErrorVersionForm.CurrentID))
            //            if (!currentBranch.Contains(id))
            //                ids.Add(id.ToString());
            //        BranchID.DataSource = ids;
            //    }

            //};
        }

        private IList<int> GetCurrentBranch()
        {
            IList<int> result = new List<int>();
            foreach (DataGridViewRow row in branchGridView.Rows)
            {
                var val = row.Cells[0].Value;
                if (val != null)
                    result.Add((int)val);
            }
            return result;
        }

        private void AddBranchButton_Click(object sender, EventArgs e)
        {

            branchGridView.Rows.Add();
            
        }
    }
}
