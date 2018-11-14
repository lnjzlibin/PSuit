using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PSuite.Views;

namespace PSuite.ViewModels
{
    [Export("LogInViewModel", typeof(IViewModel))]
    public class LogInViewModel : ViewModelBase
    {
        public DelegateCommand LogInCommand { get; private set; }
        private string userName;
        private string password;


        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        [ImportingConstructor]
        public LogInViewModel([Import("LogInView", typeof(IView))]  IView view)
        {
            this.View = view;           
            this.View.DataContext = this;
            LogInCommand = new DelegateCommand(LogIn);
        }
        
        public void LogIn()
        {

            IViewModel shellViewModel = ServiceLocator.Current.GetInstance<IViewModel>("ShellViewModel");
            IView shellView = ServiceLocator.Current.GetInstance<IView>("ShellView");
           ((ShellView)(shellView)).Show();
            ((LogInView)(this.View)).Visibility = Visibility.Collapsed;
        }


    }
}
