using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MRShop.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MRShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}