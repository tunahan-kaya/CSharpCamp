using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar1=new int[] {1,2,3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 100;
            //Console.WriteLine("sayilar1[0]: " + sayilar1[0]);

            Customer customer = new Customer();
            customer.FirstName = "Tunahan";
            customer.LastName = "Kaya";
            customer.CreditCardNumber = "1234567890";


            Person person = new Person();
            person.FirstName = "Furkan";
            PersonManager personManager = new PersonManager();

           // Console.WriteLine(((Customer)person).CreditCardNumber);
            personManager.Add(person);

            Console.Read();
        }
    }

    class Person
    {
        public int İd { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    } 

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("eklendi: "+person.FirstName);
        }
    }
}
