using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows;

namespace PSuite.Views
{
    [Export("ShellView", typeof(IView))]
    public partial class ShellView : Window,IView
    {
        public ShellView()
        {
            InitializeComponent();
        }

    }
}
