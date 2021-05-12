using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componetes
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
        }

        private void lb_download_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:/Program Files/Cheat Engine 7.2/Cheat Engine");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:/Program Files/Google/Chrome/Application/chrome", "https://youtube.com/cfbcursos");
        }
    }
}
