using System;
using System.Windows;

namespace MVVMTemplateSelection
{
    internal class DataTemplateFactory
    {
        private static readonly Lazy<DataTemplateFactory> _instance =
            new Lazy<DataTemplateFactory>(() => new DataTemplateFactory());

        private DataTemplateFactory()
        {
        }

        public static DataTemplateFactory Instance
        {
            get { return _instance.Value; }
        }

        public DataTemplate CreateByViewType(Type viewModelType, Type viewType)
        {
            var dt = new DataTemplate(viewModelType);
            var factory = new FrameworkElementFactory(viewType);
            dt.VisualTree = factory;
            return dt;
        }
    }
}