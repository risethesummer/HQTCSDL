using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.ShipperControl
{
    public partial class ShipperControl : UserControl, IDelay
    {
        public ShipperControl(int id, bool error)
        {
            InitializeComponent();
            acceptOrderControl.CurrentID = id;
            acceptOrderControl.Error = error;

            updateOrderControl.CurrentID = id;
            shipperViewStatisticsControl.CurrentID = id;
            shipperViewStatisticsControl.Error = error;
        }


        public void SetDelay(TimeSpan delay)
        {
            acceptOrderControl.CurrentDelay = delay;
            shipperViewStatisticsControl.CurrentDelay = delay;
        }
    }
}
