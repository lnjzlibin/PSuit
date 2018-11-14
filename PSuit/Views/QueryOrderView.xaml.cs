using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PSuite.Views
{
    [Export("QueryOrderView", typeof(IView))]
    public partial class QueryOrderView : UserControl, IView
    {
        public QueryOrderView()
        {
            InitializeComponent();
        }
    }
}
