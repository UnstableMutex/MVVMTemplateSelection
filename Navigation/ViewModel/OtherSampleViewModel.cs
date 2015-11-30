using System;
using System.Windows.Input;

namespace Navigation.ViewModel
{
    internal class OtherSampleViewModel : VMBase
    {
        //not inherited from viewmodelbase - it's just sample

        private readonly Lazy<ICommand> cmd = GetNavigationCommand<SampleViewModel>();

        public string OtherSampleName
        {
            get { return GetType().Name; }
        }

        public ICommand ToSampleViewModelCommand
        {
            get { return cmd.Value; }
        }
    }
}