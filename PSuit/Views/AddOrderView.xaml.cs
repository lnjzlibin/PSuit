using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PSuite.Views
{
    [Export("AddOrderView", typeof(IView))]
    public partial class AddOrderView : UserControl,IView
    {
        public AddOrderView()
        {
            InitializeComponent();
            //SXXXXX XXXX XX XX XXX XX
        }
    }
}
