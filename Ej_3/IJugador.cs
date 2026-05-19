namespace Gonza
{
    public interface IJugador
    {
        bool Jugador_Profesional { get; }
        int Estamina { get; }

        bool Correr(int minutos);
        bool EstaCansado();
        void Descansar(int minutos);
    }
}