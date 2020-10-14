using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        private int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            if (num != 25)
            {
                num++;
                numero.Text = num.ToString();
            }
            else {
                MessageBox.Show("Ya llegaste al limite de numeros generados.");
            }

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (num != 25)
            {
                numero.Text = "";
            }
            else
            {
                MessageBox.Show("Ya llegaste al limite de numeros generados.");
            }
        }
    }
}
