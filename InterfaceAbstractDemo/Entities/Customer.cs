using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entites
{
    internal partial class Program
    {
        class Customer:IEntity
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalityID { get; set; }
        }
    }
}
