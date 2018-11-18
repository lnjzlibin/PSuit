using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PSuit.Views
{
    [Export("QueryAllCustomerView", typeof(IView))]
    public partial class QueryAllCustomerView : UserControl,IView
    {
        public QueryAllCustomerView()
        {
            InitializeComponent();
        }
    }
}
