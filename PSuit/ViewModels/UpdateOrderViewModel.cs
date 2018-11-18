using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSuit.ViewModels
{
    [Export("UpdateCustomerViewModel", typeof(IViewModel))]
    public class UpdateOrderViewModel:ViewModelBase
    {
        [ImportingConstructor]
        public UpdateOrderViewModel([Import("UpdateOrderView", typeof(IView))]  IView view)
        {
            this.View = view;
            this.View.DataContext = this;

        }
    }
}
