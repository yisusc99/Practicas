using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PControlesForm
{
    public partial class Comp : Form
    {
        public String procesador = null, so = null, proc = null, hdd1 = null, hdd2 = null;
        public int caphdd1 = 0, caphdd2 = 0, ramm =  0;
        public String[] adicionales;
        public object adl = null;
        Componentes c = new Componentes();
        Persona P;
        public Comp(Persona p)
        {
            InitializeComponent();
            P = p;
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            if (c2.Checked == true || c3.Checked == true || c4.Checked == true || c5.Checked == true)
            {
                c2.Checked = false;
                c3.Checked = false;
                c4.Checked = false;
                c5.Checked = false;
            }
            proc = "Intel Core I5 550";
        }

        private void c2_CheckedChanged(object sender, EventArgs e)
        {
            if (c1.Checked == true || c3.Checked == true || c4.Checked == true || c5.Checked == true)
            {
                c1.Checked = false;
                c3.Checked = false;
                c4.Checked = false;
                c5.Checked = false;
            }
            proc = "Intel Core i9 i7 - 970";
        }

        private void So_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (So.SelectedIndex != 0)
                so = So.Text.ToString();
            else
                so = null;
        }

        private void d1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (d1.SelectedIndex != 0)
                hdd1 = d1.Text.ToString();
            else
                hdd1 = null;
        }

        private void c3_CheckedChanged(object sender, EventArgs e)
        {
            if (c2.Checked == true || c1.Checked == true || c4.Checked == true || c5.Checked == true)
            {
                c2.Checked = false;
                c1.Checked = false;
                c4.Checked = false;
                c5.Checked = false;
            }
            proc = "Intel Core i7 i7-600";
        }

        private void cap1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cap1.SelectedIndex != 0)
                caphdd1 = Convert.ToInt32(cap1.Text.ToString());
            else
                caphdd1 = 0;

        }

        private void d2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (d2.SelectedIndex != 0)
                hdd2 = d2.Text.ToString();
            else
                hdd2 = null;
        }

        private void cap2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cap2.SelectedIndex != 0)
                caphdd2 = Convert.ToInt32(cap2.Text.ToString());
            else
                caphdd2 = 0;
        }

        private void c4_CheckedChanged(object sender, EventArgs e)
        {
            if (c2.Checked == true || c3.Checked == true || c1.Checked == true || c5.Checked == true)
            {
                c2.Checked = false;
                c3.Checked = false;
                c1.Checked = false;
                c5.Checked = false;
            }
            proc = "AMD Ryzen 9";
        }

        private void c5_CheckedChanged(object sender, EventArgs e)
        {
            if (c2.Checked == true || c3.Checked == true || c4.Checked == true || c1.Checked == true)
            {
                c2.Checked = false;
                c3.Checked = false;
                c4.Checked = false;
                c1.Checked = false;
            }
            proc = "AMD Ryzen 7";
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r2.Checked == true)
            {
                r2.Checked = false;
            }
            d1.Enabled = true;
            cap1.Enabled = true;
            d2.Enabled = false;
            cap2.Enabled = false;
       
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                r1.Checked = false;
            }
            d1.Enabled = true;
            cap1.Enabled = true;
            d2.Enabled = true;
            cap2.Enabled = true;
    
        }

        private void Comp_Load(object sender, EventArgs e)
        {
            Inicio c = new Inicio();
            c.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {


            if (procesador != null && so != null && proc != null && hdd1 != null || hdd2 != null
            && caphdd1 != 0 || caphdd2 != 0 && ramm != 0)
            {
                c.procesador = proc;
                c.so = so;
                c.hdd1 = hdd1;
                c.hdd2 = hdd2;
                c.caphdd1 = caphdd1;
                c.caphdd2 = caphdd2;
                c.ram = ramm;


                //comprobamos si hay algún elemento activado
                if (list.CheckedItems.Count != 0)
                {
                    adicionales = new String[list.CheckedItems.Count];
                    for (int i = 0; i <= list.CheckedItems.Count - 1; i++)
                    {
                        if (adicionales == null)
                        {
                            c.adl = null;
                            break;
                        }
                        else
                        {  
                            adicionales[i]=  list.CheckedItems[i].ToString();
                        }
                    }
                    c.adl = adicionales;
                }
                this.Hide();
                Form3 f = new Form3(P, c);
                f.Show();
                this.Close();

            }
            else {
                MessageBox.Show("Asegurate de completar todos los datos. :)");
            }
                
               
        }

        private void ram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ram.SelectedIndex != 0)
                ramm = Convert.ToInt32(ram.Text.ToString());
            else
                ramm = 0;
        }
    }
}
