//Ejercicio I01 - ¡Hola, Windows Forms!
//Consigna
//Parte I
//Crear un proyecto de tipo Windows Forms App que contenga un formulario con los siguientes controles:

//Dos controles de tipo TextBox. En uno se ingresará un nombre y en el otro un apellido.
//Sobre cada control debe haber un Label en negrita que indique al usuario el dato que debe ingresar.
//Un control de tipo Button con el texto "Saludar".
//Crear otro formulario que reciba como argumentos de su único constructor un título y un mensaje.

//Al presionar el botón Saludar se deberá abrir este segundo formulario de forma modal mostrando un mensaje como el siguiente:

//¡Hola, Windows Forms!

//Soy {nombre} { apellido}.

//En negrita, con itálica y fuente tamaño 14 mostrará el título y debajo, con fuente tamaño 12, el mensaje.

//Las variables nombre, apellido se deberán reemplazar con los valores ingresados por el usuario.

//Requisitos
//Todos los controles deberán tener nombres descriptivos, así como el formulario y los archivos de 
//código fuente. No debe quedar ningún nombre por defecto.
//Ambos formularios deberán iniciarce en el centro de la pantalla.
//El título del primer formulario deberá ser "¡Hola, Windows Forms!".
//El título del segundo formulario deberá ser "Saludo".
//No deberá poder maximizarse, minimizarse, ni alterar el tamaño de las ventanas.


//Propiedades útiles
//GENERAL
//(Name): Permite modificar el nombre de la variable que contiene la instancia del control.
//Text: Permite modificar el texto asociado al control.
//Font: Ajustes relacionados a la fuente utilizada para mostrar texto dentro del control.
//FORMULARIOS
//FormBorderStyle: Indica la apariencia y el comportamiento del borde y de la barra de título 
//    del formulario. Por ejemplo, el valor FixedSingle genera una ventana con tamaño fijo.
//MinimizeBox: Determina si un formulario tiene un cuadro para minimizar en la esquina superior 
//    derecha de la barra de título.
//MaximizeBox: Determina si un formulario tiene un cuadro para maximizar en la esquina superior 
//    derecha de la barra de título.
//StartPosition: Determina la posición del formulario cuando aparece por primera vez.

//Parte II
//Agregar un control de tipo ComboBox precargado con los nombres de las materias del primer y 
//    segundo cuatrimestre de la carrera. Deberá estar acompañado de su respectivo Label.

//Modificar el mensaje para que muestre:

//¡Hola, Windows Forms!

//Soy {nombre} { apellido}
//y mi materia favorita es {materia}.

//Las variables nombre, apellido y materia se deberán reemplazar con los valores ingresados por el usuario.

//Requisitos
//Inicializar el ComboBox en el evento Load del objeto Form.
//NO deberá permitir el ingreso de nuevas opciones.
//Deberá existir una opción seleccionada por defecto al iniciar el formulario (no aparecer en blanco).

//Parte III
//Al presionar el botón Saludar y antes de mostrar la ventana con el mensaje, se deberá validar 
//que se haya ingresado un valor para el nombre y el apellido.

//Utilizar el método estático IsNullOrWhiteSpace de la clase String para validar.

//En caso de que no se haya ingresado, en vez de la ventana habitual mostrar un MessageBox con el 
//texto "Error" de título, un ícono de error y un sólo botón de OK. Deberá contener el siguiente mensaje:

//Se deben completar los siguientes campos:

//Nombre

//Apellido

//Sólo se deberán mostrar los campos que no contengan ningún valor. Si el usuario llenó el campo del 
//nombre pero falta el apellido, mostrar solo "Apellido". Si no llenó ninguno, mostrar los dos.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saludador
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbMatFav.Items.Add("Programación I");
            this.cmbMatFav.Items.Add("Programación II");
            this.cmbMatFav.Items.Add("Sistemas Operativos");
            this.cmbMatFav.Items.Add("Met. de la investigación");
            this.cmbMatFav.Items.Add("Inglés");
            this.cmbMatFav.SelectedIndex = 0;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {


            Saludo frmSaludo = new Saludo(this.txtNombre.Text, this.txtApellido.Text, this.cmbMatFav.Text);

            if(!string.IsNullOrWhiteSpace(this.txtNombre.Text) && string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombre.Text) && string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            frmSaludo.Show();

            }



        }
    }
}
