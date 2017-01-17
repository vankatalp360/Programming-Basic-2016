using System.Web;
using System.Web.Mvc;

namespace Рейтинг_визуализация
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
