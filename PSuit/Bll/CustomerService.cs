using PSuite.Dal;
using PSuite.Models;
using System.Collections.Generic;
using System.Data;

namespace PSuite.Bll
{
    public class CustomerService
    {
        private CustomerDal dal;
        public CustomerService()
        {
            dal = new CustomerDal();
        }
        public int AddCustomer(Customer customer)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Customer_Name", customer.CustomerName);
            dic.Add("Phone_Code",customer.PhoneCode);
            return dal.Add(dic);             
        }
        public int DeleteCustomer(int customerID)
        {
            return dal.Delete(customerID);
        }
        public int UpdateCustomer(Customer customer)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Customer_Name", customer.CustomerName);
            dic.Add("Phone_Code", customer.PhoneCode);
            return dal.Update(customer.CustomerID, dic);
        }
        public List<Customer> QueryAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            DataTable dt = dal.QueryAll();
            foreach (DataRow dr in dt.Rows)
            {
                Customer customer = new Customer();
                customer.CustomerID = dr.Field<int>("Customer_ID");
                customer.CustomerName = dr.Field<string>("Customer_Name");
                customer.PhoneCode = dr.Field<string>("Phone_Code");
                customers.Add(customer);
            }
            return customers;
        }
        public DataTable QueryCustomerByID(int ID)
        {
            return dal.QueryByID(ID);
        }
    }
}
