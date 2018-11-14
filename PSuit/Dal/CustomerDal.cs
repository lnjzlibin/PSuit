using PSuite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuite.Dal
{
    public class CustomerDal
    {
        public int Add(Customer customer)
        {

            return MySqlDbHelper.ExecuteSql("");
        }
    }
}
