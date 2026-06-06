using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__1_КИС
{
    public partial class Справка : Form
    {
        public Справка()
        {
            InitializeComponent();
        }

        private void buttonCloseform2(object sender, EventArgs e)
        {
            Close();
        }

        private void gmaillink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://naggets394@gmail.com");
        }
    }
}
