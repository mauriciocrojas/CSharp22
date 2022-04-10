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
    public partial class Saludo : Form
    {
        public string mensaje;
        public string nombre;
        public string apellido;

        public Saludo(string nombre, string apellido)
        {
            InitializeComponent();
            this.mensaje = "¡Hola, Windows Forms!";
            this.nombre = nombre;
            this.apellido = apellido;

        }

        private void Saludo_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text = mensaje;
            this.lblSoy.Text = $"Soy {nombre} {apellido}";
        }
    }
}
