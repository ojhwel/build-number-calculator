using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildNumberCalculator
{
    /// <summary>
    /// Calculates a build number based on the time of day.
    /// </summary>
    public partial class BuildNumberForm : Form
    {
        public BuildNumberForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// "Open" context menu item shows the form.
        /// </summary>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        /// <summary>
        /// "Quit" context menu itenm closes the application.
        /// </summary>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Closing the form merely hides it and leaves the notify icon intact.
        /// </summary>
        private void BuildNumberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Place the form in the bottom right corner of the primary screen (which is where the taskbar tray is).
        /// </summary>
        private void BuildNumberForm_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
            Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10;
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Double-clicking the notify icon opens the form, or at least calculates a new build number.
        /// </summary>
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                ShowWindow();
            else
                Calculate();
        }

        /// <summary>
        /// Checking the "From yesterday" checkbox calculates the time starting at midnight yesterday, to allow finishing builds after midnight and still 
        /// getting a larger number than at 23:59. This only works until shortly after 4 am, when the number exceeds the maxmimum possible build number of 
        /// 65534. Maybe go to bed?
        /// </summary>
        private void YesterdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        /// <summary>
        /// Shows the build number, or "toolate" if the number would exceed 65534.
        /// </summary>
        private void Calculate()
        {
            DateTime now = DateTime.Now;
            int seconds = (int)((now.Hour * 3600 + now.Minute * 60 + now.Second) / 1.54);
            if (yesterdayCheckBox.Checked)
                seconds += 3600 * 24;
            timeLabel.Text = now.ToString("HH:mm:ss");
            if (seconds <= 65534)
                buildNumberLabel.Text = seconds.ToString("#00000");
            else
                buildNumberLabel.Text = "toolate";
        }

        /// <summary>
        /// Shows the windows and calculates a new build number.
        /// </summary>
        private void ShowWindow()
        {
            WindowState = FormWindowState.Normal;
            Calculate();
        }

        /// <summary>
        /// Clicking the time calculates a new build number (useful if the window is still open).
        /// </summary>
        private void TimeLabel_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        /// <summary>
        /// Clicking the build number copies it to the clipboard.
        /// </summary>
        private void BuildNumberLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buildNumberLabel.Text);
        }
    }
}
