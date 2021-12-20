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
    public partial class LoginControl : UserControl
    {
        public event System.Action<AccountTypeWithID> OnLogin;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(accountTb.Text)
               || String.IsNullOrWhiteSpace(passwordTb.Text))
            {
                MessageBox.Show("Tài khoản và mặt khẩu không được để trông!");
                return;
            }
            var loginInfor = DBManager.Init.Login(accountTb.Text, passwordTb.Text);
            if (loginInfor == null)
                MessageBox.Show("Đăng nhập thất bại, hãy xem lại các thông tin!");
            else
            {
                OnLogin?.Invoke(loginInfor);
                this.Visible = false;
            }
        }
    }
}
