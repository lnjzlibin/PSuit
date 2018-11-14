using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PSuite.Views
{
    [Export("QueryCustomerView", typeof(IView))]
    public partial class QueryCustomerView : UserControl,IView
    {
        public QueryCustomerView()
        {
            InitializeComponent();
        }
    }
}
