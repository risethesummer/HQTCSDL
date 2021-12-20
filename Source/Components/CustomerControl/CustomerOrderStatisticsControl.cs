using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.CustomerControl
{
    public partial class CustomerOrderStatisticsControl : UserControl
    {

        public CustomerOrderStatisticsControl()
        {
            InitializeComponent();
        }

        public int CurrentID { get; internal set; }

        public bool Error { get; set; } = false;

        public TimeSpan CurrentDelay { get; set; }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            var statistics = Error ? DatabaseManager.DBManager.Init.Customer.GetStatisticsError(CurrentID, CurrentDelay) : DatabaseManager.DBManager.Init.Customer.GetStatistics(CurrentID, CurrentDelay);
            if (statistics != null)
            {
                totalOrderTb.Text = statistics.Total.Order.ToString();
                totalPriceTb.Text = statistics.Total.Price.ToString();
                totalShippingTb.Text = statistics.Total.Shipping.ToString();

                shippingOrderTb.Text = statistics.Shipping.Order.ToString();
                shippingPriceTb.Text = statistics.Shipping.Price.ToString();
                shippingShippingTb.Text = statistics.Shipping.Shipping.ToString();

                doneOrderTb.Text = statistics.Done.Order.ToString();
                donePriceTb.Text = statistics.Done.Price.ToString();
                doneShippingTb.Text = statistics.Done.Shipping.ToString();

            }
            else
                MessageBox.Show("Không có dữ liệu về khách hàng!");
        }
    }
}
