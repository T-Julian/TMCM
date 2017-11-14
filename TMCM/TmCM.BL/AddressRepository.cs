using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMCM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the requested Id
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard coded values to return 
            // a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "JuJu";
                address.StreetLine2 = "Beans";
                address.City = "Chicago";
                address.State = "IL";
                address.Country = "United States";
                address.PostalCode = "7414";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.


            // Temporary hard coded values to return 
            // a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "JuJu",
                StreetLine2 = "Beans",
                City = "Chicago",
                State = "IL",
                Country = "United States",
                PostalCode = "74"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Phoenix",
                City = "IL",
                State = "Chicago",
                Country = "United States",
                PostalCode = "7414"
            };
            addressList.Add(address);

            return addressList;
        }


        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // Code that saves the defined address

            return true;
        }
    }
}
