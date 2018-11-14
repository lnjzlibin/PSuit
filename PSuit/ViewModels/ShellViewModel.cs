using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.ServiceLocation;
using PSuite.Views;
using System.Windows;
using System.Windows.Controls;
using System;
using PSuite.Models;

namespace PSuite.ViewModels
{
    [Export("ShellViewModel", typeof(IViewModel))]
    public class ShellViewModel : ViewModelBase
    {
        public DelegateCommand AddOrderCommand { get; private set; }
        public DelegateCommand QueryOrderCommand { get; private set; }
        public DelegateCommand AddCustomerCommand { get; private set; }
        public DelegateCommand QueryCustomerCommand { get; private set; }
        public DelegateCommand ExitCommand { get; private set; }

        [ImportingConstructor]
        public ShellViewModel([Import("ShellView", typeof(IView))]  IView view)
        {
            this.View = view;           
            this.View.DataContext = this;
            AddOrderCommand = new DelegateCommand(AddOrder);
            QueryOrderCommand = new DelegateCommand(QueryOrder);
            AddCustomerCommand = new DelegateCommand(AddCustomer);
            QueryCustomerCommand = new DelegateCommand(QueryCustomer);

            ExitCommand = new DelegateCommand(Exit);
        }
        public void AddOrder()
        {
            OpenTabItem("MainTabControl", "销售订单录入", "AddOrderView");

        }
        public void QueryOrder()
        {
            OpenTabItem("MainTabControl", "销售订单查询", "QueryOrderView");
        }
        public void AddCustomer()
        {
            OpenTabItem("MainTabControl", "客户信息录入", "AddCustomerView");
        }
        public void QueryCustomer()
        {
            OpenTabItem("MainTabControl", "客户信息查询", "QueryCustomerView");
        }
        private void OpenTabItem(string tabControlName, string tabItemName, string viewName)
        {
            
           
            TabControl tc = ((TabControl)(((ShellView)(this.View)).FindName(tabControlName)));
            if (!HasTabItem(tc, tabItemName))
            {
                TabItem ti = new TabItem();
                ti.Header = tabItemName;
                ti.Content = ServiceLocator.Current.GetInstance<IView>(viewName);
                tc.Items.Add(ti);
                tc.SelectedItem = ti;
            }  
           
        }
        private bool HasTabItem(TabControl tc, string tabItemName)
        {
            foreach (TabItem item in tc.Items)
            {
                if (item.Header.ToString().Equals(tabItemName))
                {
                    tc.SelectedItem = item;
                    return true;
                }
            }
            return false;
        }
        public void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
