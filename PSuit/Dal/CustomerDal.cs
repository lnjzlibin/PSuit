using PSuit.Dal.AbstractClass;
using PSuit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuit.Dal
{
    public class CustomerDal:BaseDal
    {
        public CustomerDal()
        {
            this.TableName = "T_Customer";
        }
        
    }
}
