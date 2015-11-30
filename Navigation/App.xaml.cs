using System.Reflection;
using System.Windows;
using MVVMTemplateSelection;

namespace Navigation
{
    /// <summary>
    ///     Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            TypeSource.AddAssembly(Assembly.GetExecutingAssembly());
        }
    }
}