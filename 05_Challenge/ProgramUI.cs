using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    class ProgramUI
    {
        //you've got to actually call the List<Customers> here.
        private List<Customers> _customerList;
        private CustomerRepository _customerRepo = new CustomerRepository();
        Customers _customer = new Customers(); 
        //private CustomerType customerType = new ;


        //Constructors for the ProgramUI; items that create when an instance of the UI is initialized. 
        public ProgramUI()
        {
            _customerRepo = new CustomerRepository(); 
            _customerList = _customerRepo.ViewCustomerList(); 
        }

        public void Run()
        {
            bool running = true; 
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Komodo Insurance. What would you like to do?\n" +
                    "1. Create Customer Record\n" +
                    "2. View Customer Records\n" +
                    "3. Edit Customer Records\n" +
                    "4. Remove Customer Records\n" +
                    "5. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        CreateNewCustomerRecord();
                        break;
                    case 2:
                        ViewCustomerList();
                        break;
                    case 3:
                        UpdateCustomerRecord();
                        break;
                    case 4:
                        RemoveCustomerRecord();
                        break;
                    case 5:
                        running = false;
                        break; 
                }
            }
        }

        private void CreateNewCustomerRecord()
        {
            Console.Clear();

            Console.WriteLine("Enter the four digit customer ID:");
            int customerID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the customer's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the customer's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Select the type of customer:\n" +
                "1. Current Customer\n" +
                "2. Potential Customer\n" +
                "3. Past Customer");

            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

            string email;
            CustomerType type = new CustomerType();
            switch (input)
            {
                default: 
                case 1:
                    type = CustomerType.Current;
                    email = "Thank you for your loyalty. Here is a coupon!";
                    break;
                case 2:
                    type = CustomerType.Potential;
                    email = "You know what's better than saving 15% or more? Saving 20% or more! Join Komodo insurance now!";
                    break;
                case 3:
                    type = CustomerType.Past;
                    email = "Baby, come back!";
                    break; 
            }

            Customers customersToList = new Customers(customerID, firstName, lastName, type, email);

            _customerRepo.CreateNewCustomerRecord(customersToList);
            Customers current = new Customers();
        }

        private void ViewCustomerList()
        {
            Console.Clear();
            List<Customers> customers = _customerRepo.ViewCustomerList();

            Console.WriteLine(" ID      FirstName     LastName    Type        Email");
            foreach (Customers Customers in customers)
            {
                Console.WriteLine($" {Customers.CustomerID}    {Customers.FirstName}        {Customers.LastName}      {Customers.CustomerType}     {Customers.Email}");  
           
            }
            Console.WriteLine("Press return to continue...");
            Console.ReadLine(); 
        }

        private void RemoveCustomerRecord()
        {
            Console.Clear();
            List<Customers> customers = _customerRepo.ViewCustomerList();

            Console.WriteLine(" ID      FirstName     LastName    Type        Email");
            foreach (Customers Customers in customers)
            {
                Console.WriteLine($" {Customers.CustomerID}    {Customers.FirstName}        {Customers.LastName}      {Customers.CustomerType}     {Customers.Email}");

            }

            Console.WriteLine("What is the ID number of the customer you would like to remove?");
            int id = int.Parse(Console.ReadLine());

            bool success = _customerRepo.RemoveCustomerRecord(id);
            if (success == true)
            {
                Console.WriteLine($"Record successfully removed. Press return to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Record was unable to be removed at this time. Check data and try again. Press return to continue.");
                Console.ReadLine();
            }
        }
       
        public void UpdateCustomerRecord()
        {
            Console.Clear();
            ViewCustomerList();

            Console.WriteLine("What is the ID number of the customer you would like to update?");
            int id = int.Parse(Console.ReadLine());

            bool success = _customerRepo.UpdateCustomerRecord(id);
            if (success == true)
            {
                Console.WriteLine("Which field would you like to update?\n" +
                    "1. First Name\n" +
                    "2. Last Name\n" +
                    "3. Customer Type");

                int inputAsString = int.Parse(Console.ReadLine());

                switch (inputAsString)
                {
                    case 1:
                        Console.WriteLine("Enter the customer's first name:");
                        string newFirstName = Console.ReadLine();
                        _customerRepo.UpdateCustomerFirstName(id, newFirstName);
                        break;

                    case 2:
                        Console.WriteLine("Enter the customer's last name:");
                        string newLastName = Console.ReadLine();
                        _customerRepo.UpdateCustomerLastName(id, newLastName);

                        break;

                    case 3:
                        Console.WriteLine("Select the type of customer:\n" +
                        "1. Current Customer\n" +
                        "2. Potential Customer\n" +
                        "3. Past Customer");

                        string newInputAsString = Console.ReadLine();
                        int input = int.Parse(newInputAsString);

                        string newEmail;
                        CustomerType newType = new CustomerType();
                        switch (input)
                        {
                            default:
                            case 1:
                                newType = CustomerType.Current;
                                newEmail = "Thank you for your loyalty. Here is a coupon!";
                                break;
                            case 2:
                                newType = CustomerType.Potential;
                                newEmail = "You know what's better than saving 15% or more? Saving 20% or more! Join Komodo insurance now!";
                                break;
                            case 3:
                                newType = CustomerType.Past;
                                newEmail = "Baby, come back!";
                                break;
                        }
                        _customerRepo.UpdateCustomerType(id, newType, newEmail);

                        break;
                }


            }

        }
    }

}