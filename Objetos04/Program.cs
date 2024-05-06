using System;

namespace Objetos04
{
    class Program
    {
        static void Main(string[] args)
        {
            // var pagamento = new Pagamento();
            // pagamento.Dispose();

            using (var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando o pagamento");
            }
        }
    }

    public class Pagamento : IDisposable //Control + "." implement
    {
        public Pagamento()
        {
            Console.WriteLine("Iniciando Pagamento");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando o Pagamento");
        }
    }
}

