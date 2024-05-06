using System;

namespace Objetos08
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new PagamentoBoleto();
            
        }
    }

    public class PagamentoCartaodeCredito : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }


    public abstract class Pagamento : IPagamento //control + .
    {
        public DateTime Vencimento { get; set; }
        
        public virtual void Pagar(double valor)
        {
            //executar
        }
    }
    
    public interface IPagamento
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
}

