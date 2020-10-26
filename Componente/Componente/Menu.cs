using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcion_menu;
namespace Componente
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void close_Click(object sender, EventArgs e)
        {

            WindowFunctions.Wclose(this.ParentForm);
        }

        private void maxiwindow_Click(object sender, EventArgs e)
        {
            WindowFunctions.WidthState(this.ParentForm);
        }

        private void minwindow_Click(object sender, EventArgs e)
        {
            WindowFunctions.HideWindow(this.ParentForm);
        }
    }
}
