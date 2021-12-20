using System;
using System.Windows.Forms;

namespace HQTCSDL_Group01.Components.PartnerControls
{
    public partial class ExtendContractControl : UserControl
    {
        public int CurrentID { get; internal set; }

        public TimeSpan CurrentDelay { get; set; }

        public bool Error { get; set; } = false;

        public ExtendContractControl()
        {
            InitializeComponent();

            contractIDCbb.DropDown += (o, s) =>
            {
                contractIDCbb.Items.Clear();
                foreach (var id in DatabaseManager.DBManager.Init.Partner.GetContractIDs(CurrentID))
                    contractIDCbb.Items.Add(id);
            };

            contractIDCbb.SelectionChangeCommitted += (o, s) =>
            {
                var id = (int)contractIDCbb.SelectedItem;
                var duration = DatabaseManager.DBManager.Init.Partner.GetContractDuration(id);
                if (duration == -1)
                    durationTb.Text = "Mã hợp đồng không hợp lệ";
                else
                    durationTb.Text = duration + " ngày";
            };
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan()
                                    .Add(TimeSpan.FromDays((double)daysNumeric.Value))
                                    .Add(TimeSpan.FromDays((double)monthsNumeric.Value * 30))
                                    .Add(TimeSpan.FromDays((double)yearsNumeric.Value * 365));
            if (timeSpan.TotalDays == 0)
                MessageBox.Show("Tổng ngày gia hạn phải lớn hơn 0!!!");
            else
            {
                bool fine = Error ?
                    DatabaseManager.DBManager.Init.Partner.ExtendContractError((int)contractIDCbb.SelectedItem, (int)timeSpan.TotalDays, CurrentDelay)
                    : DatabaseManager.DBManager.Init.Partner.ExtendContract((int)contractIDCbb.SelectedItem, (int)timeSpan.TotalDays, CurrentDelay);
                if (fine)
                    MessageBox.Show("Gia hạn hợp đồng thành công!!!");
                else
                    MessageBox.Show("Gia hạn hợp đồng thất bại!!!");
            }
        }
    }
}
