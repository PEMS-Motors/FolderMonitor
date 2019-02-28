using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickTicketMonitorManager
{
    public partial class MonitorHelp : Form
    {
        public MonitorHelp()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
