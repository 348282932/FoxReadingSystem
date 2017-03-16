using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace FoxReadingSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FoxReadingSystemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}