using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txb_ingresoDatos.Text.ToLower();

            if (usuario == "pepe" && this.tbx_pass.Text == "RuFoSo")
            {
                MenuPrincipal frmMenuPrin = new MenuPrincipal(usuario);

                frmMenuPrin.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO");
            }
        }

        private void btn_rellenar_Click(object sender, EventArgs e)
        {
            this.txb_ingresoDatos.Text = "pepe";
            this.tbx_pass.Text = "RuFoSo";
        }
    }
}
