using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploTask_Autos.Logica
{
    public static class SistemaAuto
    {

        static int kilometrajeAuto;
        static bool autoEncendido;
        static bool autoCirculando;

        public static bool AutoEncendido { get => autoEncendido; set => autoEncendido = value; }
        public static int KilometrajeAuto { get => kilometrajeAuto; }
        public static bool AutoCirculando { get => autoCirculando; }

        public static void CircularAuto(Action<int> actualizarKilometraje, Action<string> informacionTablero, CancellationToken cancelToken)
        {
            Task.Run(() =>
            {
                autoCirculando = true;

                while (true)
                     {
                         if (cancelToken.IsCancellationRequested)
                         {
                             autoCirculando = false;
                             informacionTablero.Invoke("Auto apagado correctamente");
                             cancelToken.ThrowIfCancellationRequested();
                         }
                         Task.Delay(3000);
                         kilometrajeAuto++;
                         actualizarKilometraje.Invoke(KilometrajeAuto);
                     }

                 }

              );

        }

    }
}
