using System.Text;

namespace Entidades
{
    public class Estante
    {

        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }


        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is not null)
                {
                    sb.AppendLine($"Producto:\n{Producto.MostrarProducto(e.productos[i])}");
                }
            }
            sb.AppendLine($"Ubicacion estante: {e.ubicacionEstante}");


            return sb.ToString();
        }



        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    return true;
                }
            }
            return false;

        }


        public static bool operator !=(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] != p)
                {
                    return true;
                }
            }
            return false;


        }



        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {

                    if (e.productos[i] is null)
                    {

                        e.productos[i] = p;
                        return true;
                    }
                }
            }

            return false;

        }


        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {

                if (e.productos[i] is not null)
                {
                    if (e == p)
                    {
                        e.productos[i] = null;

                        return e;
                    }
                }
            }
            return e;
        }


    }
}
