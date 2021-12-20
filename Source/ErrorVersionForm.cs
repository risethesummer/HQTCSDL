using System;
using HQTCSDL_Group01.DatabaseManager;
using System.Windows.Forms;
using HQTCSDL_Group01.Components.PartnerControls;
using HQTCSDL_Group01.Components.CustomerControl;
using HQTCSDL_Group01.Components.ShipperControl;
using HQTCSDL_Group01.Components;

namespace HQTCSDL_Group01
{
    public partial class ErrorVersionForm : Form
    {
        private UserControl currentControl;


        public ErrorVersionForm()
        {
            InitializeComponent();
            loginControl.OnLogin += (loginInfor) =>
            {
                var currentID = loginInfor.ID;
                if (loginInfor.Type == "DT")
                {
                    currentControl = new PartnerControl(currentID, true);
                    currentFunctionLabel.Text = "Đối tác: " + currentID;
                }
                else if (loginInfor.Type == "KH")
                {
                    currentControl = new CustomerControl(currentID, true);
                    currentFunctionLabel.Text = "Khách hàng: " + currentID;
                }
                else if (loginInfor.Type == "TX")
                {
                    currentControl = new ShipperControl(currentID, true);
                    currentFunctionLabel.Text = "Tài xế: " + currentID;
                }
                currentFunctionPanel.Controls.Add(currentControl);
                currentControl.Dock = DockStyle.Fill;
                (currentControl as IDelay).SetDelay(TimeSpan.FromSeconds((double)delayTimeNumeric.Value));
                functionsPanel.Visible = true;
                functionsPanel.BringToFront();
            };

            delayTimeNumeric.ValueChanged += (s, e) =>
            {
                if (currentControl is IDelay delay)
                    delay.SetDelay(TimeSpan.FromSeconds((double)delayTimeNumeric.Value));
            };
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentFunctionPanel.Controls.Remove(currentControl);
                currentControl.Dispose();
                functionsPanel.Visible = false;
                loginControl.Visible = true;
                loginControl.BringToFront();
            }
            catch (Exception)
            {
            }
        }
    }
}