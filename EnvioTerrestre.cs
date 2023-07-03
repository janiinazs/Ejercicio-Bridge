using System;
using System.Collections.Generic;
using System.Text;

namespace MensajeriaYPaqueteria
{
    class EnvioTerrestre : IEnvio
    {
        public void procesarEnvio()
        {
            Console.WriteLine("El paquete se ha cargado en el carro.");
        }

        public void enviar()
        {
            Console.WriteLine("El paquete va en carretera.");
        }

        public void procesarEntrega()
        {
            Console.WriteLine("El paquete se ha descargado en el terminal.");
        }
    }
}
