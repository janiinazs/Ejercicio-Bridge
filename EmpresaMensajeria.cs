using System;
namespace MensajeriaYPaqueteria
{
    public abstract class EmpresaMensajeria
    {
        //Aqui definimos la referencia a la interfaz y las variables propiasd de una abstraccion
        public IEnvio envio;    
        public string nombre;        
        public string direccion;        
        public string telefono;
        public EmpresaMensajeria() { }
         //Podemos usar esa referencia a la interfaz para utilizar metodos sin la necesidad de una herencia
        //usamos "this" para hacer referencia a la variable definida en esta clase y no al parametro del metodo
        //Ademas de que usamos "=>" para recortar lineas de codigo, se puede usar cuando el metodo solo tiene una linea de codigo
        public EmpresaMensajeria(IEnvio envio)
        {
            this.envio = envio;
        }
        public void recogerPaquete()
        {
            Console.WriteLine("Se ha recogido el paquete.");
            envio.procesarEnvio();
        }
        public void enviarPaquete()
        {
            envio.enviar();
        }
        public void entregarPaquete()
        { 
            envio.procesarEntrega();
            Console.WriteLine("Se ha entregado el paquete.");
        }
        public void setEnvio(IEnvio envio)
        {
            this.envio = envio;
        }
        public IEnvio getEnvio() 
        { 
            return envio; 
        }
    }
}
