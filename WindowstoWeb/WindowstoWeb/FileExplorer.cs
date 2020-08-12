using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowstoWeb
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                //@"c:\"
                System.Diagnostics.Process.Start(txtPath.Text.Trim());
            }
            catch (Exception ex)
            {

            }
        }
    }
}


// Check the browser open an exist or want to open new. if exists, open new tab else open new browser.

////using SHDocVw;
////using System;
////using System.Collections;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.Data;
////using System.Diagnostics;
////using System.Drawing;
////using System.Linq;
////using System.Runtime.InteropServices;
////using System.Text;
////using System.Threading.Tasks;
////using System.Windows.Forms;

////namespace WindowstoWeb
////{
////    public partial class Form1 : Form
////    {
////        [DllImport("user32.dll")]
////        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
////        private const int WM_SYSCOMMAND = 0x0112;
////        private const int SC_MAXIMIZE = 0xF030;
////        public Form1()
////        {
////            InitializeComponent();
////        }


////        private void button1_Click(object sender, EventArgs e)
////        {
////            string targetURL = @"http://localhost/search/imagesearch.aspx?id=30871755&did=1";

////            ShellWindows iExplorerInstances = new ShellWindows();

////            if (iExplorerInstances.Count > 0)
////            {
////                IEnumerator enumerator = iExplorerInstances.GetEnumerator();
////                enumerator.MoveNext();
////                InternetExplorer iExplorer = (InternetExplorer)enumerator.Current;
////                //SendMessage(new IntPtr(iExplorer.HWND), WM_SYSCOMMAND, SC_MAXIMIZE, 0);
////                iExplorer.Navigate(targetURL, 0x800); //0x800 means new tab
////            }
////            else
////            {
////                ProcessStartInfo psi = new ProcessStartInfo("IEXPLORE.EXE");
////                psi.WindowStyle = ProcessWindowStyle.Maximized;
////                psi.Arguments = targetURL;
////                Process.Start(psi);
////            }

////        }

////    }
////}
