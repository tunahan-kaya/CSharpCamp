using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, double,  float, enum, boolean is values types
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100;
            Console.WriteLine(number1);

            //arrays, classes, interfaces is referance types
            int[] numbers = { 1, 2, 3 };
            int[] numbers2 = { 10, 20, 30 };
            numbers= numbers2;
            numbers2[0] = 100;
            Console.WriteLine(numbers[0]);

            Console.Read();
        }

    }
    //Base Class: Person
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) {
            Console.WriteLine(person.FirstName);
        
        }
    }
}
