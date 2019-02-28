namespace PickTicketHandler
{
    partial class MonitorStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorlog_textcontainer = new System.Windows.Forms.TextBox();
            this.monitoredpath_container = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(675, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monitoredpath_container);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 38);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitored Path";
            // 
            // errorlog_textcontainer
            // 
            this.errorlog_textcontainer.Location = new System.Drawing.Point(12, 56);
            this.errorlog_textcontainer.Multiline = true;
            this.errorlog_textcontainer.Name = "errorlog_textcontainer";
            this.errorlog_textcontainer.ReadOnly = true;
            this.errorlog_textcontainer.Size = new System.Drawing.Size(739, 372);
            this.errorlog_textcontainer.TabIndex = 28;
            this.errorlog_textcontainer.Text = "This is only a test";
            this.errorlog_textcontainer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monitoredpath_container
            // 
            this.monitoredpath_container.AutoSize = true;
            this.monitoredpath_container.Location = new System.Drawing.Point(6, 16);
            this.monitoredpath_container.Name = "monitoredpath_container";
            this.monitoredpath_container.Size = new System.Drawing.Size(0, 13);
            this.monitoredpath_container.TabIndex = 0;
            this.monitoredpath_container.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // MonitorStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorlog_textcontainer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Name = "MonitorStatusForm";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.MonitorStatusForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox errorlog_textcontainer;
        private System.Windows.Forms.Label monitoredpath_container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}