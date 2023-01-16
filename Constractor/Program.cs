 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer(2,"Tunahan","Kaya","Bursa");
            Customer customer2 = new Customer { FirstName = "Esin", LastName = "Kaya", Id = 1, City = "Bursa" };
            Console.WriteLine(customer2.FirstName);

           
            Console.Read();
        }
    }

    class Customer
    {
        public Customer() //default constractor
        {
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
