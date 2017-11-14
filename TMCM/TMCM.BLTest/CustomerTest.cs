using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMCM.BL;

namespace TMCM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Julian";
            customer.LastName = "Taylor";

            string expected = "Taylor, Julian";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();           
            customer.LastName = "Taylor";
            string expected = "Taylor";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Julian";
            string expected = "Julian";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerTypeTest()
        {
            //-- Arrange
            int i1;
            i1 = 42;

            //-- Act
            int i2 = i1;
            i2 = 2;

            //-- Assert
            Assert.AreEqual(42, i1);
        }


        [TestMethod]
        public void ObjectTypeTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Julian";

            //-- Act
            var c2 = c1;
            c2.FirstName = "JuJu";

            //-- Assert
            Assert.AreEqual("JuJu", c1.FirstName);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Julian";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "JuJu";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Beans";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Taylor";
            customer.EmailAddress = "TaylorJ@juju.me";

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer();
            customer.EmailAddress = "TaylorJ@juju.me";

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
