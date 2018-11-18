using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows;

namespace PSuit.Views
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
