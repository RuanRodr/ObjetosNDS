using System;

namespace Objetos05
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento.Vencimento = DateTime.Now;
        }
    }

    public static class Pagamento 
    {
        //static n pode ser instanciada
        
        public static DateTime Vencimento { get; set; }
    }
}