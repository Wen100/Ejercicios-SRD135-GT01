using System;

namespace Ejercicio3
{
    /// <summary>
    /// Clase derivada de <see cref="Vehiculo"/>.
    /// Reutiliza Arrancar y Detener, y agrega la operacion Conducir.
    /// </summary>
    
    //Herencia de clases
    public class Coche : Vehiculo
    {

        //Metodo para conducir
        public void Conducir()
        {
            if (!Encendido)
            {
                Console.WriteLine("No se puede conducir. Primero debe arrancar el coche.");
                return;
            }

            Console.WriteLine("El coche esta en marcha.");
        }
    }
}
