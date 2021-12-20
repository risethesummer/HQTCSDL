using System;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class AddProductControl : UserControl
    {
        public AddProductControl()
        {
            InitializeComponent();
        }

        public int CurrentID { get; internal set; }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTb.Text)
                || String.IsNullOrWhiteSpace(descriptionTb.Text))
            {
                MessageBox.Show("Các thông tin không được để trống!");
                return;
            }

            if (DatabaseManager.DBManager.Init.Partner.AddProduct(new DatabaseManager.Product(nameTb.Text, descriptionTb.Text, (long)priceNumeric.Value), CurrentID))
                MessageBox.Show("Tạo sản phẩm thành công!");
            else
                MessageBox.Show("Lỗi! Không thể tạo sản phẩm!");
        }
    }
}
