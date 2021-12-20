using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class PartnerControl : UserControl, IDelay
    {
        public PartnerControl(int id, bool error)
        {
            InitializeComponent();
            extendContractControl.CurrentID = id;
            extendContractControl.Error = error;

            viewContractControl.CurrentID = id;
            addProductControl.CurrentID = id;
            deleteProductControl.CurrentID = id;
            updateProductControl.CurrentID = id;

            updateProductAmountControl.CurrentID = id;
            updateProductAmountControl.Error = error;

            partnerViewOrderControl.CurrentID = id;

            partnerStatisticsControl.CurrentID = id;
            partnerStatisticsControl.Error = error;
        }

        public void SetDelay(TimeSpan delay)
        {
            extendContractControl.CurrentDelay = delay;
            updateProductAmountControl.CurrentDelay = delay;
            partnerStatisticsControl.CurrentDelay = delay;
        }
    }
}
