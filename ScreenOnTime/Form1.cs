using System.Net.Sockets;
using System.Windows.Forms;

namespace ScreenOnTime
{
    public partial class Form1 : Form
    {
        // code-specific variables
        public string ScreenTime = "";
        public int nowPercent = 0;

        // variables as settings
        public bool isRunning = Properties.Settings.Default.IsRunning;
        public int ScreenTimeSeconds = Properties.Settings.Default.ScreenTimeSeconds;
        public int lastPercent = Properties.Settings.Default.LastPercent;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // start AC Plug and calculating 
            ACPlugControl.Start();

            // pause trigger
            Pause.Start();

            // notify screen-on-time
            Notify.Start();
        }

        // AC Plug and measuring timer
        private void ACPlugControl_Tick(object sender, EventArgs e)
        {
            // check if it's running on battery
            Boolean isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline);

            // calculating
            if (isRunningOnBattery == true)
            {
                // while on battery
                // check calculating is running
                if (Properties.Settings.Default.IsRunning == true) // continue
                {
                    ScreenTimeSeconds++;

                    Properties.Settings.Default.ScreenTimeSeconds = ScreenTimeSeconds;
                    SaveProcess();

                    ScreenTime = (ScreenTimeSeconds / 3600).ToString("00") + ":" + ((ScreenTimeSeconds % 3600) / 60).ToString("00") + " from " + lastPercent + "% to " + nowPercent + "%";
                }
                else // pause
                {
                    ScreenTime = "Calculating disabled";
                }
            }
            else // while ac plugged
            {
                ScreenTimeSeconds = 0;

                Properties.Settings.Default.ScreenTimeSeconds = ScreenTimeSeconds;
                Properties.Settings.Default.LastPercent = nowPercent;
                SaveProcess();

                ScreenTime = "Calculating disabled due to charging";
            }
        }

        private void Notify_Tick(object sender, EventArgs e)
        {
            // battery percent
            float batteryPercent = (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent);
            int battery = (int)(batteryPercent * 100);
            nowPercent = battery;

            if (lastPercent == 0)
            {
                Properties.Settings.Default.LastPercent = nowPercent;
                SaveProcess();
            }

            // reporting info as notify icon text
            NotifyIcon.Text = ScreenTime;

            // reporting info as notify icon text
            label2.Text = NotifyIcon.Text;
        }

        // pause trigger
        private void Pause_Tick(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                pauseButton.Text = "Resume";
            }
            else
            {
                pauseButton.Text = "Pause";
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsRunning == false)
            {
                Properties.Settings.Default.IsRunning = true;
                SaveProcess();
            }
            else
            {
                Properties.Settings.Default.IsRunning = false;
                Properties.Settings.Default.ScreenTimeSeconds = ScreenTimeSeconds;
                SaveProcess();
            }
        }

        // interface clicks
        private void hideButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ScreenTimeSeconds = 0;
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            Show();
        }

        // extra function to avoid repeating saving functions
        private void SaveProcess()
        {
            Properties.Settings.Default.Save();
        }
    }
}