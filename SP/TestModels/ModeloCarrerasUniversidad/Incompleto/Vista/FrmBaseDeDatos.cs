﻿using BibliotecaDeClases;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmBaseDeDatos : Form
    {
        SqlManejador manejador; // no modificar
        public FrmBaseDeDatos()
        {
            InitializeComponent(); // no modificar linea
            manejador = new SqlManejador(); // no modificar linea
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno unAlumno = new Alumno(int.Parse(tb_dni.Text), tb_nombre.Text, int.Parse(tb_nota1.Text), int.Parse(tb_nota2.Text));
                // completar
                if (SqlManejador.Insert(unAlumno) >= 1)
                {
                    MessageBox.Show("Se ha insertado el alumno correctamente.", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, no se insertó el alumno");
                }
            }
            catch (DatosNoValidosException)
            {
                MessageBox.Show("Error, uno de los parámetros no es válido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
