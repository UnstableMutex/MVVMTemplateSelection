using System;
using System.Windows.Input;

namespace Navigation.ViewModel
{
    internal class SampleViewModel : VMBase
    {
        private readonly Lazy<ICommand> cmd = GetNavigationCommand<OtherSampleViewModel>();

        public string SampleName
        {
            get { return GetType().Name; }
        }

        public ICommand ToOtherSampleViewModelCommand
        {
            get { return cmd.Value; }
        }
    }
}