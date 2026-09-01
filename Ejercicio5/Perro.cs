using System;

namespace Ejercicio5
{
    // Clase derivada en la herencia multinivel. Hereda Alimentar de <see cref="Mamifero"/> y sobrescribe HacerSonido de Animal.
    public class Perro : Mamifero
    {
        //Metodo que sobrescribe el sonido heredado de Animal (ejercicio 4) a traves de Mamifero.
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau!");
        }
    }
}