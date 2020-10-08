using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PControlesForm
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            Comp c;
            if (String.IsNullOrEmpty(tt1.Text.ToString()) || String.IsNullOrEmpty(tt3.Text.ToString()) ||
                String.IsNullOrEmpty(tt2.Text.ToString()) || String.IsNullOrEmpty(tt4.Text.ToString()) ||
                String.IsNullOrEmpty(tt5.Text.ToString()) || String.IsNullOrEmpty(tt6.Text.ToString()) )
            {
                MessageBox.Show("Completa todos los datos. ");
            }
            else {
                //Abre siguiente form
                Persona p = new Persona();

                p.nombre = tt1.Text.ToString();
                p.apellidos = tt2.Text.ToString();
                p.telefono = tt3.Text.ToString();
                p.direccion = tt4.Text.ToString();
                p.ciudad = tt5.Text.ToString();
                p.estado = tt6.Text.ToString();
                c = new Comp(p);
                this.Hide();
                c.Show();
            }
        }
    }
}
