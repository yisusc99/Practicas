using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracitcaInterfazP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la aplicacion con colorcitos en los botones! :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el rojo :)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el azul :)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el verde :)");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el amarillo :)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el morado :)");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el anaranjado :)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el rosa :)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
