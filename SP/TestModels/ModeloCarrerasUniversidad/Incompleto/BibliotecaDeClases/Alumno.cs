﻿using System;

namespace BibliotecaDeClases
{
    public class Alumno : ICalificacion
    {
        #region No Modificar

        decimal dni;
        string nombreCompleto;
        decimal notaPrimerParcial;
        decimal notaSegundoParcial;

        public Alumno(decimal dni, string nombreCompleto, decimal notaPrimerParcial, decimal notaSegundoParcial)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.notaPrimerParcial = notaPrimerParcial;
            this.notaSegundoParcial = notaSegundoParcial;
        }

        public decimal Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public decimal NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public decimal NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        #endregion


        //completar
        public decimal CalificacionFinal { get => Decimal.Round((notaPrimerParcial+notaSegundoParcial)/2, 2); }


    }
}
