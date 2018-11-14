using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition;

namespace PSuite.ViewModels
{
    [Export("UpdateCustomerViewModel", typeof(IViewModel))]
    public class UpdateCustomerViewModel:ViewModelBase
    {
        [ImportingConstructor]
        public UpdateCustomerViewModel([Import("UpdateCustomerView", typeof(IView))]  IView view)
        {
            this.View = view;
            this.View.DataContext = this;

        }
    }
}
