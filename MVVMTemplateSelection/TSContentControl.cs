using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace MVVMTemplateSelection
{
    // ReSharper disable once InconsistentNaming
   public class TSConvContentControl:ContentControl
    {
        static readonly ConventionTemplateSelector ts = new ConventionTemplateSelector();
        public TSConvContentControl()
        {
            ContentTemplateSelector = ts;
        }
    }
}
