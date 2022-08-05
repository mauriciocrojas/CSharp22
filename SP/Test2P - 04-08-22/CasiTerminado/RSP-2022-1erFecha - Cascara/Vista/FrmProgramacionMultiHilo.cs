using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmProgramacionMultiHilo : Form
    {
        Task cargaEmpleados;
        CancellationTokenSource cts;
        List<Empleado> postulantes;
        List<Puesto> puestosLibres;


        //completar
        public FrmProgramacionMultiHilo()
        {
            InitializeComponent();

            postulantes = new List<Empleado>();
            puestosLibres = new List<Puesto>();

            cts = new CancellationTokenSource();
            cargaEmpleados = new Task(ComenzarCarga);

        }



        //no modificar
        private void FrmProgramacionMultiHilo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                puestosLibres.Add(GeneradorDeDatos.GetUnPuesto);
            }
        }


        private void ComenzarCarga()
        {
            while (true)
            {
                if (cts.IsCancellationRequested)
                {
                    return;
                }
                else if (this.dtg_ListadoPuestosEncontrados.InvokeRequired)
                {
                    postulantes.Add(GeneradorDeDatos.GetEmpleado);

                    this.dtg_ListadoPuestosEncontrados.BeginInvoke((MethodInvoker)delegate ()
                    {
                        dtg_ListadoPuestosEncontrados.DataSource = null;
                        dtg_ListadoPuestosEncontrados.DataSource = postulantes;
                    });
                }


                Thread.Sleep(2000);
            }
        }



        // completar
        private void CancelarProceso()
        {

            btn_comenzarCarga.Enabled = false;
            MessageBox.Show("Se han cubierto todos los puestos de trabajo!!!");
            cts.Cancel();

        }



        //no modificar
        private void btn_comenzarCarga_Click(object sender, EventArgs e)
        {
            btn_comenzarCarga.Enabled = false;
            cargaEmpleados.Start();
        }
    }
}
