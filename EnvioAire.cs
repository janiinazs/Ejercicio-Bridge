using System;
using System.Collections.Generic;
using System.Text;

namespace MensajeriaYPaqueteria
{
    class EnvioAire : IEnvio
    {
        //Aqui vemos los metodos de la clase padre/interfaz (IEnvio) y aqui se definen cada metodo con sus respectivas operaciones 
        public void procesarEnvio()
        {
            Console.WriteLine("El paquete se ha cargado en el avión.");
        }

        public void enviar()
        {
            Console.WriteLine("El paquete va volando por el aire.");
        }

        public void procesarEntrega()
        {
            Console.WriteLine("El paquete se ha descargado en el aeropuerto.");
        }
    }
}
