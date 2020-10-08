using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1, n2, resultado;

        string operacion;
        bool bandera = false;
        public Form1()
        {
            InitializeComponent();
        }
        private double Operacion(string operacion) {
            double resultado = 0;
            switch (operacion) {
                case "suma":
                    resultado = n1 + n2;
                   break;
                case "resta":
                    resultado = n1 - n2;
                    break;
                case "div":
                    resultado = n1 / n2;
                    break;
                case "mult":
                    resultado = n1 * n2;
                    break;
            }
            return resultado;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "1";
            bandera = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "2";
            bandera = true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "3";
            bandera = true;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "4";
            bandera = true;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "5";
            bandera = true;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "6";
            bandera = true;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "7";
            bandera = true;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "8";
            bandera = true;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "9";
            bandera = true;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text + "0";
            bandera = true;
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            if (TB.Text != "" && bandera)
            {
                n2 = Convert.ToInt32(TB.Text);
                TB.Text = Operacion(operacion).ToString();
            }
        }

        private void bmas_Click(object sender, EventArgs e)
        {
            
            if (bandera)
            {
                n1 = Convert.ToDouble(TB.Text);
                TB.Text = "";
                operacion = "suma";
            }
        }

        private void bmens_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                n1 = Convert.ToDouble(TB.Text);
                TB.Text = "";
                operacion = "resta";
            }
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                n1 = Convert.ToDouble(TB.Text);
                TB.Text = "";
                operacion = "div";
            }
        }

        private void limpiar(object sender, EventArgs e)
        {
            TB.Text = "";
            n1 = 0.0;
            n2 = 0.0;
            resultado = 0.0;
            bandera = false;
        }

        private void bpor_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                n1 = Convert.ToDouble(TB.Text);
                TB.Text = "";
                operacion = "mult";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
