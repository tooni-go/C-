namespace Gonza
{
    public interface ICuentaBancaria
    {
        void Depositar(int monto);
        bool Extraer(int monto); 
        void MostrarSaldo();
    }
}