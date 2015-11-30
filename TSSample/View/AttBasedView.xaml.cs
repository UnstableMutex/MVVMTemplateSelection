using System.Windows.Controls;
using MVVMTemplateSelection;

namespace TSSample.View
{
    /// <summary>
    ///     Логика взаимодействия для AttBasedView.xaml
    /// </summary>
    [ViewFor("MainViewModel")]
    public partial class AttBasedView : UserControl
    {
        public AttBasedView()
        {
            InitializeComponent();
        }
    }
}