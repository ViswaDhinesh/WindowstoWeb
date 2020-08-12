using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace WindowstoWeb
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnSiginIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text.Trim() == "")
                    System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/?tab=wm#inbox");
                else
                    System.Diagnostics.Process.Start("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                string Url = ConfigurationSettings.AppSettings.Get("SiteUrl").ToString().Trim() + txtPath.Text.Trim();
                System.Diagnostics.Process.Start(Url);



                //System.Diagnostics.Process.Start("http://google.com");
                //System.Diagnostics.Process.Start("browser\path.exe", "\"? searchterm\"");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDynamicBrowser_Click(object sender, EventArgs e)
        {
            try
            {

                //if (cmbBrowser.SelectedItem.ToString() == "Chrome")
                //    Browser = "CHROME.EXE";
                //else 
                // CHROME, IEXPLORE

                string Browser = "CHROME.EXE";
                if (cmbBrowser.SelectedItem == null || cmbBrowser.SelectedItem.ToString() == "Chrome")
                    Browser = "CHROME.EXE";
                else if (cmbBrowser.SelectedItem.ToString() == "Mozilla")
                    Browser = "FIREFOX.EXE";
                else if (cmbBrowser.SelectedItem.ToString() == "IE")
                    Browser = "IEXPLORE.EXE";
                else if (cmbBrowser.SelectedItem.ToString() == "MicrosoftEdge")
                    Browser = "MicrosoftEdge.exe";

                string targetURL = @"http://google.com";
                targetURL = txtPath.Text.Trim();
                ProcessStartInfo psi = new ProcessStartInfo(Browser);
                psi.WindowStyle = ProcessWindowStyle.Maximized;
                psi.Arguments = targetURL;
                Process.Start(psi);
            }
            catch (Exception ex)
            {

            }
        }

        private void DashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                FileExplorer Ex = new FileExplorer();
                Ex.ShowDialog();
            }
        }
    }
}