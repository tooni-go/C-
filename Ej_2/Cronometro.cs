using System;
namespace GonzaSolucion.EJ_2
{ 

    public class Cronometro
    {
        public int Segundos;
        public int Minutos;

        public Cronometro()
        {
            Segundos = 0;
            Minutos = 0;
        }

        public void reiniciar()
        {
            Segundos = 0;
            Minutos = 0;
        }

        public void incrementarTiempo()
        {
            Segundos += 1;

            if (Segundos >= 60)
            {
                Minutos += 1;
                Segundos = 0; 
            }
        }

        public string mostrarTiempo()
        {
            return $"Tiempo en minutos: {Minutos} | Tiempo en Segundos: {Segundos}s";
        }
    }
}