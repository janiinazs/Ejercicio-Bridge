using System;

namespace MensajeriaYPaqueteria
{
    class Program
    {
        static void Main(string[] args)
        {
            // En primer lugar crearemos el objeto que representa a la empresa de mensajeria
            EmpresaTransport mensajero = new EmpresaTransport("01234569870");

            // Enviaremos un paquete vía aérea, que es la que esta empresa tiene por defecto
            mensajero.recogerPaquete();
            mensajero.enviarPaquete();
            mensajero.entregarPaquete();


            Console.WriteLine("---------------------------------------");

            // Ahora le decimos a la empresa que queremos enviar por mar
            mensajero.setEnvio(new EnvioMar());
            mensajero.recogerPaquete();
            mensajero.enviarPaquete();
            mensajero.entregarPaquete();

            Console.WriteLine("---------------------------------------");

            // Ahora le decimos a la empresa que queremos enviar por tierra
            mensajero.setEnvio(new EnvioTerrestre());
            mensajero.recogerPaquete();
            mensajero.enviarPaquete();
            mensajero.entregarPaquete();

        }
    }
}
