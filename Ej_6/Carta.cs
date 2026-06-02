namespace Gonza
{
    public class Carta : ICarta
    {
        public string palo { get; private set; }
        public int numero { get; private set; }

        public Carta(string p, int n)
        {
            palo = p;
            numero = n;
        }
    }
}