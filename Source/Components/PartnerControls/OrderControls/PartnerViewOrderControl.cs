using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls.OrderControls
{
    public partial class PartnerViewOrderControl : UserControl
    {
        public PartnerViewOrderControl()
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

                foreach (var order in DatabaseManager.DBManager.Init.Partner.GetOrders(CurrentID))
                {
                    var orderControl = new OrderControl(order);
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
