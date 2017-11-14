using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMCM.BL
{
    public class Customer
    {
        private string _lastName;
        public string LastName
        {
            get
            {   
                // Any code here
                return _lastName;
            }
            set
            {
                // Any code here
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
    }
}
