using HQTCSDL_Group01.DatabaseManager;
using HQTCSDL_Group01.DatabaseManager.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.CustomerControl
{
    public partial class CreateOrderControl : UserControl
    {
        public int CurrentID { get; internal set; }

        public bool Error { get; set; } = false;
        public TimeSpan CurrentDelay { get; set; }

        public CreateOrderControl()
        {
            InitializeComponent();
            partnerIDCbb.DropDown += (s, o) =>
            {
                try
                {
                    partnerIDCbb.Items.Clear();
                    foreach (var id in DatabaseManager.DBManager.Init.Partner.GetPartnerIDs())
                        partnerIDCbb.Items.Add(id);
                }
                catch (Exception exception)
                {

                }

            };

            partnerIDCbb.SelectionChangeCommitted += (s, o) =>
            {
                try
                {
                    var name = DatabaseManager.DBManager.Init.Partner.GetPartnerName((int)partnerIDCbb.SelectedItem);
                    partnerNameTb.Text = name;
                    branchIDCbb.SelectedItem = null;
                }
                catch (Exception exception)
                {

                }
            };


            branchIDCbb.DropDown += (s, o) =>
            {
                try
                {
                    branchIDCbb.Items.Clear();
                    var partnerID = partnerIDCbb.SelectedItem;
                    if (partnerID == null)
                    {
                        MessageBox.Show("Hãy chọn đối tác muốn đặt hàng!");
                        return;
                    }
                    foreach (var branchID in DatabaseManager.DBManager.Init.Partner.GetBranchIDs((int)partnerID))
                        branchIDCbb.Items.Add(branchID);
                }
                catch (Exception exception)
                {

                }
            };

            branchIDCbb.SelectionChangeCommitted += (s, o) =>
            {
                try
                {
                    var address = DatabaseManager.DBManager.Init.Partner.GetBranchAddress((int)branchIDCbb.SelectedItem);
                    branchAddressTb.Text = address;
                    foreach (Control control in productAmountPanel.Controls)
                        control.Dispose();
                    productAmountPanel.Controls.Clear();
                    productAmountPanel.RowCount = 1;
                }
                catch (Exception exception)
                {

                }
            };
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (branchIDCbb.SelectedItem == null || partnerIDCbb.SelectedItem == null
                || methodCbb == null || String.IsNullOrWhiteSpace(addressTb.Text))
                {
                    MessageBox.Show("Các trường thông tin không được để trống! Xin vui lòng xem lại!");
                    return;
                }

                List<ProductAmount> products = new List<ProductAmount>();
                foreach (ProductAmountDeleteControl control in productAmountPanel.Controls)
                {
                    int id = control.ID;
                    if (id != -1)
                        products.Add(new ProductAmount(new DatabaseManager.Product(id, "", "", 0), control.Amount));
                }

                if (products.Count == 0)
                {
                    MessageBox.Show("Phải có ít nhất 1 sản phẩm trong hóa đơn! Xin vui lòng xem lại!");
                    return;
                }

                var order = new OrderWithProducts(products, 0, (int)branchIDCbb.SelectedItem, CurrentID, 0, methodCbb.SelectedItem.ToString(), addressTb.Text, "", 0, 20000);
                var fine = Error ? DBManager.Init.Customer.CreateOrderError(order, products, CurrentDelay)
                    : DBManager.Init.Customer.CreateOrder(order, products, CurrentDelay);
                if (fine)
                    MessageBox.Show("Tạo hóa đơn thành công!");
                else
                    MessageBox.Show("Tạo hóa đơn thất bại!");
            }
            catch (Exception exception)
            {

            }

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var productControl = new ProductAmountDeleteControl(productAmountPanel.RowCount - 1);
                productControl.OnDelete += (index) =>
                {
                    try
                    {
                        var control = productAmountPanel.Controls[index];
                        productAmountPanel.Controls.RemoveAt(index);
                        control.Dispose();
                    }
                    catch (Exception exception)
                    {

                    }
                };
                productControl.OnGetProductIDs += GetProductIDs;
                productControl.OnGetProduct += DatabaseManager.DBManager.Init.Partner.GetProduct;
                productAmountPanel.RowStyles.Add(new RowStyle() { SizeType = SizeType.AutoSize });
                productAmountPanel.Controls.Add(productControl, 0, productAmountPanel.RowCount - 1);
                productControl.Dock = DockStyle.Fill;
                productAmountPanel.RowCount++;
            }
            catch (Exception exception)
            {

            }
        }

        private IEnumerable<int> GetProductIDs()
        {
            if (branchIDCbb.SelectedItem == null)
            {
                MessageBox.Show("Bạn cần chọn chi nhánh");
                yield break;
            }
            foreach (var id in DatabaseManager.DBManager.Init.Customer.GetProductIDs((int)branchIDCbb.SelectedItem))
            {
                bool find = false;
                foreach (ProductAmountDeleteControl control in productAmountPanel.Controls)
                {
                    if (control.ID == id)
                    {
                        find = true;
                        break;
                    }
                }
                if (!find)
                    yield return id;
            }
        }
    }
}
