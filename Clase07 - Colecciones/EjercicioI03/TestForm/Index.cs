//Ejercicio I03 - ¡A contar palabras!
//Consigna
//Crear un proyecto de tipo Windows Forms App, con un RichTextBox y un botón Calcular.

//El formulario debe tener el siguiente aspecto:

//Utilizar diccionarios(Dictionary<string, int>) para realizar un contador de palabras.

//Se deberá recorrer el texto ingresado palabra por palabra. Si se trata de una nueva palabra,
//se la agregará al diccionario y se inicializará su contador en 1. Caso contrario, se deberá 
//incrementar dicho contador.
//Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
//Al presionar el botón Calcular informar mediante un MessageBox el TOP 3 de palabras con más 
//apariciones


using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Index : Form
    {
        public Dictionary<string, int> diccionario;
        public List<string> listaPalabras;
        public int cont = 0;
        public Index()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            listaPalabras = new List<string>();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            contadorPalabras(this.rchPalabras.Text);
        }

        private void btnMostrarPalabras_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Mostrar());
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var palabra in diccionario)
            {
                sb.Append($"Palabra: {palabra.Key}, Código: {palabra.Value}\n");
            }
            return sb.ToString();
        }

        public bool ExisteEnDiccionario(string palabra)
        {
            foreach (var item in diccionario)
            {
                if (item.Key == palabra)
                {
                    return true;
                }
            }
            return false;
        }

        public void contadorPalabras(string palabra)
        {
            listaPalabras.Add(palabra);
            foreach (var texto in listaPalabras)
            {
                if (!diccionario.ContainsKey(palabra))
                {
                    diccionario.Add(texto, 1);

                }
                else
                {
                    diccionario[texto] += 1;

                }
            }
        }
    }
}
