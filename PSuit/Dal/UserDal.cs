using PSuite.Dal.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuite.Dal
{
    public class UserDal:BaseDal
    {
        public UserDal()
        {
            this.TableName = "T_User";
        }
    }
}
