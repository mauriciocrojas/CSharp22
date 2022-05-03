using System;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MenuPrincipal frmMenuPrin = new MenuPrincipal();

                frmMenuPrin.Show();
                this.Hide();
            }
            else
            {

            }
        }

    }
}
