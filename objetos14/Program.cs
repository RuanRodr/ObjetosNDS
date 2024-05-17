using System;

namespace objetos14
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Payment> payments = new List<Payment>();
            // payments.Add(new Payment(1));
            // payments.Add(new Payment(2));
            // payments.Add(new Payment(3));
            // payments.Add(new Payment(4));
            // payments.Add(new Payment(5));

            //payments.ToList();
            //payments.AsEnumerable();
            //payments.ToArray();


            // foreach (var item in payments)
            // {
            //     Console.WriteLine(item.Id);
            // }
            //
            // var payment = payments.First(x => x.Id == 3);
            // Console.WriteLine(payment.Id);
            //
            // payments.Remove(payment);
            //
            // foreach (var item in payments)
            // {
            //     Console.WriteLine(item.Id);
            // }




            // var paidPayments = new List<Payment>();
            // paidPayments.AddRange(payments);

            //IEnumerable<Payment> payments = new List<Payment>();

            //IList<Payment> payments = new List<Payment>();

            //payments.Add(new Payment(1));
            //payments.Remove(new Payment());


            //var lista = new List<string>();
            //IEnumerable<string> lista = new List<string>();

        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}
