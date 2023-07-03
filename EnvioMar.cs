using System;
using System.Collections.Generic;
using System.Text;

namespace MensajeriaYPaqueteria
{
    class EnvioMar : IEnvio
    {
        public void procesarEnvio()
        {
            Console.WriteLine("El paquete se ha cargado en el barco.");
        }

        public void enviar()
        {
            Console.WriteLine("El paquete va navegando por el mar.");
        }

        public void procesarEntrega()
        {
            Console.WriteLine("El paquete se ha descargado en el puerto.");
        }
    }

}

