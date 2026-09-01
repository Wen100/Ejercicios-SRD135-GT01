using System;

namespace Ejercicio3
{
    /// <summary>
    /// Clase base que representa un vehiculo.
    /// Encapsula el estado de encendido y expone las operaciones comunes.
    /// </summary>
    // Clase padre
    
    public class Vehiculo
    {
    // Metodo de encedido, que verificará despues clase coche
        private bool encendido;

        // Get para que Coche.cs lo identifique
        protected bool Encendido
        {
            get { return encendido; }
        }

        // Metodo que enciende el vehiculo si aun no esta arrancado.
        public void Arrancar()
        {
            if (encendido)
            {
                Console.WriteLine("El vehiculo ya esta arrancado.");
                return;
            }

            encendido = true;
            Console.WriteLine("El vehiculo ha arrancado.");
        }

        //Metodo que detiene el vehiculo si se encuentra en marcha.
        public void Detener()
        {
            if (!encendido)
            {
                Console.WriteLine("El vehiculo ya esta detenido.");
                return;
            }

            encendido = false;
            Console.WriteLine("El vehiculo se ha detenido.");
        }
    }
}
