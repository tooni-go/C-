using System;

namespace Gonza
{
    public class Vehiculo : IVehiculo
    {
        public int Velocidad { get; set; }
        public int DistanciaTotal { get; set; }

        public Vehiculo(int velocidadInicial)
        {
            Velocidad = velocidadInicial;
            DistanciaTotal = 0;
        }

        public void Mover(int tiempoSegundos)
        {
            DistanciaTotal += (Velocidad * tiempoSegundos);
        }

        public int Posicion()
        {
            return DistanciaTotal;
        }

        public void ReiniciarPosicion()
        {
            DistanciaTotal = 0;
        }
    }
}