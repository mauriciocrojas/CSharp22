﻿using System;
using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string [] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Género: {genero}");
            sb.AppendLine($"Dirección: {direccion}");
            sb.AppendLine($"País: {pais}");
            sb.AppendLine($"Curso/s:");

            for (int i = 0; i < cursos.Length; i++)
            {
                sb.AppendLine($"{cursos[i]}");
            }

            return sb.ToString(); 
        }
    }
}
