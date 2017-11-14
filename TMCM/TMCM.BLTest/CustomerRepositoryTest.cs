using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMCM.BL;
using System.Collections.Generic;

namespace TMCM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "JTaylorJ@juju.me",
                FirstName = "Julian",
                LastName = "Taylor"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepositorty = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "JTaylorJ@juju.me",
                FirstName = "Julian",
                LastName = "Taylor",
                AddressList = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "JuJu",
                            StreetLine2 = "Beans",
                            City = "Chicago",
                            State = "IL",
                            Country = "United States",
                            PostalCode = "74"
                        },
                        new Address()
                        {
                            AddressType = 2,
                            StreetLine1 = "Phoenix",
                            City = "Chicago",
                            State = "IL",
                            Country = "United States",
                            PostalCode = "7414"
                        }
                    }
            };


            //-- Act
            var actual = customerRepositorty.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}
