using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PSuit.Views;
using PSuit.Bll;
using PSuit.Models;

namespace PSuit.ViewModels
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
            LogInService service = new LogInService();
            User user = new User();
            user.UserName = userName;
            user.Password = password;
            if (service.HasUserAndAuthority(user))
            {
                IViewModel shellViewModel = ServiceLocator.Current.GetInstance<IViewModel>("ShellViewModel");
                IView shellView = ServiceLocator.Current.GetInstance<IView>("ShellView");
                ((ShellView)(shellView)).Show();
                ((LogInView)(this.View)).Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("用户名或密码不正确，请重新输入");
            }
        }


    }
}
