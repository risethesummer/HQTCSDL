using HQTCSDL_Group01.Components;
using HQTCSDL_Group01.Components.CustomerControl;
using HQTCSDL_Group01.Components.PartnerControls;
using HQTCSDL_Group01.Components.ShipperControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01
{
    public partial class FixVersionForm : Form
    {

        private UserControl currentControl;

        public FixVersionForm()
        {
            InitializeComponent();

            loginControl.OnLogin += (loginInfor) =>
            {
                var currentID = loginInfor.ID;
                if (loginInfor.Type == "DT")
                {
                    currentControl = new PartnerControl(currentID, false);
                    currentFunctionLabel.Text = "Đối tác: " + currentID;
                }
                else if (loginInfor.Type == "KH")
                {
                    currentControl = new CustomerControl(currentID, false);
                    currentFunctionLabel.Text = "Khách hàng: " + currentID;
                }
                else if (loginInfor.Type == "TX")
                {
                    currentControl = new ShipperControl(currentID, false);
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
    }
}
