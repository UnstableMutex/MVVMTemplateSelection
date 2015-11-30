using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;

namespace Navigation.ViewModel
{
    internal class VMBase : ViewModelBase
    {
        protected static Lazy<ICommand> GetNavigationCommand<T>()
        {
            return new Lazy<ICommand>(() => new RelayCommand(() =>
                                                                 {
                                                                     SimpleIoc.Default
                                                                              .GetInstance
                                                                         <MainViewModel>()
                                                                              .ViewModel =
                                                                         SimpleIoc.Default
                                                                                  .GetInstance
                                                                             <T>();
                                                                 }
                                                ));
        }
    }
}