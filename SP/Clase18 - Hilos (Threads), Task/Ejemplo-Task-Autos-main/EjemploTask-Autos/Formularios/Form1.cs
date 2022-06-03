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
using EjemploTask_Autos.Logica;

namespace EjemploTask_Autos
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
        }

        private void btn_PrenderAuto_Click(object sender, EventArgs e)
        {
            SistemaAuto.AutoEncendido = true;
            pb_nafta.Visible = true;
            pb_temperatura.Visible = true;
        }

        private void btn_Conducir_Click(object sender, EventArgs e)
        {
            try
            {
                if (SistemaAuto.AutoEncendido)
                {
                    pb_rpm.Visible = true;
                    pb_velocimetro.Visible = true;

                    SistemaAuto.CircularAuto(ActualizarKilometrosEnPantalla, MensajeEnTablero, cts.Token);


                    btn_Conducir.Text = "Apagar Auto";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ActualizarKilometrosEnPantalla(int km)
        {
            if (this.lb_kilometraje.InvokeRequired)
            {
                this.lb_kilometraje.BeginInvoke((MethodInvoker)delegate ()
                {
                    lb_kilometraje.Visible = true;

                    this.lb_kilometraje.Text = km.ToString();
                });

                Thread.Sleep(1000);
            }
            else
            {
                this.lb_kilometraje.Text = km.ToString();
            }
        }

        private void btn_ApagarAutomovil_Click(object sender, EventArgs e)
        {
            if (SistemaAuto.AutoCirculando)
            {
                cts.Cancel();
            }
        }

        private void MensajeEnTablero(string mensaje)
        {
            if (this.lb_informacionTablero.InvokeRequired)
            {
                this.lb_informacionTablero.BeginInvoke((MethodInvoker)delegate ()
                {
                    lb_informacionTablero.Visible = true;

                    lb_informacionTablero.Text = mensaje;
                });

            }
        }

        private void btn_kmIniciales_Click(object sender, EventArgs e)
        {
            ActualizarKilometrosEnPantalla(int.Parse(textBox1.Text));
        }
    }
}
