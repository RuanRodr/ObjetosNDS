using System;

namespace Objetos10
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa(1, "Ruan");
            var pessoaB = new Pessoa(1, "Ruan");
            
            //Console.WriteLine(pessoa.Id == pessoaB.Id);
            //Console.WriteLine(pessoa == pessoaB);
            Console.WriteLine(pessoa.Equals(pessoaB));


        }
    }
    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public string Nome { get; set; }

        public int Id { get; set; }

        public bool Equals(Pessoa pessoa)
        {
            return Id == pessoa.Id;
        }
        
    }
}