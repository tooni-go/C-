using System;

namespace Gonza
{
    public class Jugador : IJugador 
    {
        public bool Jugador_Profesional { get; private set; }
        public int Estamina { get; private set; }

        public Jugador(bool esProfesional)
        {
            this.Jugador_Profesional = esProfesional;
            Estamina = esProfesional ? 40 : 20;
        }

        bool IJugador.Correr(int minutos)
        {
            if (minutos <= Estamina)
            {
                Estamina -= minutos;
                return true;
            }
            else
            {
                Estamina = 0;
                return false; 
            }
        }

        bool IJugador.EstaCansado()
        {
            return Estamina <= 0;
        }

        void IJugador.Descansar(int minutos)
        {
            Estamina += minutos;
            int tope = Jugador_Profesional ? 40 : 20;
            if (Estamina > tope) Estamina = tope;
        }
    }
}