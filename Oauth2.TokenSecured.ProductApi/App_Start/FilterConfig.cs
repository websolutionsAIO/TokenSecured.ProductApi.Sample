using System.Web;
using System.Web.Mvc;

namespace Oauth2.TokenSecured.ProductApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
