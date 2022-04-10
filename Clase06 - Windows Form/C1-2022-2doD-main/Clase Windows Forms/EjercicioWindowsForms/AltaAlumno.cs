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
    public partial class AltaAlumno : Form
    {
        private Alumno alumnoCreado;

        public AltaAlumno()
        {
            InitializeComponent();
        }

        public Alumno GetAlumno()
        {
            return alumnoCreado;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            string nomb = this.tb_nombre.Text;
            string ape = this.tb_apellido.Text;
            int.TryParse(this.tb_dni.Text, out int numDoc);
            int.TryParse(this.tb_telefono.Text, out int tel);
            string dire = this.tb_direccion.Text;

            alumnoCreado = new Alumno(nomb, ape, numDoc, tel, dire);

            this.DialogResult = DialogResult.OK;

        }
    }
}
