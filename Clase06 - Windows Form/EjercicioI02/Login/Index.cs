using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Login
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            this.lstbPais.Items.Add("Argentina");
            this.lstbPais.Items.Add("Chile");
            this.lstbPais.Items.Add("Uruguay");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            int edad = (int)this.txtEdad.Value;
            string genero;
            string pais = this.lstbPais.Text;
            string[] cursos = new string[3];
            int index = -1;

            if (this.rdbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (this.rdbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else
            {
                genero = "No binario";
            }

            if (this.chkbCSharp.Checked)
            {
                index++;
                cursos[index] = "C#";
            }
            if (this.chkbCMas.Checked)
            {
                index++;
                cursos[index] = "C++";
            }
            if (this.chkbJavaScript.Checked)
            {
                index++;
                cursos[index] = "JavaScript";
            }



            Ingresante ingresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);

            MessageBox.Show(ingresante.Mostrar());


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
