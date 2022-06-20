using System;
using System.Threading;

namespace WinFormsApp2
{
    internal class Persona
    {
        private string nombre;
        private int dni;
        public int Dni
        {
            get => this.dni;
            set => this.dni = value;
        }
        public string Nombre { get => nombre; set => nombre = value; }

        public void Demora(Action<int> callback, CancellationToken token)
        {
            while(true)
            {
                System.Threading.Thread.Sleep(2000);
                if (token.IsCancellationRequested)
                    return;
                callback(this.dni);
            }
        }
    }
}