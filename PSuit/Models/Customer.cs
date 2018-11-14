using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuite.Models
{
    public   class Customer
    {
        private int customerID;
        private string customerName;
        private string phoneCode;

        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string PhoneCode
        {
            get
            {
                return phoneCode;
            }

            set
            {
                phoneCode = value;
            }
        }
    }
}
