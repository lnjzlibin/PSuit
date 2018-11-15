using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.ServiceLocation;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using PSuite.Bll;
using PSuite.Models;
using PSuite.Views;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;

namespace PSuite.ViewModels
{
    [Export("QueryAllCustomerViewModel", typeof(IViewModel))]
    public class QueryAllCustomerViewModel: ViewModelBase
    {
        public DelegateCommand AddCustomerCommand { get; private set; }


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
            AddCustomerCommand = new DelegateCommand(AddCustomer);
            this.View = view;
            this.View.DataContext = this;
        }
        public void AddCustomer()
        {
            IViewModel addCustomerViewModel = ServiceLocator.Current.GetInstance<IViewModel>("AddCustomerViewModel");
            IView addCustomerView = ServiceLocator.Current.GetInstance<IView>("AddCustomerView");
            ((AddCustomerView)(addCustomerView)).Show();
            //OpenTabItem("MainTabControl", "客户信息录入", "AddCustomerView");
        }
    }
}
