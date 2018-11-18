using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.AbstractClass;
using System.ComponentModel.Composition;

namespace PSuit.ViewModels
{
    public class QueryCustomerViewModel:ViewModelBase
    {
        [ImportingConstructor]
        public QueryCustomerViewModel([Import("QueryCustomerView", typeof(IView))]  IView view)
        {
            this.View = view;
            this.View.DataContext = this;

        }
    }
}
