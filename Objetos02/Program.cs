using System;

namespace Objetos02
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            Console.WriteLine(pagamentoBoleto.Vencimento);
            pagamentoBoleto.NumeroBoleto = "1234";

            //var pagamento = new Pagamento();
            //pagamento.numeroboleto
            
            var pagamento = new Pagamento();
            pagamento.ToString();

        }
    }

    class Pagamento
    {
        //propriedades
        public DateTime Vencimento;

        //métodos
        public virtual void Pagar()
        {
            //ConsularSaldoDoCartao();
        }

        // private void ConsularSaldoDoCartao()
        // {
        //     
        // }
    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

        public override void Pagar()
        {
            //Regra do boleto
        }

        public override string ToString()
        {
            return Vencimento.ToString("dd/mm/YY");
        }
    }

    class PagamentoCartaoDeCredito : Pagamento
    {
        public string Numero;
        
        public override void Pagar()
        {
            //Regra do cartão de credito
        }
    }
}

