using System;

namespace Ejercicio4
{

    // Uso de clase animal que sobrescribe el sonido.
    public class Gato : Animal
    {

        // Metodo que emite el maullido del gato usando el de la clase base.
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maulla: ¡Miau!");
        }
    }
}