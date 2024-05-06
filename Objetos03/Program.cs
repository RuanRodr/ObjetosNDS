using System;

namespace Objetos02
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;

        }
    }
//private, protected, internal e public
    internal class Pagamento
    {
        public string NumeroBoleto;

        public DateTime Vencimento
        {
            get
            {
                return Vencimento;
            }
            set
            {
                
            }
        }

        public DateTime Teste { get; private set; }

        public DateTime dataPagamento;

        public DateTime DataPagamento
        {
            get
            {
                Console.WriteLine("Lendo o valor");
                return dataPagamento;
            }
            set
            {
                Console.WriteLine("Atribuindo o valor");
                dataPagamento = value;
            }
        }

        //métodos
        void Pagar()
        { }

        Address BillingAddress;
    }

    public class Address
    {
        string ZipCode;
    }
}