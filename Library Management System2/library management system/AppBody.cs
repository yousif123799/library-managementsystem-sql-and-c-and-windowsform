using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace library_management_system
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();





        public AppBody()
        {
            InitializeComponent();
            is_sliding_panel_exbanded = true;
            expandSlidingPanelGui();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            //this.Opacity = 0.1;
            //timer1.Start();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (this.Opacity <= 1.0)
        //    {
        //        this.Opacity += 0.025;
        //    }
        //    else
        //    {
        //        timer1.Stop();
        //    }
        //}

        private void logoff_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        public void expandSlidingPanelGui()
        {
            bookstabbutton.Text = "BOOKS";
            BorrowersTabButton.Text = "BORROWERS";
            TransactionTabButton.Text = "TRANSACTIONS";
            SettingsTabButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";

        }
        public void retarctSlidigGui()
        {
            bookstabbutton.Text = "";
            BorrowersTabButton.Text = "";
            TransactionTabButton.Text = "";
            SettingsTabButton.Text = "";
            AboutTabButton.Text = "";
        }

        // sliding pannel start
        bool is_sliding_panel_exbanded;
        const int MaxSliderWidth=300;
        const int MinSliderWidth=100;


        private void sliding_panel_toggle_Click(object sender, EventArgs e)
        {
            if (is_sliding_panel_exbanded)
            {
                retarctSlidigGui();
            }
            SlidingPanelTimer.Start();
        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (is_sliding_panel_exbanded)
            {
                sliding_panel.Width -= 30;
                if (sliding_panel.Width <= MinSliderWidth)
                {
                    is_sliding_panel_exbanded = false;
                    SlidingPanelTimer.Stop();
                    expandSlidingPanelGui();
                    this.Refresh();
                }

            }
            else
            {
                sliding_panel.Width += 30;
                if (sliding_panel.Width >= MaxSliderWidth)
                {
                    is_sliding_panel_exbanded = true;
                    SlidingPanelTimer.Stop();
                    expandSlidingPanelGui();
                    this.Refresh();
                }
            }
        }

        private void bookstabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(UserBooksControl.Instance))
            {
                ContentPanel.Controls.Add(UserBooksControl.Instance);
                UserBooksControl.Instance.Dock = DockStyle.Fill;
                UserBooksControl.Instance.BringToFront();
            }
            else
            {
                UserBooksControl.Instance.BringToFront();
            }
        }

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(UserBorrowersControl.Instance))
            {
                ContentPanel.Controls.Add(UserBorrowersControl.Instance);
                UserBorrowersControl.Instance.Dock = DockStyle.Fill;
                UserBorrowersControl.Instance.BringToFront();
            }
            else
            {
                UserBorrowersControl.Instance.BringToFront();
            }

        }

        private void TransactionTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(UserTransactionControl.Instance))
            {
                ContentPanel.Controls.Add(UserTransactionControl.Instance);
                UserTransactionControl.Instance.Dock = DockStyle.Fill;
                UserTransactionControl.Instance.BringToFront();
            }
            else
            {
                UserTransactionControl.Instance.BringToFront();
            }
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(UserSettingsControl.Instance))
            {
                ContentPanel.Controls.Add(UserSettingsControl.Instance);
                UserSettingsControl.Instance.Dock = DockStyle.Fill;
                UserSettingsControl.Instance.BringToFront();
            }
            else
            {
                UserSettingsControl.Instance.BringToFront();
            }
        }
    }
}
    
    

