using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class DeleteProductControl : UserControl
    {
        public DeleteProductControl()
        {
            InitializeComponent();
            idCbb.DropDown += (sender, e) =>
            {
                try
                {
                    idCbb.Items.Clear();
                    foreach (var id in DatabaseManager.DBManager.Init.Partner.GetProductIDs(CurrentID))
                        idCbb.Items.Add(id);
                }
                catch (Exception exception)
                {

                }
                
            };

            idCbb.SelectionChangeCommitted += (sender, e) =>
            {
                try
                {
                    var id = (int)idCbb.SelectedItem;
                    var product = DatabaseManager.DBManager.Init.Partner.GetProduct(id);
                    nameTb.Text = product.Name;
                    descriptionTb.Text = product.Description;
                    priceTb.Text = product.Price.ToString();
                }
                catch (Exception exception)
                {

                }
            };
        }

        public int CurrentID { get; internal set; }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)idCbb.SelectedItem;
                if (DatabaseManager.DBManager.Init.Partner.DeleteProduct(id))
                    MessageBox.Show("Xóa sản phẩm thành công!");
                else
                    MessageBox.Show("Xóa sản phẩm không thành công! Hãy kiểm tra lại các thông tin!");
            }
            catch (Exception exception)
            {

            }
        }
    }
}
