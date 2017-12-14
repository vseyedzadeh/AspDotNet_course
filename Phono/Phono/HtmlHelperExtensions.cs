using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phono
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString MyTextBox(this HtmlHelper htmlHelper)
        {
            return MvcHtmlString.Create("<div><input type='text' /></div>");
        } 
    }
}