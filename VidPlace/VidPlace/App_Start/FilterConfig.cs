using System.Web;
using System.Web.Mvc;

namespace VidPlace
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //add this line to put authorization for all pages
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
