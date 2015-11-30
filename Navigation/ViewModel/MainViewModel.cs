using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace Navigation.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private object _viewModel;

        public MainViewModel()
        {
            ViewModel = SimpleIoc.Default.GetInstance<SampleViewModel>();
        }

        public object ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                RaisePropertyChanged(() => ViewModel);
            }
        }
    }
}