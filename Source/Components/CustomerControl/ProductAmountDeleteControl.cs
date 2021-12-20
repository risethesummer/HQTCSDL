using HQTCSDL_Group01.DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components
{
    public partial class ProductAmountDeleteControl : UserControl
    {
        private int index;

        public event System.Action<int> OnDelete;

        public event System.Func<IEnumerable<int>> OnGetProductIDs;

        public event System.Func<int, Product> OnGetProduct;

        public int ID => productIDCbb.SelectedItem == null ? -1 : (int)productIDCbb.SelectedItem;

        public int Amount => (int)amountNumeric.Value;

        public ProductAmountDeleteControl(int index)
        {
            InitializeComponent();

            this.index = index;

            deleteButton.Click += (s, e) =>
            {
                OnDelete?.Invoke(this.index);
            };

            productIDCbb.DropDown += (s, e) =>
            {
                try
                {
                    productIDCbb.Items.Clear();
                    foreach (var id in OnGetProductIDs?.Invoke())
                        productIDCbb.Items.Add(id);
                }
                catch (Exception exception)
                {

                }
            };

            productIDCbb.SelectionChangeCommitted += (s, e) =>
            {
                try
                {
                    if (productIDCbb.SelectedItem == null)
                        return;
                    var product = OnGetProduct.Invoke((int)productIDCbb.SelectedItem);
                    productNameTb.Text = product.Name;
                    productPriceTb.Text = product.Price.ToString();
                }
                catch (Exception exception)
                {

                }
            };
        }
    }
}
