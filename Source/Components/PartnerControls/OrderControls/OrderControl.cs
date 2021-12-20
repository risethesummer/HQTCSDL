using System;
using System.Windows.Forms;
using HQTCSDL_Group01.DatabaseManager.DTOs;

namespace HQTCSDL_Group01.Components.PartnerControls.OrderControls
{
    public partial class OrderControl : UserControl
    {
        private int orderID;
        public event System.Action<int> OnViewProduct;

        public event System.Func<int, bool> OnCancelOrder;

        private string afterString = String.Empty;

        public Button CancelButton { get; private set; }
        public OrderControl(Order order)
        {
            InitializeComponent();
            this.orderID = order.OrderID;
            this.orderIDTb.Text = order.OrderID.ToString();
            this.branchIDTb.Text = order.BranchID.ToString();
            this.customerIDTb.Text = order.CustomerID.ToString();
            this.shipperIDTb.Text = order.ShipperID == -1 ? "Chưa có tài xế" : order.ShipperID.ToString();
            this.shippingMethodTb.Text = order.ShippingMethod;
            this.addressTb.Text = order.Address;
            this.orderStateTb.Text = order.State;
            this.productPriceTb.Text = order.ProductPrice.ToString();
            this.shippingPriceTb.Text = order.ShippingPrice.ToString();
        }

        public OrderControl(Order order, string text, string after, string condition) : this (order)
        {
            try
            {
                CancelButton = new Button()
                {
                    Text = text,
                    AutoSize = true,
                    //Can only cancel validating orders
                    Enabled = orderStateTb.Text == condition
                };
                afterString = after;
                var cloneStyle = new ColumnStyle(SizeType.Percent);
                panel.ColumnStyles.Add(cloneStyle);
                panel.Controls.Add(CancelButton, panel.ColumnCount, 0);
                CancelButton.Dock = DockStyle.Top;

                for (int i = 0; i <= 3; i++)
                    panel.ColumnStyles[i].Width = 5;
                panel.ColumnStyles[4].Width = 10;
                panel.ColumnStyles[5].Width = 20;
                for (int i = 6; i <= 10; i++)
                    panel.ColumnStyles[i].Width = 10;

                CancelButton.Click += (s, o) =>
                {
                    try
                    {
                        if ((bool)OnCancelOrder?.Invoke(orderID))
                        {
                            CancelButton.Enabled = false;
                            orderStateTb.Text = this.afterString;
                            MessageBox.Show("Thao tác thành công!");
                        }
                        else
                            MessageBox.Show("Thao tác thất bại! Xin vui lòng xem lại thông tin!");

                    }
                    catch (Exception)
                    {

                    }
                };
            }
            catch (Exception)
            {

            }
        }


        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            OnViewProduct?.Invoke(orderID);
        }
    }
}
