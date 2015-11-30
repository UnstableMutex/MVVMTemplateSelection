using System.Windows;
using System.Windows.Controls;

namespace MVVMTemplateSelection
{
    public class ComposedDataTemplateSelector : DataTemplateSelector
    {
        private readonly ConventionTemplateSelector conventionTemplateSelector = new ConventionTemplateSelector();

        private readonly ViewAttibuteBasedTemplateSelector viewAttibuteBasedTemplateSelector =
            new ViewAttibuteBasedTemplateSelector();

        private readonly ViewModelAttributeBasedTemplateSelector viewModelAttributeBasedTemplateSelector =
            new ViewModelAttributeBasedTemplateSelector();

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate dt = conventionTemplateSelector.SelectTemplate(item, container);
            if (dt != null)
                return dt;
            dt = viewAttibuteBasedTemplateSelector.SelectTemplate(item, container);
            if (dt != null)
                return dt;
            dt = viewModelAttributeBasedTemplateSelector.SelectTemplate(item, container);
            if (dt != null)
                return dt;
            return base.SelectTemplate(item, container);
        }
    }
}