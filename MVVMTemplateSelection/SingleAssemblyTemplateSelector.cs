using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MVVMTemplateSelection
{
    /// <summary>
    ///     Template selector for convention based class names without attributes
    /// </summary>
    public class ConventionTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            const string vmEnding = "ViewModel";
            const string vEnding = "View";
            if (item == null)
            {
                return base.SelectTemplate(item, container);
            }
            Type t = item.GetType();
            string typeName = t.Name.ToLower();
            if (typeName.EndsWith(vmEnding.ToLower()))
            {
                string name = t.Name.Substring(0, t.Name.Length - vmEnding.Length);
                string viewName = name + vEnding;
                IEnumerable<Type> viewTypes = TypeSource.Types;
                Type viewType = viewTypes.FirstOrDefault(x => x.Name == viewName);
                if (viewType == null)
                {
                    return base.SelectTemplate(item, container);
                }
                return DataTemplateFactory.Instance.CreateByViewType(t, viewType);
            }
            return base.SelectTemplate(item, container);
        }
    }
}