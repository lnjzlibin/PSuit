using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PSuite.Views
{
    [Export("UpdateCustomerView", typeof(IView))]
    public partial class UpdateCustomerView : UserControl,IView
    {
        public UpdateCustomerView()
        {
            InitializeComponent();
        }
    }
}
