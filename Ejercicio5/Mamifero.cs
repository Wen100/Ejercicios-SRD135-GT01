using System;
using Ejercicio4;

namespace Ejercicio5
{
    // Reutiliza <see cref="Animal"/> del ejercicio 4 y agrega Alimentar.

    public class Mamifero : Animal
    {
        // Metodo que alimenta al mamifero. Este metodo se hereda hacia las clases derivadas
        
        public void Alimentar()
        {
            Console.WriteLine("El mamifero se esta alimentando.");
        }
    }
}
