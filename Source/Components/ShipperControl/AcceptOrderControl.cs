using HQTCSDL_Group01.Components.PartnerControls.OrderControls;
using System;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.ShipperControl
{
    public partial class AcceptOrderControl : UserControl
    {
        public AcceptOrderControl()
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

                foreach (var order in DatabaseManager.DBManager.Init.Shipper.GetAvailableOrders())
                {
                    var orderControl = new OrderControl(order, "Chấp nhận đơn hàng", "Đang giao", "Đang xử lý");
                    orderControl.OnCancelOrder += (id) =>
                    {
                        if (Error)
                            return DatabaseManager.DBManager.Init.Shipper.AcceptOrderError(id, CurrentID, CurrentDelay);
                        return DatabaseManager.DBManager.Init.Shipper.AcceptOrder(id, CurrentID, CurrentDelay);
                    };
                    orderControl.OnViewProduct += (orderID) =>
                    {
                        productsGridView.Rows.Clear();
                        foreach (var orderDetailed in DatabaseManager.DBManager.Init.Partner.GetProductAmountFromOrder(orderID))
                            productsGridView.Rows.Add(orderDetailed.Product.ID, orderDetailed.Product.Name, orderDetailed.Amount, orderDetailed.Product.Price);
                    };

                    ordersPanel.RowStyles.Add(new RowStyle() { SizeType = SizeType.AutoSize });
                    ordersPanel.Controls.Add(orderControl, 0, ordersPanel.RowCount - 1);
                    orderControl.Dock = DockStyle.Fill;
                    ordersPanel.RowCount++;
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
