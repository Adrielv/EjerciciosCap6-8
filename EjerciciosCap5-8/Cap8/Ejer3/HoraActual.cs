using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap8Ejer5
{
    public partial class HoraActual : Form
    {
        public HoraActual()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToString("hh:mm tt yyyy/dd/MM");

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
