using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PControlesForm
{
    public partial class Form3 : Form
    {
        Persona P;
        Componentes C;
        public Form3(Persona p, Componentes c)
        {
            InitializeComponent();
            P = p;
            C = c;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            t1.Text = P.nom();
            t2.Text = P.ape();
            t3.Text = P.tel();
            t4.Text = P.dire();
            t5.Text = P.ciu();
            t6.Text = P.est();
            t7.Text = C.proce();
            t8.Text = C.ra().ToString() + " GB";
            t9.Text = C.s1();
            t10.Text = C.hd1() + ", " + C.hd2();
            t11.Text = C.caphd1().ToString() + ", " + C.caphd2().ToString();

            if (C.adls() != null)
            {
                ad.Text = "";
                for (int i = 0; i < C.adls().Length; i++) { 

                ad.Text += "\n --" + C.adls()[i]; 
                }
            }
            else {
                ad.Text = " ---------------------------------------";
            }
            Comp cc = new Comp(null);
            cc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
