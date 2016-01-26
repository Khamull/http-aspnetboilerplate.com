using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace sample.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : sampleControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}