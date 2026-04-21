using System;
using GonzaSolution.EJ_1;

class Program
{
    static void Main(string[] args)
    {
     
        Semaforo miSemaforo = new Semaforo();

        miSemaforo.mostrarColor();
        Console.WriteLine($"Reloj Interno: {miSemaforo.RelojInterno}");

        miSemaforo.pasoDelTiempo(31); 
        miSemaforo.mostrarColor();
        Console.WriteLine($"Reloj Interno: {miSemaforo.RelojInterno}");

        miSemaforo.pasoDelTiempo(10); 
        miSemaforo.mostrarColor();
        Console.WriteLine($"Reloj Interno: {miSemaforo.RelojInterno}");

    }
}
