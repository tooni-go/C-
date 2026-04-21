using System;
namespace GonzaSolution.EJ_1
{
    public class Semaforo
    {
        public string ColorActual;
        public int RelojInterno;
        public bool modoIntermitente = false;

        //Rojo — 30 segundos 
        //• Rojo + Amarillo — 2 segundos 
        //• Verde — 20 segundos 
        //• Amarillo — 2 segundos 
        public Semaforo()
        {
            ColorActual = "Rojo";
            RelojInterno = 0;
        }

        public void pasoDelTiempo(int segundos)
        {
            RelojInterno += segundos;

            int ciclo = RelojInterno % 54;

            if (ciclo < 30) 
                ColorActual = "Rojo";
            else if (ciclo < 32) 
                ColorActual = "Rojo + Amarillo";
            else if (ciclo < 52) 
                ColorActual = "Verde";
            else 
                ColorActual = "Amarillo";

        }

        public void mostrarColor()
        {
            Console.WriteLine($"Color actual: {ColorActual}");
        }

        public void ponerEnIntermitente()
        {
            modoIntermitente = true;

            while (modoIntermitente)
            {
                ColorActual = "Amarillo";
                mostrarColor();
                Thread.Sleep(1000);

                ColorActual = "Apagado";
                mostrarColor();
                Thread.Sleep(1000);
            }
        }

        public void sacarDeIntermitente()
        {
            modoIntermitente = false;
        }
    }
}