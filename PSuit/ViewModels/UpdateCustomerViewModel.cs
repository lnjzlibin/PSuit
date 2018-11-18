using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using System;
using PSuit.Models;
using PSuit.Bll;
using PSuit.Views;

namespace PSuit.ViewModels
{
    [Export("UpdateCustomerViewModel", typeof(IViewModel))]
    public class UpdateCustomerViewModel:ViewModelBase
    {
        public DelegateCommand UpdateCustomerCommand { get; private set; }
        private int customerID;
        private string customerName;
        private string phoneCode;
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }
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
        public UpdateCustomerViewModel([Import("UpdateCustomerView", typeof(IView))]  IView view)
        {
            this.View = view;
            this.View.DataContext = this;
            UpdateCustomerCommand = new DelegateCommand(UpdateCustomer);
        }

        private void UpdateCustomer()
        {
            CustomerService service = new CustomerService();
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            customer.CustomerName = customerName;
            customer.PhoneCode = phoneCode;
            service.UpdateCustomer(customer);
            ((UpdateCustomerView)(this.View)).Close();
        }
    }
}
