using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuite.Dal.AbstractClass
{
   public abstract class BaseDal
    {
        private string tableName;

        public string TableName
        {
            get
            {
                return tableName;
            }

            set
            {
                tableName = value;
            }
        }

        public int Add(Dictionary<string, string> param)
        {
            string fieldNames = "";
            string fieldValues = "";
            return MySqlDbHelper.ExecuteSql("");
        }

    }
}
