﻿using System;

namespace Objetos13
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();
            
            var context = new DataContext<IPerson, Payment, Subscription>();

            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
        }
    }

    public class DataContext<T, PA, S> //ordena
        where T : IPerson
        where PA : Payment
        where S : Subscription
    {
        public void Save(T entity)
        { }
        public void Save(PA entity)
        { }
        public void Save(S entity)
        { }
    }

    public interface IPerson
    { }

    public class Person : IPerson
    { }

    public class Payment
    { }

    public class Subscription
    { }
}

