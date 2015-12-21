using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace MVVMTemplateSelection
{
    public class ViewAttibuteBasedTemplateSelector : BaseDataTemplateSelector
    {
        public ViewAttibuteBasedTemplateSelector(params Assembly[] assembly)
        {
            Assembly = assembly;
        }

        public ViewAttibuteBasedTemplateSelector()
            : this(AppDomain.CurrentDomain.GetAssemblies())
        {
        }

        /// <summary>
        ///     select template for datatype
        /// </summary>
        /// <param name="item">ViewModel class instance</param>
        /// <param name="container"></param>
        /// <returns></returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return base.SelectTemplate(item, container);
            }
            Type viewModelType = item.GetType();
            string loweredViewModelTypeName = viewModelType.Name.ToLower();
            IEnumerable<Type> viewTypes = TypeSource.Types;
            viewTypes = viewTypes.Where(x => x.Name.EndsWith("View"));
            foreach (Type viewType in viewTypes)
            {
                var att = viewType.GetCustomAttribute<ViewForAttribute>();
                if (att != null)
                {
                    if (string.Equals(att.ViewModelTypeName, loweredViewModelTypeName,
                                      StringComparison.InvariantCultureIgnoreCase))
                    {
                        return DataTemplateFactory.Instance.CreateByViewType(viewModelType, viewType);
                    }
                }
            }
            return base.SelectTemplate(item, container);
        }
    }
}