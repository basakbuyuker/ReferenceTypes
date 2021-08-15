using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean değer tiplerdir
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2; //sayi2'nin değeri sayi1'e atanıyor. 
            sayi2 = 100;
            Console.WriteLine("Sayı 1 : " + sayi1);


            //arrats, class, interfaces, referans tiplerdir.
            int[] sayilar1 = new int[] { 1, 2, 3 }; // adres ataması yapılıyor
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 100;
            Console.WriteLine("sayilar1[0] : " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FrstName = "başak";
            person1 = person2;// değer ataması değil adres ataması yapıyoruz
            person2.FrstName = "saniye";
            Console.WriteLine("person1 name: " + person1.FrstName);

            Customer customer = new Customer();
            customer.FrstName = "salih";
            customer.CreditCardNumber = "12345678910";


            Person person3 = customer; // customer bir person dır
            customer.FrstName = "ahmet";
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            Employee employee = new Employee();

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);
            personManager.Add(person3);

        }
    }

    class Person //base class
    {
        public int Id { get; set; }
        public string FrstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person // customer bir persondur
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FrstName);
        }
    }
}
