using System;

namespace Gonza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Probando Jugador Amateur ---");
           
            IJugador amateur = new Jugador(esProfesional: false);

            Console.WriteLine($"Estamina inicial: {amateur.Estamina}");
            Console.WriteLine($"¿Pudo correr 15 minutos?: {amateur.Correr(15)}");
            Console.WriteLine($"Estamina restante: {amateur.Estamina}");
            Console.WriteLine($"¿Está cansado?: {amateur.EstaCansado()}");

            Console.WriteLine($"¿Pudo correr 10 minutos más?: {amateur.Correr(10)}"); 
            Console.WriteLine($"¿Está cansado?: {amateur.EstaCansado()}");

            Console.WriteLine("\n--- Probando Jugador Profesional ---");
            IJugador pro = new Jugador(esProfesional: true);

            Console.WriteLine($"Estamina inicial Pro: {pro.Estamina}");
            Console.WriteLine($"¿Pudo correr 35 minutos?: {pro.Correr(35)}"); 
            Console.WriteLine($"Estamina restante Pro: {pro.Estamina}");

            Console.WriteLine("Pro toma un descanso de 60 minutos");
            pro.Descansar(60);
            Console.WriteLine($"Estamina final Pro: {pro.Estamina}");
        }
    }
}