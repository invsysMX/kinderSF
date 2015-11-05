using System.Web;
using System.Web.Mvc;

namespace Invsys.Software.Web.KinderSF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
