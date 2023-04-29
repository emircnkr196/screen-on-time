using System.Net.Sockets;
using System.Windows.Forms;

namespace ScreenOnTime
{
    public partial class Form1 : Form
    {
        public int ScreenTimeSeconds = 0;
        public string ScreenTime;
        public string isACPlugged;
        public int nowPercent = 0;
        public int lastPercent = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // start AC Plug and measuring 
            ACPlugControl.Start();

            // notify screen-on-time
            Notify.Start();
            NotifyIcon.Icon = SystemIcons.Application;
        }

        // AC Plug and measuring timer
        private void ACPlugControl_Tick(object sender, EventArgs e)
        {
            // check if it's running on battery
            Boolean isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline);

            // measuring
            if (isRunningOnBattery == true)
            {
                // while on battery
                isACPlugged = "Running on Battery";
                ScreenTimeSeconds++;
                if (ScreenTimeSeconds > 3600)
                {
                    ScreenTime = (ScreenTimeSeconds / 3600).ToString() + " hour(s) and " + ((ScreenTimeSeconds % 3600) / 60).ToString() + "minute(s) past from %" + lastPercent + ".";
                }
                else if (ScreenTimeSeconds < 3600 && ScreenTimeSeconds >= 60)
                {
                    ScreenTime = ((ScreenTimeSeconds % 3600) / 60).ToString() + " minute(s) past from %" + lastPercent + ".";
                }
                else if (ScreenTimeSeconds < 60)
                {
                    ScreenTime = "Please wait a minute.";
                }
            }
            else
            {
                // while ac plugged
                ScreenTimeSeconds = 0;
                isACPlugged = "AC Plugged";
                ScreenTime = "Measuring disabled";

                lastPercent = nowPercent;
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
                lastPercent = nowPercent;
            }

            // reporting info as notify icon text
            NotifyIcon.Text = "Battery percent: " + nowPercent + "\n" + ScreenTime;

            // reporting info as notify icon text
            label2.Text = NotifyIcon.Text;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // deactivate controlbox exit button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

    }
}