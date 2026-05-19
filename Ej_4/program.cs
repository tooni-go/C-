using System;

namespace Gonza
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehiculo miBici = new Vehiculo(10);   // Bici a 10 m/s
            IVehiculo miCamion = new Vehiculo(30); // Camión a 30 m/s
            IVehiculo miAuto = new Vehiculo(40);   // Auto a 40 m/s

            miBici.Mover(10);   
            miCamion.Mover(10); 
            miAuto.Mover(10);   

            Console.WriteLine($"Posición de la Bicicleta: {miBici.Posicion()} metros.");
            Console.WriteLine($"Posición del Camión:    {miCamion.Posicion()} metros.");
            Console.WriteLine($"Posición del Auto:      {miAuto.Posicion()} metros.");

            // Probamos el reinicio
            Console.WriteLine("\nReiniciando posición de la bicicleta");
            miBici.ReiniciarPosicion();
            Console.WriteLine($"Posición de la bicicleta ahora: {miBici.Posicion()} metros.");
        }
    }
}