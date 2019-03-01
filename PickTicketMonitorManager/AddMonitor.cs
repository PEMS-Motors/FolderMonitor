using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickTicketHandler;

namespace PickTicketHandler {
    
    public partial class AddMonitorForm : System.Windows.Forms.Form {

        private MonitorManager monitormanager_main;
        private FolderScanner Scanner;
        
        public AddMonitorForm(MonitorManager monitormanager_main, FolderScanner Scanner) {

            InitializeComponent();
            this.CenterToParent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Scanner = Scanner;
            this.monitormanager_main = monitormanager_main;
            this.ControlBox = false;
        }

        private void AddMonitor_Load(object sender, EventArgs e) {
            
        }

        private void button4_Click(object sender, EventArgs e) {
            //"Cancel" button
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            
            //"Add" button
            string filepath = filepath_container.Text;

            //if filepath_container's value is not empty
            if ( filepath.Length > 0 ) {

                //send the form's contents to the Scanner
                if( Scanner.AddWatchedFolder( filepath ) != true ) {

                    //Scanner failed to add the filepath to the watch list

                } else {
                    //Scanner added the filepath to the watch list correctly, 
                    
                    //return to parent menu
                    this.Close();
                }
            }
        }

        private void filepath_container_TextChanged(object sender, EventArgs e) {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) {

            FolderBrowserDialog browse = new FolderBrowserDialog();

            if(browse.ShowDialog() == DialogResult.OK) {

                filepath_container.Text = browse.SelectedPath;
            }
        }
    }
}
