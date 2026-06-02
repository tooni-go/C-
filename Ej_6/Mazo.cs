using System;

namespace Gonza
{
    public class Mazo : IMazo
    {
        private Carta[] cartas = new Carta[40];
        private int cartaActual = 0;

        public Mazo()
        {
            string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };
            int pos = 0;

            for (int i = 0; i < palos.Length; i++)
            {
                for (int n = 1; n <= 12; n++)
                {
                    if (n != 8 && n != 9) 
                    {
                        cartas[pos] = new Carta(palos[i], n);
                        pos++;
                    }
                }
            }
        }

        public void barajar()
        {
            Random r = new Random();
            for (int i = 0; i < cartas.Length; i++)
            {
                int azar = r.Next(cartas.Length);
                Carta temp = cartas[i];
                cartas[i] = cartas[azar];
                cartas[azar] = temp;
            }
            cartaActual = 0;

        public Carta robarCarta()
        {
            if (cartaActual < 40)
            {
                Carta c = cartas[cartaActual];
                cartaActual++;
                return c;
            }
            Console.WriteLine("No hay mas cartas.");
            return null;
        }

        public int cuantasCartasQuedan()
        {
            return 40 - cartaActual;
        }
    }
}