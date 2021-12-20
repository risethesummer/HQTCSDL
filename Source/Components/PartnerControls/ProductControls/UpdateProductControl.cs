using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class UpdateProductControl : UserControl
    {
        public int CurrentID { get; internal set; }
      

        public UpdateProductControl()
        {
            InitializeComponent();

            idCbb.DropDown += (sender, o) =>
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
                    oldNameTb.Text = product.Name;
                    oldDescriptionTb.Text = product.Description;
                    oldPriceTb.Text = product.Price.ToString();
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
                var id = (int)idCbb.SelectedItem;
                if (DatabaseManager.DBManager.Init.Partner.UpdateProduct(new DatabaseManager.Product(id, updateNameTb.Text, updateDescriptionTb.Text, (int)updatePriceNumeric.Value)))
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                else
                    MessageBox.Show("Cập nhật sản phẩm không thành công! Hãy kiểm tra lại các thông tin!");
            }
            catch (Exception exception)
            {

            }
        }
    }
}
