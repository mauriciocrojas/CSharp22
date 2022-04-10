//Ejercicio I02 - Registrate
//Consigna
//Crear un proyecto de tipo Windows Forms App y un proyecto de biblioteca de clases.

//Agregar al proyecto de biblioteca de clases la clase Ingresante 
//tal como describe el siguiente diagrama:

//El constructor inicializará todos los atributos de la clase.
//El método Mostrar expondrá todos los atributos de la clase al exterior, 
//utilizar StringBuilder e interpolación de strings.
//El proyecto de Windows Forms contará con los siguientes controles:

//Un control de tipo GroupBox que contendrá dos controles de tipo TextBox para 
//cargar el nombre y la dirección, y un NumericUpDown para cargar la edad 
//del usuario con sus respectivos Label.
//Un segundo control de tipo GroupBox que contendrá tres RadioButton que determinarán 
//el género del usuario (masculino, femenino o no binario).
//Un último control de tipo GroupBox contendrá tres controles de tipo CheckBox con los 
//distintos cursos a elegir (C#, C++ o JavaScript). Se deben poder elegir todos los 
//cursos, ninguno o algunos.
//Un control de tipo ListBox que tendrá los paises para que el 
//usuario escoja (Argentina, Chile o Uruguay).
//Por último, un botón que al accionarse deberá mostrar toda la 
//información del usuario registrado.

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
