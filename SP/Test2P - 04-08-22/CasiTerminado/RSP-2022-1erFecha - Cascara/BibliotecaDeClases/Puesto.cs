namespace BibliotecaDeClases
{
    public class Puesto : ICompensacion
    {
        string nombrePuesto;
        float remuneraciónOfrecida;

        private Puesto()
        {
            remuneraciónOfrecida = GeneradorDeDatos.Rnd.Next(100000, 250000);
        }

        public Puesto(string nombre) : this()
        {
            this.nombrePuesto = nombre;
        }

        public string Posicion { get => nombrePuesto; }

        public float CalcularHonorarios
        {
            get
            {
                if (remuneraciónOfrecida > 200000)
                {
                    return remuneraciónOfrecida * (float)0.75;
                }
                else
                {
                    return remuneraciónOfrecida;
                }
            }
        }

        public override string ToString()
        {
            return "Se busca " + this.nombrePuesto + " - " + "Sueldo ofrecido: " + CalcularHonorarios;
        }
    }
}
