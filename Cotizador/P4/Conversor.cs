using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double dolar;
            if (tmx.Text != "")
            {
                dolar = Convert.ToDouble(tmx.Text);
                td.Text = (dolar / 21.13).ToString();
            }
            else if (td.Text != "" && checkcon.Enabled == true)
            {
                dolar = Convert.ToDouble(td.Text);
                tmx.Text = (dolar * 21.13).ToString();
            }
            else {
                MessageBox.Show("Hay campos obligatorios");
            }
            dolar = 0;
        }

        private void Conversor_Load(object sender, EventArgs e)
        {
            td.Enabled = false;
        }

        private void checkcon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcon.Checked == true) {
                td.Enabled = true;
                tmx.Enabled = false;
                tmx.Text = "";
                td.Text = "";
            }
            else
            {
                td.Enabled = false;
                tmx.Enabled = true;
                td.Text = "";
                tmx.Text = "";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form1 c = new Form1();
            c.Show();
        }
    }
}
