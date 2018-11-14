using System;
using System.Collections.Generic;
using System.Data;
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
            foreach (var item in param)
            {
                fieldNames += item.Key + ",";
                fieldValues += item.Value + ",";
            }
            fieldNames = fieldNames.Substring(0, fieldNames.Length - 1);
            fieldValues = fieldValues.Substring(0, fieldValues.Length - 1);
            return MySqlDbHelper.ExecuteSql(string.Format("insert into  {0}({1})values()",tableName,fieldNames,fieldValues));
        }
        public int Delete(int ID)
        {
            return MySqlDbHelper.ExecuteSql(string.Format("delete * from {0} where {1}={2}", tableName, tableName.Substring(2) + "_ID", ID));
        }
        public int Update(int ID, Dictionary<string, string> param)
        {
            string updateString = "";
            foreach(var item in param)
            {
                updateString += item.Key + "='" + item.Value + "',";
            }
            updateString = updateString.Substring(0, updateString.Length - 1);
            return MySqlDbHelper.ExecuteSql(string.Format("update {0} set {1} where {2}={3}",updateString, tableName, tableName.Substring(2) + "_ID", ID));
        }
        public DataTable QueryByID(int ID)
        {
            string strSQL = string.Format("select * from {0} where {1}={2}",tableName, tableName.Substring(2) + "_ID", ID);
            return MySqlDbHelper.Query(strSQL);
        }
        public DataTable QueryAll()
        {
            string strSQL = string.Format("select * from {0}", tableName);
            return MySqlDbHelper.Query(strSQL);
        }
    }
}
