using PSuite.Dal.AbstractClass;
using PSuite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuite.Dal
{
    public class CustomerDal:BaseDal
    {
        public CustomerDal()
        {
            this.TableName = "T_Customer";
        }
        
    }
}
