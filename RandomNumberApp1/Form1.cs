using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RandomNumberApp1
{
    public partial class Form1 : Form
    {
        Timer timer;
        bool timer_running;
        bool timer_winner;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            bool ifhe = (this.Height < 768);

            lblWinnerNumber.Top = (this.ClientSize.Height - lblWinnerNumber.Height) / 2 - (ifhe ? 30 : 50);
            lblWinnerNumber.Left = (this.ClientSize.Width - lblWinnerNumber.Width) / 2;

            btnStartStop.Top = this.ClientSize.Height - btnStartStop.Height - (ifhe ? 30 : 50);
            btnStartStop.Left = (this.ClientSize.Width - btnStartStop.Width) / 2;

            btnClose.Top = 30;
            btnClose.Left = this.Width - btnClose.Width - 30;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.WindowState = FormWindowState.Maximized;
            
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
            timer_running = false;
            timer_winner = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            timer.Enabled = false;
            timer.Stop();
        }

        string addleft(string chr, string str, int max)
        {
            while (str.Length < max)
            {
                str = chr + str;
            }
            return str;
        }

        void logWinners()
        {
            using (FileStream fs = new FileStream(Application.StartupPath + "\\" + Application.ProductName + ".Winners.txt", FileMode.Create, FileAccess.Write))
            {
                foreach (string str in lstWinnerNumbers.Items)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(str + "\r\n");
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timer_running)
            {
                Random rnd = new Random();
                int random = rnd.Next(Convert.ToInt32(numBeginNumber.Value), Convert.ToInt32(numEndNumber.Value));
                string strNumber = addleft ("0", random.ToString(), 3);
                lblWinnerNumber.Text = strNumber;
            }
            else
            {
                if (timer_winner)
                {
                    timer_winner = false;
                    bool ok = true;
                    foreach (string item in lstWinnerNumbers.Items)
                    {
                        if (item.Equals(lblWinnerNumber.Text))
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        lstWinnerNumbers.Items.Add(lblWinnerNumber.Text);
                        logWinners();
                    }
                    else
                    {
                        lblWinnerNumber.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            lblWinnerNumber.ForeColor = Color.White;
            timer_running = !timer_running;
            
            if (timer_running)
            {
                btnStartStop.Text = "Stop";
            }
            else
            {
                timer_winner = true;
                btnStartStop.Text = "Start";
            }
        }

        private void lstWinnerNumbers_KeyUp(object sender, KeyEventArgs e)
        {
            if (lstWinnerNumbers.SelectedIndex > -1)
            {
                lstWinnerNumbers.Items.RemoveAt(lstWinnerNumbers.SelectedIndex);
                logWinners();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
