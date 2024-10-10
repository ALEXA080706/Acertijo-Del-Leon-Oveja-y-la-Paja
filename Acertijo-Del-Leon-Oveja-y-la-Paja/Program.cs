using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Program //Clase
    {
        public static void Main(string[] args) //Metodo void = No retorna nada
        {
            Console.WriteLine("Hello World");

            // Inicializar un Objeto/Instancia = los objetos son instancias de una clase

            Program program = new Program();

            string mensaje = program.Mensaje();

            Console.WriteLine(mensaje);

            // Inicializar un Objeto que recibe parametros

            string nombre = "        Alexa Lara       ";

            MensajeFormateado mensajeFormateado = new MensajeFormateado(nombre);


            Console.WriteLine(mensajeFormateado.MensajeSinEspacios());
            Console.WriteLine(mensajeFormateado.MensajeEnMayusculaOMinuscula(true));

            
           
        }

        public string Mensaje() //Metodo string = retorna una cadena de caracteres
        {
            string defaultMensaje = "Hola Mundo";

            return defaultMensaje;
        }
    }

    public class MensajeFormateado
    {
        protected string mensaje;

        public MensajeFormateado(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public string MensajeSinEspacios() //Metodo string que devuelve el mensaje sin espacios a los lados
        {


            mensaje.TrimStart();

            return mensaje;
        }

        public string MensajeEnMayusculaOMinuscula(bool MayusculaOMinuscula)
        {
            string mensajeFormateado;
            if (MayusculaOMinuscula)
            {
                mensajeFormateado = mensaje.ToUpper();
            }
            else
            {
                mensajeFormateado = mensaje.ToLower();
            }

            return mensajeFormateado;
        }
    }
}
