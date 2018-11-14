using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PSuite.Views
{
    [Export("UpdateOrderView", typeof(IView))]
    public partial class UpdateOrderView : UserControl,IView
    {
        public UpdateOrderView()
        {
            InitializeComponent();
        }
    }
}
