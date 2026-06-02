using System;

namespace Gonza
{
    public class Mano : IMano
    {
        private Carta[] misCartas = new Carta[10]; 
        private int cantidad = 0;

        public void recibirCarta(Carta c)
        {
            if (c != null && cantidad < 10)
            {
                misCartas[cantidad] = c;
                cantidad++;
            }
        }

        public void mostrarMano()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("- " + misCartas[i].numero + " de " + misCartas[i].palo);
            }
        }

        public int cantidadDeCartas()
        {
            return cantidad;
        }
    }
}