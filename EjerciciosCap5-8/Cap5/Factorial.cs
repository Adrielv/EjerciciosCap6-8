using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{

    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            float resultado = 1, i;

            float cantidad = float.Parse(CantidadTextBox.Text);

            for (i = 1; i <= cantidad; i++)
            {
                resultado = i * resultado;
            }
            resultadoTextBox.Text=resultado.ToString();
        }

        private void CantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CantidadTextBox.Text)>=1 || CantidadTextBox.Text !="")
            {
                CalcularButton.Enabled = true;
            }
        }
    }
}

