using System.Reflection;
using System.Windows.Controls;

namespace MVVMTemplateSelection
{
    public abstract class BaseDataTemplateSelector : DataTemplateSelector
    {
        public Assembly[] Assembly { get; set; }
    }
}