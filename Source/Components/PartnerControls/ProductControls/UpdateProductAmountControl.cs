using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class UpdateProductAmountControl : UserControl
    {

        public int CurrentID { get; internal set; }

        public bool Error { get; set; } = false;

        public TimeSpan CurrentDelay { get; set; }

        public UpdateProductAmountControl()
        {
            InitializeComponent();
            productIdCbb.DropDown += (sender, o) =>
            {

                try
                {
                    productIdCbb.Items.Clear();
                    foreach (var id in DatabaseManager.DBManager.Init.Partner.GetProductIDs(CurrentID))
                        productIdCbb.Items.Add(id);
                }
                catch (Exception exception)
                {

                }

            };
            productIdCbb.SelectionChangeCommitted += UpdateCurrentAmount;

            branchIDCbb.DropDown += (sender, o) =>
            {
                try
                {
                    branchIDCbb.Items.Clear();
                    foreach (var id in DatabaseManager.DBManager.Init.Partner.GetBranchIDs(CurrentID))
                        branchIDCbb.Items.Add(id);
                }
                catch (Exception exception)
                {

                }
            };
            branchIDCbb.SelectionChangeCommitted += UpdateCurrentAmount;
        }

        private void UpdateCurrentAmount(object sender, EventArgs args)
        {
            try
            {
                //Nothing was chosen
                if (productIdCbb.SelectedItem == null || branchIDCbb.SelectedItem == null)
                    return;
                currentAmountTb.Text = DatabaseManager.DBManager.Init.Partner.GetProductAmount((int)productIdCbb.SelectedItem, (int)branchIDCbb.SelectedItem).ToString();
            } 
            catch (Exception exception)
            {

            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (productIdCbb.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (branchIDCbb.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh!");
                return;
            }

            if (updateTypeCbb.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hình thức cập nhật");
                return;
            }

            int currentAmount = int.Parse(currentAmountTb.Text);
            if (updateTypeCbb.SelectedIndex == 0)
                currentAmount += (int)increaseAmountNumeric.Value;
            else
                currentAmount -= (int)increaseAmountNumeric.Value;

            if (currentAmount < 0)
            {
                MessageBox.Show("Hình thức và số lượng cập nhật hiện tại sẽ làm số lượng sản phẩm bị âm. Xin vui lòng xem lại các thông tin!");
                return;
            }

            int different = updateTypeCbb.SelectedIndex == 0 ? (int)increaseAmountNumeric.Value : -(int)increaseAmountNumeric.Value;

            var fine = Error ?
                DatabaseManager.DBManager.Init.Partner.UpdateProductAmountError((int)productIdCbb.SelectedItem, (int)branchIDCbb.SelectedItem, different, CurrentDelay)
                : DatabaseManager.DBManager.Init.Partner.UpdateProductAmount((int)productIdCbb.SelectedItem, (int)branchIDCbb.SelectedItem, different, CurrentDelay);
            if (fine)
            {
                MessageBox.Show("Cập nhật thành công!");
                UpdateCurrentAmount(null, null);
            }
            else
                MessageBox.Show("Cập nhật thất bại! Xin vui lòng xem lại các thông tin!");
        }
    }
}
