using System;

namespace Objetos11
{
    class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
        
        static void Main(string[] args)
        {
            //Delegates
            var pagamento = new Pagamento.Pagar(RealizarPagamento);
            pagamento(25);
        }
    }

    public class Pagamento
    {
        public delegate void Pagar(double valor);
    }
}

