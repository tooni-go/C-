using System;

namespace Gonza
{
    public class CuentaCorriente : CuentaBancaria
    {
        private int descubierto;

        public CuentaCorriente(int limite) : base(0)
        {
            descubierto = limite;
        }

        public override bool Extraer(int monto)
        {
            if (monto <= 0) 
                return false;

            if (plata - monto < -descubierto)
            {
                Console.WriteLine("Rechazado: Supera tu limite de descubierto.");
                return false;
            }
            plata -= monto;
            return true;
        }
    }
}