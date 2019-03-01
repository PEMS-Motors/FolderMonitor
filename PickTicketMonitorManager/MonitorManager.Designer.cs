namespace PickTicketHandler
{
    partial class MonitorManager
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
            if (disposing && (components != null)) {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.watchedfolders_container = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggle_pause_button = new System.Windows.Forms.Button();
            this.routinetimer_container = new System.Windows.Forms.Label();
            this.interval_container = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.debugmode_toggle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.interval_container)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(407, 127);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // watchedfolders_container
            // 
            this.watchedfolders_container.FormattingEnabled = true;
            this.watchedfolders_container.HorizontalScrollbar = true;
            this.watchedfolders_container.Items.AddRange(new object[] {
            "C:\\Users\\alan.lovitt\\Desktop\\Workspace\\Pick Ticket Monitor\\TestEnvironment"});
            this.watchedfolders_container.Location = new System.Drawing.Point(12, 12);
            this.watchedfolders_container.Name = "watchedfolders_container";
            this.watchedfolders_container.Size = new System.Drawing.Size(470, 82);
            this.watchedfolders_container.TabIndex = 3;
            this.watchedfolders_container.SelectedIndexChanged += new System.EventHandler(this.watchedfolders_container_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Scan Interval:\r\n(Seconds) ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Next Scan:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggle_pause_button
            // 
            this.toggle_pause_button.Location = new System.Drawing.Point(326, 127);
            this.toggle_pause_button.Name = "toggle_pause_button";
            this.toggle_pause_button.Size = new System.Drawing.Size(75, 23);
            this.toggle_pause_button.TabIndex = 5;
            this.toggle_pause_button.Text = "Start";
            this.toggle_pause_button.UseVisualStyleBackColor = true;
            this.toggle_pause_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // routinetimer_container
            // 
            this.routinetimer_container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.routinetimer_container.AutoSize = true;
            this.routinetimer_container.Cursor = System.Windows.Forms.Cursors.Default;
            this.routinetimer_container.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.routinetimer_container.Location = new System.Drawing.Point(246, 132);
            this.routinetimer_container.Name = "routinetimer_container";
            this.routinetimer_container.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.routinetimer_container.Size = new System.Drawing.Size(13, 13);
            this.routinetimer_container.TabIndex = 30;
            this.routinetimer_container.Text = "0";
            this.routinetimer_container.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.routinetimer_container.TextChanged += new System.EventHandler(this.routinetimer_container_TextChanged);
            this.routinetimer_container.Click += new System.EventHandler(this.routinetimer_container_Click);
            // 
            // interval_container
            // 
            this.interval_container.Cursor = System.Windows.Forms.Cursors.Default;
            this.interval_container.Location = new System.Drawing.Point(247, 101);
            this.interval_container.Maximum = new decimal(new int[] {
            604800,
            0,
            0,
            0});
            this.interval_container.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval_container.Name = "interval_container";
            this.interval_container.Size = new System.Drawing.Size(45, 20);
            this.interval_container.TabIndex = 32;
            this.interval_container.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.interval_container.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Remove...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(407, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Help";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // debugmode_toggle
            // 
            this.debugmode_toggle.AutoSize = true;
            this.debugmode_toggle.Location = new System.Drawing.Point(93, 131);
            this.debugmode_toggle.Name = "debugmode_toggle";
            this.debugmode_toggle.Size = new System.Drawing.Size(58, 17);
            this.debugmode_toggle.TabIndex = 34;
            this.debugmode_toggle.Text = "Debug";
            this.debugmode_toggle.UseVisualStyleBackColor = true;
            this.debugmode_toggle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MonitorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 156);
            this.Controls.Add(this.debugmode_toggle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.interval_container);
            this.Controls.Add(this.routinetimer_container);
            this.Controls.Add(this.toggle_pause_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watchedfolders_container);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MonitorManager";
            this.Text = "Pick Ticket Monitor Manager";
            this.Load += new System.EventHandler(this.MonitorManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interval_container)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toggle_pause_button;
        private System.Windows.Forms.Label routinetimer_container;
        private System.Windows.Forms.NumericUpDown interval_container;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListBox watchedfolders_container;
        private System.Windows.Forms.CheckBox debugmode_toggle;
    }
}

