using System;
using System.Collections.Generic;
using System.Text;

namespace MensajeriaYPaqueteria
{
    public class EmpresaTransport : EmpresaMensajeria
    {
        //Aqui definiriamos las variables propias de la clase concreta/hija
        private string id;
        //Dependiendo del problema, podriamos definir varios constructores
        /*Aqui ademas de usar this, usamos "base" que podemos decir que hace lo contrario a el "this", ayuda a referencia 
        algo de otro contexto o clase que este jerárquicamente por encima de la clase o contexto actual*/ 
        public EmpresaTransport(string id, IEnvio envio) : base(envio)
        {
            base.envio = envio;
            this.id = id;
        }
        public EmpresaTransport(string id)
        {
            IEnvio envioPorDefecto = (IEnvio)new EnvioAire();
            envio = envioPorDefecto;
            this.id = id;
        }
        public void Identificarse()
        {
            Console.WriteLine("Identificación: " + id);
        }
    }
}

