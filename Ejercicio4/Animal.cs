using System;

namespace Ejercicio4
{
    // Clase base reutilizable para representar un animal.
    public class Animal
    {

        // Metodo que emite el sonido generico de un animal.
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}