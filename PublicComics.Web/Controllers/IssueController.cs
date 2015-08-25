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
        private PublicComicsDb _db = new PublicComicsDb();

        public ActionResult Index()
        {
            var issues = _db.Issues;
            return View(issues);
        }

        [BasicAuthentication(BasicRealm = "PublicComicsRealm")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}