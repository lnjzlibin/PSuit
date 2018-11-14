using Microsoft.Practices.Prism.Mvvm;
using PSuit.Infrastructure.Abstract.Presentation.Interface;

namespace PSuit.Infrastructure.Abstract.Presentation.AbstractClass
{
    public abstract class ViewModelBase : BindableBase, IViewModel
    {
        public IView View { get; protected set; }
    }
}
