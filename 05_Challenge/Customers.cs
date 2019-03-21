using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public enum CustomerType { Current = 1, Potential, Past }

    public class Customers
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType CustomerType { get; set; }
        public string Email { get; set; }

        public Customers(int customerID, string firstName, string lastName, CustomerType customerType, string email)
        {
            CustomerID = customerID; 
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CustomerType = customerType;
        }

        public Customers() { }

    }
}
