using System;

namespace MVVMTemplateSelection
{
    /// <summary>
    ///     Attribute used on ViewModel Class for indicate what view is used for this VM
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class UseViewAttribute : Attribute
    {
        private readonly bool _caseSensitive;
        private readonly string _viewTypeName;


        public UseViewAttribute(string viewTypeName, bool caseSensitive = true)
        {
            _viewTypeName = viewTypeName;
            _caseSensitive = caseSensitive;
        }


        public string ViewTypeName
        {
            get { return _viewTypeName; }
        }
    }
}