using System.Web;
using System.Web.Mvc;

namespace Katherine_Patino_Arellana
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
