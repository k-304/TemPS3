/*
 * ▀▀█▀▀ █▀▀ █▀▄▀█ ▒█▀▀█ ▒█▀▀▀█ █▀▀█ █ 
 * ░▒█░░ █▀▀ █░▀░█ ▒█▄▄█ ░▀▀▀▄▄ ░░▀▄ ▀ 
 * ░▒█░░ ▀▀▀ ▀░░░▀ ▒█░░░ ▒█▄▄▄█ █▄▄█ ▄ 
 * by SnipeLike, 12.12.14
 * SourceCode: https://github.com/SnipeLike/TemPS3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PS3Lib;

namespace TemPS3
{
    public partial class Form1 : Form
    {

        /*-----------------*/
        /*----Variables----*/
        /*-----------------*/

        //CCAPI
        private CCAPI PS3 = new CCAPI();

        //PS3 Var's
        private static String psip;
        private static String cputemp;
        private static String gputemp;
        private static String psversion;
        private static String psversiontype;
        private static int refresh_int;
        private static String refresh_string;
        private static int psstatus = 0;

        /*-----------------*/
        /*----Functions----*/
        /*-----------------*/
        public void get_psdata()
        {
            if (psstatus == 1)
            {
                PS3.ClearTargetInfo();

                //Get from PS3
                cputemp = PS3.GetTemperatureCELL();
                gputemp = PS3.GetTemperatureRSX();
                psversion = PS3.GetFirmwareVersion();
                psversiontype = PS3.GetFirmwareType();

                show_psdata();
            }
            else if (psstatus == 0)
            {
                if (L_cputemp_show.InvokeRequired)
                {
                    L_cputemp_show.Invoke((Action)(() => get_psdata()));
                }

                //Set Values to n/a
                L_cputemp_show.Text = "n/a";
                L_gputemp_show.Text = "n/a";
                L_firmware_show.Text = "n/a";
                L_type_show.Text = "n/a";

                //Status "Not Connected"
                stat_notconnected();
            }
            else
            {
                L_status_show.Text = "Error!";
            }
        }

        //Functon to show/refresh Data
        public void show_psdata()
        {
            if (L_cputemp_show.InvokeRequired)
            {
                L_cputemp_show.Invoke((Action)(() => show_psdata()));
            }
            
            //Show Data
            L_cputemp_show.Text = cputemp;
            L_gputemp_show.Text = gputemp;
            L_firmware_show.Text = psversion;
            L_type_show.Text = psversiontype;
        }

        //Function to set refresh delay
        public void refresh_delay()
        {
            MessageBox.Show("Delay set to " + refresh_int + " Seconds!", "Delay set");
            refresh_int = refresh_int * 1000; //Change to Miliseconds
            init_timer();
        }

        //Timer
        public Timer timer1;
        public void init_timer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = refresh_int; // in miliseconds
            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (!BW_psdata.IsBusy)
            {
                //Start Backgroundworker to refresh PS Status
                BW_psdata.RunWorkerAsync();
            }
            get_psdata();
        }

        //Status "Connected!" / "Not Connected!"
        public void stat_connected()
        {
            if (L_status_show.InvokeRequired)
            {
                L_status_show.Invoke((Action)(() => stat_connected()));
            }

            L_status_show.ForeColor = System.Drawing.Color.Green;
            L_status_show.Text = "Connected!";
        }

        public void stat_notconnected()
        {
            if (L_status_show.InvokeRequired)
            {
                L_status_show.Invoke((Action)(() => stat_notconnected()));
            }

            L_status_show.ForeColor = System.Drawing.Color.Red;
            L_status_show.Text = "Not Connected!";
        }

        /*-----------------*/
        /*----Main Code----*/
        /*-----------------*/

        //Form1
        public Form1()
        {
            //Backgroundworker
            InitializeComponent();
            BW_connect.DoWork += new DoWorkEventHandler(BW_connect_DoWork);
            BW_psdata.DoWork += new DoWorkEventHandler(BW_psdata_DoWork);
            
            //Show Version in Titlebar (Update in AssemblyInfo.cs)
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += String.Format(" ({0})", version);

            //Set Values to n/a
            L_cputemp_show.Text = "n/a";
            L_gputemp_show.Text = "n/a";
            L_firmware_show.Text = "n/a";
            L_type_show.Text = "n/a";

            //Set Status to "Not Connected!"
            stat_notconnected();
        }

        //L_intro, Title
        private void L_intro_Click(object sender, EventArgs e)
        {

        }

        //TB_ip, Set IP Textbox
        private void TB_ip_TextChanged(object sender, EventArgs e)
        {
            psip = TB_ip.Text;
        }

        //B_connect, Connect Button
        private void b_connect_Click(object sender, EventArgs e)
        {
            if (psstatus == 0)
            {
                //Status "Connecting..."
                L_status_show.ForeColor = System.Drawing.Color.Orange;
                L_status_show.Text = "Connecting...";

                if (!BW_connect.IsBusy)
                {
                    //Start Backgroundworker to Connect to PS3
                    BW_connect.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Can not connect twice!", "Connection Error");
                }
            }
            else if (psstatus == 1)
            {
                MessageBox.Show("PS3 already Connected!", "Cennection Error");
            }
        }

        //B_disconnect, Disconnect PS3
        private void B_disconnect_Click(object sender, EventArgs e)
        {
            //Check connection & disconnect
            if (psstatus == 1)
            {
                PS3.RingBuzzer(CCAPI.BuzzerMode.Double);
                PS3.DisconnectTarget();

                //Start Backgroundworker to Reset Connection
                BW_psdata.RunWorkerAsync();

                //Show Status
                stat_notconnected();
                MessageBox.Show("Disconnected from " + psip + "!", "Disconnected");
            }
            else
            {
                MessageBox.Show("No PS3 Connected!", "Disconnection Error");
            }
        }

        //L_status, Status Text
        private void L_status_Click(object sender, EventArgs e)
        {
            
        }

        //L_status_show, Shows Connection Status
        private void L_status_show_Click(object sender, EventArgs e)
        {
            
        }

        //L_ps3ip, PS3 IP-Address Text
        private void L_ps3ip_Click(object sender, EventArgs e)
        {

        }

        //L_cputemp, CPU Temp Text
        private void L_cputemp_Click(object sender, EventArgs e)
        {

        }

        //L_cputemp_show, Show CPU Temp in °C
        private void L_cputemp_show_Click(object sender, EventArgs e)
        {
            
        }

        //L_gputemp, GPU Temp Text
        private void L_gputemp_Click(object sender, EventArgs e)
        {

        }

        //L_gputemp_show, Show GPU Temp in °C
        private void L_gputemp_show_Click(object sender, EventArgs e)
        {
            
        }

        //L_firmware, FW Text
        private void L_firmware_Click(object sender, EventArgs e)
        {

        }

        //L_firmware_show, Show PS3 Firmware
        private void L_firmware_show_Click(object sender, EventArgs e)
        {
            
        }

        //L_type_show, Firmware Type (No Text Lable for this)
        private void L_type_show_Click(object sender, EventArgs e)
        {

        }

        //L_refresh, Refresh Temps Text
        private void L_refresh_Click(object sender, EventArgs e)
        {

        }

        //TB_refresh, Set Temp refresh delay
        private void TB_refresh_TextChanged(object sender, EventArgs e)
        {
            
        }

        //B_set, Set Temp refresh delay
        private void B_set_Click(object sender, EventArgs e)
        {
            //Check refresh Value
            refresh_string = TB_refresh.Text;

            //Check empty & Point & Letters
            Regex reg = new Regex((@"a-zA-Z+"));
            if (refresh_string != "" && !refresh_string.Contains(".") /*&& reg.IsMatch(refresh_string)*/)
            {
                //Check minimum
                refresh_int = Convert.ToInt32(TB_refresh.Text);
                if (refresh_int < 1)
                {
                    MessageBox.Show("This is not the value you are looking for! \r (I recommend to set it at least to 1)", "Refresh Error");
                }
                else
                {
                    //Call Function
                    refresh_delay();
                }
            }
            else
            {
                MessageBox.Show("Please set valid refresh value!", "Refresh Error");
            }
        }

        //B_shutdown, PS3 Shutdown
        private void B_Shutdown_Click(object sender, EventArgs e)
        {
            if (psstatus == 1)
            {
                PS3.ShutDown(CCAPI.RebootFlags.ShutDown);
                stat_notconnected();
                MessageBox.Show("PS3 is shutting down!", "Shutdown");
            }
            else
            {
                MessageBox.Show("No PS3 Connected!", "Not Connected");
            }
        }

        //B_update, Check for Updates
        private void B_update_Click(object sender, EventArgs e)
        {
            //Check for Updates
            DialogResult update =  MessageBox.Show("Automatic Update comming soon... \r Check out manually?", "Soon", MessageBoxButtons.YesNo);
            if (update == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://94.247.218.142/project/temps3.html");
            }
        }

        //B_bug, Bug Reporter & Info Button
        private void B_bug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SnipeLike/TemPS3");
        }

        //L_version, Program Version
        private void L_version_Click(object sender, EventArgs e)
        {
            
        }

        //L_createdby, Crated by Text
        private void L_createdby_Click(object sender, EventArgs e)
        {

        }

        /*-----------------*/
        /*-----Workers-----*/
        /*-----------------*/

        //BW_connect, Connect to Console in Background
        private void BW_connect_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker BW_connect = sender as BackgroundWorker;

            //Connect CCAPI to PS3 if Button clicked
            PS3.ConnectTarget(psip);

            //Check Connection
            if (PS3.SUCCESS(PS3.ConnectTarget(psip)))
            {
                //Status "Connected!"
                stat_connected();
                PS3.RingBuzzer(CCAPI.BuzzerMode.Single);

                //Start Backgroundworker to get Data
                BW_psdata.RunWorkerAsync();

                //Show Status
                MessageBox.Show("Connected to: " + psip + "!", "Connected");
            }
            else
            {
                //Status "Not Connected!"
                stat_notconnected();

                //Show Status
                MessageBox.Show("Failed to Connect to: " + psip + "!", "Connection Error");
            }
        }

        //BW_connect
        private void BW_connect_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        //BW_connect
        private void BW_connect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        //BW_psdata, Get Data from PS3
        private void BW_psdata_DoWork(object sender, DoWorkEventArgs e)
        {
            psstatus = PS3.GetConnectionStatus();
            get_psdata();
        }

        //BW_psdata
        private void BW_psdata_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        //BW_psdata
        private void BW_psdata_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
