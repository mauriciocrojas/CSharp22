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
    public partial class MenuPrincipal : Form
    {
        Alumno[] alumnos;
        private string usuario;

        private MenuPrincipal()
        {
            InitializeComponent();
            alumnos = new Alumno[10];
            Carga();
        }

        public MenuPrincipal(string nombreUsuario) : this()
        {
            this.usuario = nombreUsuario;
        }
        private void Carga()
        {
            alumnos[0] = new Alumno("pepe", "martinez", 123131);
            alumnos[1] = new Alumno("juana", "rufosa", 32133);
            alumnos[2] = new Alumno("ronmeo", "gatuso", 64324);
            alumnos[3] = new Alumno("jazmin", "perrosa", 56234);
            alumnos[4] = new Alumno("lucas", "Rodriguez", 97521);
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lb_welcome.Text = " WELCOME " + usuario;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] != null)
                {
                    this.rtb_informacion.Text += alumnos[i].MostrarInfo() + "\n";
                }
            }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AltaAlumno frmAltaAlumno = new AltaAlumno();
            DialogResult resultado = frmAltaAlumno.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                int posLibre = ProximaPos();

                if (posLibre != -1)
                {
                    alumnos[posLibre] = frmAltaAlumno.GetAlumno();

                    this.rtb_informacion.Text += frmAltaAlumno.GetAlumno().MostrarInfo() + "\n";

                  //this.rtb_informacion.Text += alumnos[posLibre].MostrarInfo() + "\n";

                }
                else
                {
                    MessageBox.Show("NO HAY MAS LUGAR");
                }
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }

        private int ProximaPos()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] == null)
                    return i;
            }
            return -1;
        }

    }
}
