namespace Gonza
{
    public interface IVehiculo
    {
        int Velocidad { get; set; }
        int DistanciaTotal { get; set; }

        void Mover(int tiempoSegundos);
        int Posicion();
        void ReiniciarPosicion();
    }
}