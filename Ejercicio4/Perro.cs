using System;

namespace Ejercicio4
{
    // Uso de clas Animal que sobrescribe el sonido.
    public class Perro : Animal
    {

        // Metodo que emite el ladrido del perro modificando el metodo de la clase base.
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau!");
        }
    }
}