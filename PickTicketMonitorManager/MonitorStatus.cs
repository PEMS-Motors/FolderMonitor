using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickTicketHandler {

    public partial class MonitorStatusForm : System.Windows.Forms.Form {

        public FolderScanner Scanner;
        private MonitorManager monitormanager_main;

        public MonitorStatusForm(MonitorManager monitormanager_main, FolderScanner Scanner ) {
            //constructor


            //initialize
            InitializeComponent();

            //center according to MonitorManager's location
            this.CenterToParent();

            //disable resize
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Pass Scanner to this object to work with
            this.Scanner = Scanner;
            this.monitormanager_main = monitormanager_main;

            this.ControlBox = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            //Close button

            //Close this menu and return to Monitor Manager
            this.Close();
        }

        private void MonitorStatusForm_Load(object sender, EventArgs e) {
            if ( monitormanager_main.GetSelectedWatchedFolder() != null ) {
                monitoredpath_container.Text = monitormanager_main.GetSelectedWatchedFolder().ToString();
            } else {
                MessageBox.Show("Error: No item selected. \n\nSelect a filepath above to check its status.", "Error", MessageBoxButtons.OK);
                this.Close();
            }

            errorlog_textcontainer.Text = Scanner.GetLogEntry(monitormanager_main.watchedfolders_container.SelectedItem.ToString());
            errorlog_textcontainer.Refresh();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            //"Save Log..."

            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter = "Text File|*.txt";
            savedialog.Title = "Save Log as .txt File";
            savedialog.ShowDialog();

            List<string> output_text = new List<string>();
            string s = errorlog_textcontainer.Text;            

            if (savedialog.FileName != "") {
                
                while(s.Contains("\n") ) {
                    output_text.Add(s.Substring(0, s.IndexOf("\n")));
                    s = s.Substring(s.IndexOf("\n"));
                }

                output_text.Add(s);

                System.IO.File.WriteAllLines(savedialog.FileName, output_text.ToArray());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

            errorlog_textcontainer.Refresh();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }
    }
}
