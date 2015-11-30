using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMTemplateSelection
{
    class Lazy<T>
    {
        private readonly Func<T> _factory;
        private T val;
        public Lazy(Func<T> factory)
        {
            _factory = factory;
        }

        private bool isfactoryrunned;
        public T Value
        {get
        {
            if (!HasValue)
            {
                val = _factory();
                isfactoryrunned = true;
            }
            return val;
        }}
        public bool HasValue
        {get { return isfactoryrunned; }}

    }
}
