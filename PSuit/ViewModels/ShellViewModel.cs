using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.ServiceLocation;
using PSuit.Views;
using System.Windows;
using System.Windows.Controls;
using System;
using PSuit.Models;

namespace PSuit.ViewModels
{
    [Export("ShellViewModel", typeof(IViewModel))]
    public class ShellViewModel : ViewModelBase
    {
        public DelegateCommand AddOrderCommand { get; private set; }
        public DelegateCommand QueryOrderCommand { get; private set; }
        public DelegateCommand QueryAllOrderCommand { get; private set; }
        public DelegateCommand QueryCustomerCommand { get; private set; }
        public DelegateCommand QueryAllCustomerCommand { get; private set; }
        public DelegateCommand ExitCommand { get; private set; }

        [ImportingConstructor]
        public ShellViewModel([Import("ShellView", typeof(IView))]  IView view)
        {
            this.View = view;           
            this.View.DataContext = this;
            AddOrderCommand = new DelegateCommand(AddOrder);
            QueryOrderCommand = new DelegateCommand(QueryOrder);
            QueryAllOrderCommand = new DelegateCommand(QueryAllOrder);
           
            QueryCustomerCommand = new DelegateCommand(QueryCustomer);
            QueryAllCustomerCommand = new DelegateCommand(QueryAllCustomer);

            ExitCommand = new DelegateCommand(Exit);
        }
        public void AddOrder()
        {
            //OpenTabItem("MainTabControl", "销售订单录入", "AddOrderView");

        }
        public void QueryOrder()
        {
            //OpenTabItem("MainTabControl", "销售订单查询", "QueryOrderView");
        }
        public void QueryAllOrder()
        {
            OpenTabItem("MainTabControl", "销售订单管理", "QueryAllOrderView");
        }
        
        public void QueryCustomer()
        {
            //OpenTabItem("MainTabControl", "客户信息查询", "QueryCustomerView");
        }
        public void QueryAllCustomer()
        {
            IViewModel queryAllCustomerViewModel = ServiceLocator.Current.GetInstance<IViewModel>("QueryAllCustomerViewModel");
            OpenTabItem("MainTabControl", "客户信息管理", "QueryAllCustomerView");
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
