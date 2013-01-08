using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace System
{
    public static class HtmlHelpers
    {
        public static void ResolveFileWithCacheString(this HtmlHelper htmlHelper, string filePath)
        {
            var phantomString = DateTime.Now.Ticks;
            var scriptString = "<script type='text/javascript' src='{0}?{1}'/>";
            htmlHelper.Raw(String.Format(scriptString, filePath, phantomString));
        }

       
    }
}
