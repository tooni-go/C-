using System;

namespace Gonza
{
    public class Banco
    {
        private CuentaBancaria[] misCuentas = new CuentaBancaria[10];
        private int cantidad = 0;

        public void AgregarCuenta(CuentaBancaria cuenta)
        {
            if (cantidad < 10)
            {
                misCuentas[cantidad] = cuenta;
                cantidad++;
            }
        }

        public void Transferir(CuentaBancaria origen, CuentaBancaria destino, int monto)
        {
            bool origenExiste = false;
            bool destinoExiste = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (misCuentas[i] == origen) 
                    origenExiste = true;
                if (misCuentas[i] == destino) 
                    destinoExiste = true;
            }

            if (origenExiste && destinoExiste && monto > 0)
            {
                if (origen.Extraer(monto))
                {
                    destino.Depositar(monto);
                    Console.WriteLine("Transferencia de $" + monto + " completada.");
                }
            }
            else
            {
                Console.WriteLine("Error: Monto o Cuentas mal");
            }
        }
    }
}