using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using System;
using PSuit.Bll;
using PSuit.Models;
using PSuit.Views;

namespace PSuit.ViewModels
{
    [Export("AddCustomerViewModel", typeof(IViewModel))]
    public class AddCustomerViewModel : ViewModelBase
    {
        public DelegateCommand AddCustomerCommand { get; private set; }

        private string customerName;
        private string phoneCode;

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string PhoneCode
        {
            get
            {
                return phoneCode;
            }

            set
            {
                phoneCode = value;
            }
        }
        
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
            customer.CustomerName =customerName;
            customer.PhoneCode = phoneCode;
            service.AddCustomer(customer);
            ((AddCustomerView)(this.View)).Close();
        }
    }
}
