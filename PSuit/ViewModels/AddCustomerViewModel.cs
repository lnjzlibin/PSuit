using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;

namespace PSuite.ViewModels
{
    [Export("AddCustomerViewModel", typeof(IViewModel))]
    public class AddCustomerViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public AddCustomerViewModel([Import("AddCustomerView", typeof(IView))]  IView view)
        {
            this.View = view;
            this.View.DataContext = this;

        }
    }
}
