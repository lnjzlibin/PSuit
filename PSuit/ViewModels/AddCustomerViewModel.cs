using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using System;
using PSuite.Bll;
using PSuite.Models;

namespace PSuite.ViewModels
{
    [Export("AddCustomerViewModel", typeof(IViewModel))]
    public class AddCustomerViewModel : ViewModelBase
    {
        public DelegateCommand AddCustomerCommand { get; private set; }

        [ImportingConstructor]
        public AddCustomerViewModel([Import("AddCustomerView", typeof(IView))]  IView view)
        {
            AddCustomerCommand = new DelegateCommand(AddCustomer);
            this.View = view;
            this.View.DataContext = this;
        }

        private void AddCustomer()
        {
            CustomerService service = new CustomerService();
            Customer customer = new Customer();
            customer.CustomerName = "";
            customer.PhoneCode = "";
            service.AddCustomer(customer);
        }
    }
}
