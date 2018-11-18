using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;

namespace PSuit.Views
{
    [Export("UpdateCustomerView", typeof(IView))]
    public partial class UpdateCustomerView : Window,IView
    {
        public UpdateCustomerView()
        {
            InitializeComponent();
        }
    }
}
