using System;
using System.Collections.Generic;
using System.Text;

namespace MensajeriaYPaqueteria
{
    public interface IEnvio 
    {
        //En esta interfaz definimos metodos que luego usaran las clases hijas de esta interfaz
        //Cada implementacion hija podria tener los mismos metodos, pero no desarrollarlos igual, cada implementacion hija puede tener su propio proposito
        public void procesarEnvio();
        public void enviar();
        public void procesarEntrega();
    }
}

