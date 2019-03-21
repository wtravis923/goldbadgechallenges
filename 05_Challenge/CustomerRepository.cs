using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class CustomerRepository
    {
        //Creating our list <based on props & ctors found in <Customers> and naming it _customerList.
        private List<Customers> _customerList = new List<Customers>(); 

        //Allowing user to perform method to create a new customer record and add to our _customerList. 
        public void CreateNewCustomerRecord(Customers customers)
        {
            _customerList.Add(customers);
        }

        //Allowing user to view entries added to _customerList. 
        public List<Customers> ViewCustomerList()
        {
            //alphabetize by first name.
            _customerList.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
            return _customerList; 
            
        }

        //Allowing user to remove customer records from list. 
        public void RemoveCustomerRecord(Customers customers)
        {
            _customerList.Remove(customers);
        }

        //Allows system to send confirmation message once a record has been expunged. 
        public bool RemoveCustomerRecord(int customerID)
        {
            bool successful = false; 
            foreach (Customers customers in _customerList)
            {
                if (customers.CustomerID == customerID)
                {
                    RemoveCustomerRecord(customers);
                    successful = true;
                    break; 
                }
            }

            return successful; 
        }

        //Hopefully this allows user to update a customer record by selecting the record by ID, removing it, then re-adding it. 

        public bool UpdateCustomerRecord(int CustomerID)
        {
            bool successful = true; 

            return successful; 
        }

        public void UpdateCustomerFirstName(int customerID, string newFirstName)
        {
            _customerList.Where(w => w.CustomerID == customerID).ToList().ForEach(s => s.FirstName = newFirstName);
        }

        public void UpdateCustomerLastName(int customerID, string newLastName)
        {
            _customerList.Where(w => w.CustomerID == customerID).ToList().ForEach(s => s.LastName = newLastName);
        }

        public void UpdateCustomerType(int customerID, CustomerType type, string email)
        {
            _customerList.Where(w => w.CustomerID == customerID).ToList().ForEach(s => s.CustomerType = type);
            _customerList.Where(w => w.CustomerID == customerID).ToList().ForEach(s => s.Email = email);
        }



    }
}
