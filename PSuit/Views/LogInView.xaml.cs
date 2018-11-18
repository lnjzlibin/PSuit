using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows;

namespace PSuit.Views
{
    [Export("LogInView", typeof(IView))]
    public partial class LogInView : Window,IView
    {
        public LogInView()
        {
            InitializeComponent();
        }
    }
}
