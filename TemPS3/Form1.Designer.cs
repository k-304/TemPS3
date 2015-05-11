namespace TemPS3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_ps3ip = new System.Windows.Forms.Label();
            this.TB_ip = new System.Windows.Forms.TextBox();
            this.B_connect = new System.Windows.Forms.Button();
            this.L_intro = new System.Windows.Forms.Label();
            this.L_version = new System.Windows.Forms.Label();
            this.L_gputemp_show = new System.Windows.Forms.Label();
            this.L_cputemp_show = new System.Windows.Forms.Label();
            this.L_refresh = new System.Windows.Forms.Label();
            this.TB_refresh = new System.Windows.Forms.TextBox();
            this.B_set = new System.Windows.Forms.Button();
            this.L_status = new System.Windows.Forms.Label();
            this.L_status_show = new System.Windows.Forms.Label();
            this.L_createdby = new System.Windows.Forms.Label();
            this.L_type_show = new System.Windows.Forms.Label();
            this.B_bug = new System.Windows.Forms.Button();
            this.B_disconnect = new System.Windows.Forms.Button();
            this.B_update = new System.Windows.Forms.Button();
            this.L_cputemp = new System.Windows.Forms.Label();
            this.L_gputemp = new System.Windows.Forms.Label();
            this.L_firmware = new System.Windows.Forms.Label();
            this.L_firmware_show = new System.Windows.Forms.Label();
            this.B_shutdown = new System.Windows.Forms.Button();
            this.BW_connect = new System.ComponentModel.BackgroundWorker();
            this.BW_psdata = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // L_ps3ip
            // 
            this.L_ps3ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_ps3ip.BackColor = System.Drawing.Color.Transparent;
            this.L_ps3ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ps3ip.ForeColor = System.Drawing.Color.Black;
            this.L_ps3ip.Location = new System.Drawing.Point(60, 51);
            this.L_ps3ip.Name = "L_ps3ip";
            this.L_ps3ip.Size = new System.Drawing.Size(118, 17);
            this.L_ps3ip.TabIndex = 0;
            this.L_ps3ip.Text = "PS3 IP-Addess:";
            this.L_ps3ip.Click += new System.EventHandler(this.L_ps3ip_Click);
            // 
            // TB_ip
            // 
            this.TB_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_ip.BackColor = System.Drawing.Color.White;
            this.TB_ip.ForeColor = System.Drawing.Color.Black;
            this.TB_ip.Location = new System.Drawing.Point(184, 51);
            this.TB_ip.Name = "TB_ip";
            this.TB_ip.Size = new System.Drawing.Size(138, 20);
            this.TB_ip.TabIndex = 1;
            this.TB_ip.Text = "192.168.";
            this.TB_ip.TextChanged += new System.EventHandler(this.TB_ip_TextChanged);
            // 
            // B_connect
            // 
            this.B_connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_connect.BackColor = System.Drawing.Color.Gainsboro;
            this.B_connect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_connect.ForeColor = System.Drawing.Color.Black;
            this.B_connect.Location = new System.Drawing.Point(60, 77);
            this.B_connect.Name = "B_connect";
            this.B_connect.Size = new System.Drawing.Size(124, 31);
            this.B_connect.TabIndex = 2;
            this.B_connect.Text = "Connect";
            this.B_connect.UseVisualStyleBackColor = false;
            this.B_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // L_intro
            // 
            this.L_intro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_intro.BackColor = System.Drawing.Color.Transparent;
            this.L_intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_intro.ForeColor = System.Drawing.Color.Black;
            this.L_intro.Location = new System.Drawing.Point(60, 9);
            this.L_intro.Name = "L_intro";
            this.L_intro.Size = new System.Drawing.Size(262, 31);
            this.L_intro.TabIndex = 3;
            this.L_intro.Text = "PS3 Monitoring";
            this.L_intro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_intro.Click += new System.EventHandler(this.L_intro_Click);
            // 
            // L_version
            // 
            this.L_version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_version.BackColor = System.Drawing.Color.Transparent;
            this.L_version.ForeColor = System.Drawing.Color.Black;
            this.L_version.Location = new System.Drawing.Point(57, 419);
            this.L_version.Name = "L_version";
            this.L_version.Padding = new System.Windows.Forms.Padding(2);
            this.L_version.Size = new System.Drawing.Size(124, 17);
            this.L_version.TabIndex = 5;
            this.L_version.Text = "Version:  0.2";
            this.L_version.Click += new System.EventHandler(this.L_version_Click);
            // 
            // L_gputemp_show
            // 
            this.L_gputemp_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_gputemp_show.BackColor = System.Drawing.Color.Transparent;
            this.L_gputemp_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_gputemp_show.ForeColor = System.Drawing.Color.Black;
            this.L_gputemp_show.Location = new System.Drawing.Point(184, 190);
            this.L_gputemp_show.Name = "L_gputemp_show";
            this.L_gputemp_show.Size = new System.Drawing.Size(138, 17);
            this.L_gputemp_show.TabIndex = 10;
            this.L_gputemp_show.Click += new System.EventHandler(this.L_gputemp_show_Click);
            // 
            // L_cputemp_show
            // 
            this.L_cputemp_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_cputemp_show.BackColor = System.Drawing.Color.Transparent;
            this.L_cputemp_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_cputemp_show.ForeColor = System.Drawing.Color.Black;
            this.L_cputemp_show.Location = new System.Drawing.Point(184, 160);
            this.L_cputemp_show.Name = "L_cputemp_show";
            this.L_cputemp_show.Size = new System.Drawing.Size(138, 17);
            this.L_cputemp_show.TabIndex = 9;
            this.L_cputemp_show.Click += new System.EventHandler(this.L_cputemp_show_Click);
            // 
            // L_refresh
            // 
            this.L_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_refresh.BackColor = System.Drawing.Color.Transparent;
            this.L_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_refresh.ForeColor = System.Drawing.Color.Black;
            this.L_refresh.Location = new System.Drawing.Point(57, 252);
            this.L_refresh.Name = "L_refresh";
            this.L_refresh.Size = new System.Drawing.Size(107, 53);
            this.L_refresh.TabIndex = 12;
            this.L_refresh.Text = "Refresh value:\r\n(in Seconds)\r\n";
            this.L_refresh.Click += new System.EventHandler(this.L_refresh_Click);
            // 
            // TB_refresh
            // 
            this.TB_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_refresh.BackColor = System.Drawing.Color.White;
            this.TB_refresh.ForeColor = System.Drawing.Color.Black;
            this.TB_refresh.Location = new System.Drawing.Point(184, 252);
            this.TB_refresh.Name = "TB_refresh";
            this.TB_refresh.Size = new System.Drawing.Size(138, 20);
            this.TB_refresh.TabIndex = 13;
            this.TB_refresh.TextChanged += new System.EventHandler(this.TB_refresh_TextChanged);
            // 
            // B_set
            // 
            this.B_set.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_set.BackColor = System.Drawing.Color.Gainsboro;
            this.B_set.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_set.ForeColor = System.Drawing.Color.Black;
            this.B_set.Location = new System.Drawing.Point(184, 278);
            this.B_set.Name = "B_set";
            this.B_set.Size = new System.Drawing.Size(138, 27);
            this.B_set.TabIndex = 14;
            this.B_set.Text = "Set";
            this.B_set.UseVisualStyleBackColor = false;
            this.B_set.Click += new System.EventHandler(this.B_set_Click);
            // 
            // L_status
            // 
            this.L_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_status.BackColor = System.Drawing.Color.Transparent;
            this.L_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_status.ForeColor = System.Drawing.Color.Black;
            this.L_status.Location = new System.Drawing.Point(57, 123);
            this.L_status.Name = "L_status";
            this.L_status.Size = new System.Drawing.Size(107, 17);
            this.L_status.TabIndex = 15;
            this.L_status.Text = "Status:";
            this.L_status.Click += new System.EventHandler(this.L_status_Click);
            // 
            // L_status_show
            // 
            this.L_status_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_status_show.BackColor = System.Drawing.Color.Transparent;
            this.L_status_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_status_show.ForeColor = System.Drawing.Color.Black;
            this.L_status_show.Location = new System.Drawing.Point(184, 123);
            this.L_status_show.Name = "L_status_show";
            this.L_status_show.Size = new System.Drawing.Size(138, 17);
            this.L_status_show.TabIndex = 16;
            this.L_status_show.Click += new System.EventHandler(this.L_status_show_Click);
            // 
            // L_createdby
            // 
            this.L_createdby.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_createdby.BackColor = System.Drawing.Color.Transparent;
            this.L_createdby.ForeColor = System.Drawing.Color.Black;
            this.L_createdby.Location = new System.Drawing.Point(195, 419);
            this.L_createdby.Name = "L_createdby";
            this.L_createdby.Padding = new System.Windows.Forms.Padding(2);
            this.L_createdby.Size = new System.Drawing.Size(127, 17);
            this.L_createdby.TabIndex = 17;
            this.L_createdby.Text = "TemPS3 by SnipeLike";
            this.L_createdby.Click += new System.EventHandler(this.L_createdby_Click);
            // 
            // L_type_show
            // 
            this.L_type_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_type_show.BackColor = System.Drawing.Color.Transparent;
            this.L_type_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_type_show.ForeColor = System.Drawing.Color.Black;
            this.L_type_show.Location = new System.Drawing.Point(253, 220);
            this.L_type_show.Name = "L_type_show";
            this.L_type_show.Size = new System.Drawing.Size(69, 17);
            this.L_type_show.TabIndex = 18;
            this.L_type_show.Click += new System.EventHandler(this.L_type_show_Click);
            // 
            // B_bug
            // 
            this.B_bug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_bug.BackColor = System.Drawing.Color.Gainsboro;
            this.B_bug.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_bug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_bug.ForeColor = System.Drawing.Color.Black;
            this.B_bug.Location = new System.Drawing.Point(60, 386);
            this.B_bug.Name = "B_bug";
            this.B_bug.Size = new System.Drawing.Size(124, 30);
            this.B_bug.TabIndex = 19;
            this.B_bug.Text = "Bug / Help";
            this.B_bug.UseVisualStyleBackColor = false;
            this.B_bug.Click += new System.EventHandler(this.B_bug_Click);
            // 
            // B_disconnect
            // 
            this.B_disconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_disconnect.BackColor = System.Drawing.Color.Gainsboro;
            this.B_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_disconnect.ForeColor = System.Drawing.Color.Black;
            this.B_disconnect.Location = new System.Drawing.Point(198, 77);
            this.B_disconnect.Name = "B_disconnect";
            this.B_disconnect.Size = new System.Drawing.Size(124, 31);
            this.B_disconnect.TabIndex = 20;
            this.B_disconnect.Text = "Disconnect";
            this.B_disconnect.UseVisualStyleBackColor = false;
            this.B_disconnect.Click += new System.EventHandler(this.B_disconnect_Click);
            // 
            // B_update
            // 
            this.B_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_update.BackColor = System.Drawing.Color.Gainsboro;
            this.B_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_update.ForeColor = System.Drawing.Color.Black;
            this.B_update.Location = new System.Drawing.Point(198, 386);
            this.B_update.Name = "B_update";
            this.B_update.Size = new System.Drawing.Size(124, 30);
            this.B_update.TabIndex = 21;
            this.B_update.Text = "Update Tool\r\n";
            this.B_update.UseVisualStyleBackColor = false;
            this.B_update.Click += new System.EventHandler(this.B_update_Click);
            // 
            // L_cputemp
            // 
            this.L_cputemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_cputemp.BackColor = System.Drawing.Color.Transparent;
            this.L_cputemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_cputemp.ForeColor = System.Drawing.Color.Black;
            this.L_cputemp.Location = new System.Drawing.Point(57, 160);
            this.L_cputemp.Name = "L_cputemp";
            this.L_cputemp.Size = new System.Drawing.Size(107, 17);
            this.L_cputemp.TabIndex = 6;
            this.L_cputemp.Text = "Cell Temp:";
            this.L_cputemp.Click += new System.EventHandler(this.L_cputemp_Click);
            // 
            // L_gputemp
            // 
            this.L_gputemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_gputemp.BackColor = System.Drawing.Color.Transparent;
            this.L_gputemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_gputemp.ForeColor = System.Drawing.Color.Black;
            this.L_gputemp.Location = new System.Drawing.Point(57, 190);
            this.L_gputemp.Name = "L_gputemp";
            this.L_gputemp.Size = new System.Drawing.Size(107, 17);
            this.L_gputemp.TabIndex = 7;
            this.L_gputemp.Text = "RSX Temp:";
            this.L_gputemp.Click += new System.EventHandler(this.L_gputemp_Click);
            // 
            // L_firmware
            // 
            this.L_firmware.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_firmware.BackColor = System.Drawing.Color.Transparent;
            this.L_firmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_firmware.ForeColor = System.Drawing.Color.Black;
            this.L_firmware.Location = new System.Drawing.Point(57, 220);
            this.L_firmware.Name = "L_firmware";
            this.L_firmware.Size = new System.Drawing.Size(107, 17);
            this.L_firmware.TabIndex = 8;
            this.L_firmware.Text = "CFW Version:\r\n";
            this.L_firmware.Click += new System.EventHandler(this.L_firmware_Click);
            // 
            // L_firmware_show
            // 
            this.L_firmware_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_firmware_show.BackColor = System.Drawing.Color.Transparent;
            this.L_firmware_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_firmware_show.ForeColor = System.Drawing.Color.Black;
            this.L_firmware_show.Location = new System.Drawing.Point(184, 220);
            this.L_firmware_show.Name = "L_firmware_show";
            this.L_firmware_show.Size = new System.Drawing.Size(63, 17);
            this.L_firmware_show.TabIndex = 11;
            this.L_firmware_show.Click += new System.EventHandler(this.L_firmware_show_Click);
            // 
            // B_shutdown
            // 
            this.B_shutdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_shutdown.BackColor = System.Drawing.Color.Gainsboro;
            this.B_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_shutdown.ForeColor = System.Drawing.Color.Black;
            this.B_shutdown.Location = new System.Drawing.Point(60, 331);
            this.B_shutdown.Name = "B_shutdown";
            this.B_shutdown.Size = new System.Drawing.Size(262, 30);
            this.B_shutdown.TabIndex = 22;
            this.B_shutdown.Text = "PS3 Shutdown";
            this.B_shutdown.UseVisualStyleBackColor = false;
            this.B_shutdown.Click += new System.EventHandler(this.B_Shutdown_Click);
            // 
            // BW_connect
            // 
            this.BW_connect.WorkerReportsProgress = true;
            this.BW_connect.WorkerSupportsCancellation = true;
            this.BW_connect.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_connect_ProgressChanged);
            this.BW_connect.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_connect_RunWorkerCompleted);
            // 
            // BW_psdata
            // 
            this.BW_psdata.WorkerReportsProgress = true;
            this.BW_psdata.WorkerSupportsCancellation = true;
            this.BW_psdata.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_psdata_DoWork);
            this.BW_psdata.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_psdata_ProgressChanged);
            this.BW_psdata.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_psdata_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 445);
            this.Controls.Add(this.B_shutdown);
            this.Controls.Add(this.B_update);
            this.Controls.Add(this.B_disconnect);
            this.Controls.Add(this.B_bug);
            this.Controls.Add(this.L_type_show);
            this.Controls.Add(this.L_createdby);
            this.Controls.Add(this.L_status_show);
            this.Controls.Add(this.L_status);
            this.Controls.Add(this.B_set);
            this.Controls.Add(this.TB_refresh);
            this.Controls.Add(this.L_refresh);
            this.Controls.Add(this.L_firmware_show);
            this.Controls.Add(this.L_gputemp_show);
            this.Controls.Add(this.L_cputemp_show);
            this.Controls.Add(this.L_firmware);
            this.Controls.Add(this.L_gputemp);
            this.Controls.Add(this.L_cputemp);
            this.Controls.Add(this.L_version);
            this.Controls.Add(this.L_intro);
            this.Controls.Add(this.B_connect);
            this.Controls.Add(this.TB_ip);
            this.Controls.Add(this.L_ps3ip);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "TemPS3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_ps3ip;
        private System.Windows.Forms.TextBox TB_ip;
        private System.Windows.Forms.Button B_connect;
        private System.Windows.Forms.Label L_intro;
        private System.Windows.Forms.Label L_version;
        private System.Windows.Forms.Label L_gputemp_show;
        private System.Windows.Forms.Label L_cputemp_show;
        private System.Windows.Forms.Label L_refresh;
        private System.Windows.Forms.TextBox TB_refresh;
        private System.Windows.Forms.Button B_set;
        private System.Windows.Forms.Label L_status;
        private System.Windows.Forms.Label L_status_show;
        private System.Windows.Forms.Label L_createdby;
        private System.Windows.Forms.Label L_type_show;
        private System.Windows.Forms.Button B_bug;
        private System.Windows.Forms.Button B_disconnect;
        private System.Windows.Forms.Button B_update;
        private System.Windows.Forms.Label L_cputemp;
        private System.Windows.Forms.Label L_gputemp;
        private System.Windows.Forms.Label L_firmware;
        private System.Windows.Forms.Label L_firmware_show;
        private System.Windows.Forms.Button B_shutdown;
        private System.ComponentModel.BackgroundWorker BW_connect;
        private System.ComponentModel.BackgroundWorker BW_psdata;
    }
}

