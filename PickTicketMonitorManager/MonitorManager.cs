using PickTicketMonitorManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickTicketHandler {

    public partial class MonitorManager : System.Windows.Forms.Form {

        private int saved_interval;
        private AddMonitorForm ChildForm_Add;
        private MonitorStatusForm ChildForm_Status;
        private System.Windows.Forms.Timer routinetimer;
        private int counter = 0;
        private FolderScanner Scanner;
        private MonitorHelp ChildForm_help;

        public MonitorManager() {

            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Scanner = new FolderScanner(watchedfolders_container);
        }

        private void button3_Click(object sender, EventArgs e) {
            //"Exit" button

            //Closes the program
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            //"Add..." button

            ChildForm_Add = new AddMonitorForm(this, Scanner);
            ChildForm_Add.ShowDialog();
            ChildForm_Add = null;
        }

        private void button2_Click(object sender, EventArgs e) {
            //"Status" button
            
            //Show userform "Monitor Status"
            //Hand it the FolderScanner list for it to use
            if( GetSelectedWatchedFolder() == null ) {

                MessageBox.Show("Error: No item selected. \n\nSelect a filepath above to check its status.", "Error", MessageBoxButtons.OK);

            } else {

                ChildForm_Status = new MonitorStatusForm(this, Scanner);
                ChildForm_Status.ShowDialog();
                ChildForm_Status = null;
            }
        }

        public void AddWatchedFolder(string filepath) {
            //adds "filepath" to the watchedfolders_container

            watchedfolders_container.Items.Add(filepath);
            watchedfolders_container.Refresh();
        }

        private void watchedfolders_container_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void SetTimer() {
            
            if (routinetimer == null) {

                //if timer doesn't already exist, create it
                routinetimer = new System.Windows.Forms.Timer();
                routinetimer.Tick += new EventHandler(routinetimer_Expired);
                routinetimer.Interval = 1000;

                if(saved_interval < 1) {

                    saved_interval = Convert.ToInt32(interval_container.Value);

                }

                counter = saved_interval;
            }           
        }

        private void button5_Click(object sender, EventArgs e) {
            //"Start" / "Stop" button, "toggle_pause_button"

            //toggles whether the timer should count down to execution
            //switches "toggle_pause_button" to display Pause or Resume as its label

            if (toggle_pause_button.Text == "Stop") {

                toggle_pause_button.Text = "Start";
                routinetimer.Stop();

            } else {

                toggle_pause_button.Text = "Stop";

                if(routinetimer == null) {

                    SetTimer();
                }

                //start the timer
                routinetimer_container.Text = counter.ToString();
                routinetimer_container.Refresh();
                routinetimer.Start();
            }
        }

        private void routinetimer_Expired(object sender, EventArgs e) {



            routinetimer_container.Text = Convert.ToString(counter);
            routinetimer_container.Refresh();

            if (counter==0) {
                //perform the scan
                Scanner.ScanAllFolders();

                //reset the counter
                counter = saved_interval + 1;
            }

            counter--;
        }
                
        private void MonitorManager_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            //"Set" button

            //NumericUpDown format returns as decimal, convert it to an int
            int i = Convert.ToInt32(interval_container.Value);

            counter = Convert.ToInt32(interval_container.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void routinetimer_container_Click(object sender, EventArgs e) {

        }

        private void routinetimer_container_TextChanged(object sender, EventArgs e) {

            

        }

        private void button5_Click_1(object sender, EventArgs e) {
            //"Remove..." button

            if(watchedfolders_container.SelectedItem != null) {
                watchedfolders_container.Items.Remove(watchedfolders_container.SelectedItem);
            }
        }

        private void button3_Click_1(object sender, EventArgs e) {
            //"Set" button

            //Force counter to new interval
            saved_interval = Convert.ToInt32(interval_container.Value);
            counter = saved_interval;
            routinetimer_container.Text = counter.ToString();
            routinetimer_container.Refresh();

        }

        public Object GetSelectedWatchedFolder() {

            if(watchedfolders_container.SelectedItem != null) {

                return watchedfolders_container.SelectedItem;

            }

            return null;
        }

        private void button6_Click(object sender, EventArgs e) {
            //"Help" button
            ChildForm_help = new MonitorHelp();
            ChildForm_help.ShowDialog();
            ChildForm_help = null;
        }
    }
}