//Consigna
//Crear una aplicación de Windows Forms que pueda realizar un cálculo de
//consumo entre kilometros y litros.

//Formulario

//El formulario deberá contener:

//2x Labels
//2x TextBox
//1x Button
//1x RichTextbox
//El formulario debe levantar en el centro de la pantalla, no debe tener los
//botones de maximizar, minimizar y no se le tiene que poder modificar el tamaño.

//El RichTextbox no tiene que poder editarse.

//El formulario debe validar que los dos parámetros ingresados no estén vacíos y
//en caso de estar se deberá lanzar una nueva excepción de tipo ParametrosVaciosException e informar al usuario.

//Una vez que los parámetros fueron cargados validar si la conversión es posible
//(utilizar int.Parse), de lo contrario capturar la excepción correspondiente.

//Crear una clase estática llamada Calculador con un metodo estático Calcular que
//recibe dos enteros y retorna su división tener en cuenta que las división por cero lanza una excepción, controlarla.

//Todas las excepciones que fueron capturadas deben ser mostradas al usuario de una
//forma mas entendible ("amigable") por medio del metodo Show de la clase MessageBox.

//El programa no debe tener ninguna excepción no controlada.

using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormCalculador : Form
    {
        public FormCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKilometros.Text) || String.IsNullOrEmpty(txtLitros.Text))
                {
                    throw new ParametrosVaciosException("Alguno de los campos está vacío");
                }

                this.rchInfo.Text = $"km/hs: {Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text))}";

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Campos inválidos");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
