using System.Windows;
using Prism.Mef;
using PSuit.Infrastructure.Abstract.Presentation.Interface;
using System.ComponentModel.Composition.Hosting;
using PSuite.Views;
using Prism.Regions;

namespace PSuite
{
    public class QuickStartBootstrapper: MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            IViewModel logInViewModel = this.Container.GetExportedValue<IViewModel>("LogInViewModel");
            
            return logInViewModel.View as DependencyObject;
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (LogInView)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            //加载自己
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(this.GetType().Assembly));
        }
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            return base.ConfigureRegionAdapterMappings();
        }
    }
}
