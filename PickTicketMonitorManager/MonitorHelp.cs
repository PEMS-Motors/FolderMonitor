using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickTicketMonitorManager {

    public partial class MonitorHelp : Form {

        System.Windows.Forms.Timer auto_close_timer;

        public MonitorHelp() {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void MonitorHelp_Load(object sender, EventArgs e) {
            auto_close_timer = new System.Windows.Forms.Timer();
            auto_close_timer.Tick += new EventHandler(auto_close_timer_Expired);
            auto_close_timer.Interval = 850;
            auto_close_timer.Start();
        }

        private void auto_close_timer_Expired(object sender, EventArgs e) {
            this.Close();
        }
    }
}
