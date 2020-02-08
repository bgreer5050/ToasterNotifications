using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Notification
{
    public partial class Form1 : Form
    {
        System.Threading.Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            timer = new System.Threading.Timer(PopUp, null, 1000, 5000);
            
        }

        private void PopUp(object state)
        {

            this.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info;

                //popup.OptionsMenu.Dock = DockStyle.Top;

                //popup.BodyColor = Color.Yellow;
                popup.ContentColor = Color.Black;
                popup.TitleText = "Sales Stats";
                popup.TitleColor = Color.Red;
                popup.ContentText = $"Sales Count: 33 /n Sales Calls: 7";
                
                popup.Popup();
            });
        }
    }
}
