using System;

namespace Gonza
{
    class Program
    {
        static void Main(string[] args)
        {
            CajaDeAhorro ahorro1 = new CajaDeAhorro();
            ahorro1.Depositar(1000);
            ahorro1.Extraer(400);
            ahorro1.Extraer(800); // debe rechazarse 
            ahorro1.MostrarSaldo(); // debe mostrar 600 

            CuentaCorriente corriente1 = new CuentaCorriente(500); // descubierto: 500
            corriente1.Depositar(200);
            corriente1.Extraer(600); // queda en -400, es valido 
            corriente1.Extraer(200); // supera el descubierto, debe rechazarse 
            corriente1.MostrarSaldo(); // debe mostrar -400 

            Banco banco = new Banco();
            CajaDeAhorro ahorro = new CajaDeAhorro();
            CuentaCorriente corriente = new CuentaCorriente(500);
            banco.AgregarCuenta(ahorro);
            banco.AgregarCuenta(corriente);
            ahorro.Depositar(1000);
            banco.Transferir(ahorro, corriente, 300); // debe funcionar 
            banco.Transferir(ahorro, corriente, 900); // debe rechazarse, saldo insuficiente
        }
    }
}