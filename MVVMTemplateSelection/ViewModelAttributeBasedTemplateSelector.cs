using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
namespace MVVMTemplateSelection
{
    /// <summary>
    ///     Template selector for <see cref="UseViewAttribute" /> marked classes
    /// </summary>
    public class ViewModelAttributeBasedTemplateSelector : BaseDataTemplateSelector
    {
        /// <summary>
        ///     ctor with assembly parameter
        /// </summary>
        /// <param name="assembly">Assembly to gettypes from</param>
        public ViewModelAttributeBasedTemplateSelector(params Assembly[] assembly)
        {
            Assembly = assembly;
        }
        /// <summary>
        ///     Default ctor use Assembly.GetCallingAssembly()
        /// </summary>
        public ViewModelAttributeBasedTemplateSelector()
            : this(AppDomain.CurrentDomain.GetAssemblies())
        {
        }
        public override DataTemplate SelectTemplate(object viewModel, DependencyObject container)
        {
            if (viewModel == null)
            {
                return base.SelectTemplate(viewModel, container);
            }
            Type viewModelType = viewModel.GetType();
            string viewTypeName = viewModelType.GetCustomAttribute<UseViewAttribute>().ViewTypeName;
            IEnumerable<Type> viewTypes = TypeSource.Types;
            foreach (Type viewType in viewTypes)
            {
                if (string.Equals(viewType.Name, viewTypeName, StringComparison.InvariantCultureIgnoreCase))
                {
                    return DataTemplateFactory.Instance.CreateByViewType(viewModelType, viewType);
                }
            }
            return base.SelectTemplate(viewModel, container);
        }
    }
}