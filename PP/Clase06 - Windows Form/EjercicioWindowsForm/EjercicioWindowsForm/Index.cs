using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForm
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }


        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(this.txb_usuario.Text == "Pepe" && this.txb_clave.Text == "RuFoSo")
            {
                MessageBox.Show("Ingreso exitoso");
                this.BackColor = Color.Green;
            }
            else
            {
               MessageBox.Show("Error en los datos ingresados");
               this.BackColor = Color.Red;


            }
        }
    }
}
