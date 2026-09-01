namespace Ejercicio1
{
    /// <summary>
    /// Representa una cuenta bancaria. El saldo permanece encapsulado
    /// y solo se modifica mediante operaciones publicas validadas.
    /// </summary>
    public class CuentaBancaria
    {
    //Declaracion de variable
        private decimal saldo;

        //Metodo de deposito
        public bool Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                return false;
            }

            saldo += monto;
            return true;
        }

        //Metodo de retiro
        public bool Retirar(decimal monto)
        {
            if (monto <= 0 || monto > saldo)
            {
                return false;
            }

            saldo -= monto;
            return true;
        }

        //Metodo de obtencion de saldo liquido
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}
