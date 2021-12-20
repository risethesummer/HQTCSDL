using HQTCSDL_Group01.Components.PartnerControls.OrderControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.ShipperControl
{
    public partial class UpdateOrderControl : UserControl
    {
        public UpdateOrderControl()
        {
            InitializeComponent();
        }

        public int CurrentID { get; internal set; }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var control in ordersPanel.Controls)
                    (control as OrderControl).Dispose();
                ordersPanel.Controls.Clear();
                ordersPanel.RowCount = 1;

                foreach (var order in DatabaseManager.DBManager.Init.Shipper.GetShippingOrders(CurrentID))
                {
                    var orderControl = new OrderControl(order, "Hoàn tất giao hàng", "Thành công", "Đang giao");
                    orderControl.OnCancelOrder += (id) => DatabaseManager.DBManager.Init.Shipper.UpdateOrder(id);
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
