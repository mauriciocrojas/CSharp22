using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmEjemplo : Form
    {
        private List<Persona> personas;
        Func<int, int, float> dividir;

        private delegate string MiMetodo(int i);
        CancellationTokenSource cts = new CancellationTokenSource();

        public FrmEjemplo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dividir = (x, y) =>
            {
                return x / y / x;
            };

            MiMetodo a = (int entero) => entero.ToString();
            MiMetodo b = Algo;
        }

        private string Algo(int i) { return ""; }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            dividir = (x, y) =>
            {
                return x / y;
            };

            txtResultado.Text = dividir(6, 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personas = new List<Persona>();
            this.personas.Add(new Persona() { Dni = 3 });
            this.personas.Add(new Persona() { Dni = 1 });
            this.personas.Add(new Persona() { Dni = 2 });
            this.personas.Add(new Persona() { Dni = 6 });

            this.personas.Sort((a, b) =>
            {
                if (a.Dni > b.Dni)
                    return 1;
                else if (a.Dni < b.Dni)
                    return -1;
                else
                    return 0;
            });

            this.personas.Sort(OrdenarPorDni);
        }

        private static int OrdenarPorDni(Persona a, Persona b)
        {
            return (a.Dni - b.Dni);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Persona p = new Persona() { Dni = 30123654 };

            Task t = Task.Run(() => p.Demora( Mensaje, cts.Token));
        }

        //private delegate void JuanCarlosElDelegado(int i);
        public void Mensaje(int dni)
        {
            if (this.InvokeRequired)
            {
                object[] obj = new object[] { dni };
                // this.txtResultado.Invoke(new JuanCarlosElDelegado(Mensaje), obj);
                this.txtResultado.Invoke(new Action<int>(Mensaje), obj);
            }
            else
            {
                MessageBox.Show("¡Terminó! " + dni);
                txtResultado.Text = dni.ToString();
            }
        }

        private void btnTaskEnd_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
