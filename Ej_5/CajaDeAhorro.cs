using System;

namespace Gonza
{
    public class CajaDeAhorro : CuentaBancaria
    {
        public CajaDeAhorro() : base(0) { }

        public override bool Extraer(int monto)
        {
            if (monto <= 0) return false;
            if (monto > plata)
            {
                Console.WriteLine("Rechazado: No te alcanza la plata.");
                return false;
            }
            plata -= monto;
            return true;
        }
    }
}