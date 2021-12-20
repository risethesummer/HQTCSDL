using System;
using System.Windows.Forms;

namespace HQTCSDL_Group01
{
    public partial class SelectVersionForm : Form
    {
        public SelectVersionForm()
        {
            InitializeComponent();
        }

        private void errorVersionButton_Click(object sender, EventArgs e)
        {
            new ErrorVersionForm().Visible = true;
        }

        private void fixVersionButton_Click(object sender, EventArgs e)
        {
            new FixVersionForm().Visible = true;
        }
    }
}
