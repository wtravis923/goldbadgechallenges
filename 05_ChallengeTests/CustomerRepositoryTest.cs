using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_Challenge;


namespace _05_ChallengeTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private CustomerRepository _customerRepo;

        [TestMethod]
        public void CustomerRepository_CreateNewCustomerRecord()
        {
            //Arrange
            CustomerRepository _customerRepo = new CustomerRepository();
            Customers customer = new Customers();
            Customers customertwo = new Customers();
            Customers customerthree = new Customers();

            _customerRepo.CreateNewCustomerRecord(customer);
            _customerRepo.CreateNewCustomerRecord(customertwo);
            _customerRepo.CreateNewCustomerRecord(customerthree);

            //Act
            int actual = _customerRepo.ViewCustomerList().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerRepository_RemoveCustomerRecord()
        {
            //Arrange
            CustomerRepository _customerRepo = new CustomerRepository();
            Customers customer = new Customers();
            Customers customertwo = new Customers();
            Customers customerthree = new Customers();

            _customerRepo.CreateNewCustomerRecord(customer);
            _customerRepo.CreateNewCustomerRecord(customertwo);
            _customerRepo.CreateNewCustomerRecord(customerthree);

            _customerRepo.RemoveCustomerRecord(customer);

            //Act
            int actual = _customerRepo.ViewCustomerList().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
