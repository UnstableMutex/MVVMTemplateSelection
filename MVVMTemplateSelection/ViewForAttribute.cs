using System;

namespace MVVMTemplateSelection
{
    /// <summary>
    ///     Attribute used on View Class for indicate that this view is used for VM in class argument
    /// </summary>
    /// <remarks>allow multiple need to be enabled</remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ViewForAttribute : Attribute
    {
        private readonly bool _caseSensitive;
        private readonly string _viewModelTypeName;


        public ViewForAttribute(string viewModelModelTypeName, bool caseSensitive = true)
        {
            _viewModelTypeName = viewModelModelTypeName;
            _caseSensitive = caseSensitive;
        }

        /// <summary>
        ///     gets associated ViewModel type name (short)
        /// </summary>
        public string ViewModelTypeName
        {
            get { return _viewModelTypeName; }
        }
    }
}