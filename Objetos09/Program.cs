using System;

namespace Objetos09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcast

            var pessoa = new Pessoa();

            // pessoa = new PessoaFisica();
            // pessoa = new PessoaJuridica();
            
            //downcast
            var pessoaFisica = new PessoaFisica();
            var pessoaJuridica = new PessoaJuridica();

            pessoaFisica = (PessoaFisica)pessoa;
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}