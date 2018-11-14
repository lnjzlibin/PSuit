using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using PSuite.Bll;
using PSuite.Models;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;

namespace PSuite.ViewModels
{
    [Export("QueryAllCustomerViewModel", typeof(IViewModel))]
    public class QueryAllCustomerViewModel: ViewModelBase
    {

        private List<Customer> customers;
        public List<Customer> Customers
        {
            get { return customers; }
            set { SetProperty(ref customers, value); }           
        }
        [ImportingConstructor]
        public QueryAllCustomerViewModel([Import("QueryAllCustomerView", typeof(IView))]  IView view)
        {
            CustomerService service = new CustomerService();
            customers = service.QueryAllCustomer();
            
            this.View = view;
            this.View.DataContext = this;

        }

        
    }
}
