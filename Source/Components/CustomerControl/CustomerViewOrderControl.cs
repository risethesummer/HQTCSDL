using HQTCSDL_Group01.Components.PartnerControls.OrderControls;
using System;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.CustomerControl
{
    public partial class CustomerViewOrderControl : UserControl
    {
        public CustomerViewOrderControl()
        {
            InitializeComponent();
        }

        public int CurrentID { get; internal set; }

        public TimeSpan CurrentDelay { get; set; }
        public bool Error { get; set; } = false;

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var control in ordersPanel.Controls)
                    (control as OrderControl).Dispose();
                ordersPanel.Controls.Clear();
                ordersPanel.RowCount = 1;

                foreach (var order in DatabaseManager.DBManager.Init.Customer.GetOrders(CurrentID))
                {
                    var orderControl = new OrderControl(order, "Hủy đơn hàng", "Đã hủy", "Đang xử lý");
                    if (order.State != "Đang xử lý")
                        orderControl.CancelButton.Enabled = false;
                    else
                        orderControl.OnCancelOrder += (id) =>
                        {
                            if (Error)
                                return DatabaseManager.DBManager.Init.Customer.CancelOrderError(id, CurrentDelay);
                            return DatabaseManager.DBManager.Init.Customer.CancelOrder(id, CurrentDelay);
                        };
                    orderControl.OnViewProduct += (orderID) =>
                    {
                        productsGridView.Rows.Clear();
                        foreach (var orderDetailed in DatabaseManager.DBManager.Init.Partner.GetProductAmountFromOrder(orderID))
                            productsGridView.Rows.Add(orderDetailed.Product.ID, orderDetailed.Product.Name, orderDetailed.Amount, orderDetailed.Product.Price);
                    };
                    ordersPanel.Controls.Add(orderControl, 0, ordersPanel.RowCount - 1);
                    ordersPanel.RowStyles[ordersPanel.RowCount - 1].SizeType = SizeType.AutoSize;
                    orderControl.Dock = DockStyle.Fill;
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
