using System;

namespace Gonza
{
    public class CuentaBancaria : ICuentaBancaria
    {
        protected int plata;

        public CuentaBancaria(int plataInicial)
        {
            plata = plataInicial;
        }

        public void Depositar(int monto)
        {
            if (monto > 0) plata += monto;
            else Console.WriteLine("Monto invalido.");
        }

        public virtual bool Extraer(int monto)
        {
            if (monto > 0)
            {
                plata -= monto;
                return true;
            }
            return false;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine("Saldo actual: $" + plata);
        }
    }
}