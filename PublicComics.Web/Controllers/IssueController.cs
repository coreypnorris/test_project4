using PublicComics.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicComics.Web.Controllers
{
    public class IssueController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [BasicAuthentication(BasicRealm = "PublicComicsRealm")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}