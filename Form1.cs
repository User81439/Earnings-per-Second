using System;
using System.Windows.Forms;

namespace empty
{
    public partial class Form1 : Form
    {
        readonly Timer Time = new Timer();

        public string test;

        public double worked;
        public double seconds;
        public double time_spent;
        public double rate_hour;
        public double rate_second;

        public Form1()
        {
            InitializeComponent();

            label_count_time.Text = DateTime.Now.ToString();
            Time.Tick += new EventHandler(Timer_Tick);
            Time.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            rate_second = ((rate_hour / 60) / 60);

            time_spent++;

            worked = (time_spent * rate_second);

            label_count_money.Text = worked.ToString("$0.00");

            TimeSpan ts = TimeSpan.FromSeconds(time_spent);

            label_count_time.Text = ts.ToString();
            
        }

        public void Start()
        {
            Time.Interval = 1000;
            label_time_started.Text = DateTime.Now.ToString("HH:mm:ss");

            try
            {
                rate_hour = Convert.ToDouble(textbox_HRR.Text);
            }

            catch
            {
                return;
            }

            time_spent = 0;

            button_break.Visible = true;
            label_count_time.Visible = true;
            label_count_money.Visible = true;
            label_time_started.Visible = true;

            label_status.Text = "Working";
            label_status.ForeColor = System.Drawing.Color.Green;
        }

        int NumberOfClick = 0;
        int NumberOfClicks = 0;

        private void Button_Run_Click(object sender, EventArgs e)
        {
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    Start();
                    button_run.Text = "End";
                    break;
                case 2:
                    Button_End();
                    NumberOfClick = 0;
                    button_break.Visible = false;
                    break;
                default:
                    Start();
                    button_run.Text = "???";
                    break;
            }

        }

        private void Button_End()
        {
            button_run.Text = "Go";

            //stop time_spent++
            Time.Interval = 1000000000;

            label_status.Text = "Not Working";
            label_status.ForeColor = System.Drawing.Color.Red;

            TimeSpan ts = TimeSpan.FromSeconds(time_spent);
            string temp = ts.ToString();

            string message = "You earned " + worked.ToString("$0.00") + " over "+ temp;
            const string caption = "Attention";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);

            label_count_time.Visible = false;
            label_count_money.Visible = false;
            label_time_started.Visible = false;

            label_count_time.Text = "wait";
            label_count_money.Text = "wait";
            label_time_started.Text = "wait";

        }

        private void Button_Break(object sender, EventArgs e)
        {

            ++NumberOfClicks;
            switch (NumberOfClicks)
            {
                case 1:
                    Time.Interval = 1000000000;
                    label_status.Text = "On Break";
                    label_status.ForeColor = System.Drawing.Color.Orange;
                    break;
                case 2:
                    Time.Interval = 1000;
                    label_status.Text = "Working";
                    label_status.ForeColor = System.Drawing.Color.Green;
                    NumberOfClicks = 0;
                    break;
                default:
                    label_status.Text = "Program\nBroke";
                    break;
            }


        }
    }
}
