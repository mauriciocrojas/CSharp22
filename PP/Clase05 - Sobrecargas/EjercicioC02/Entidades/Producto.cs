using System.Text;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }


        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }


        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.marca}, Precio: {p.precio}, Código de barras: {p.codigoDeBarra}");

            return sb.ToString();
        }


        public static explicit operator string(Producto p)
        {
            if (p is not null)
            {
                return p.codigoDeBarra;
            }
            return "Código de barras inaccesible";
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return (p1.marca == p2.marca) && (p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }



        public static bool operator ==(Producto p1, string marca)
        {
            if (p1 is not null && string.IsNullOrEmpty(marca))
            {
                return (p1.marca == marca);
            }
            return false;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }

    }
}
