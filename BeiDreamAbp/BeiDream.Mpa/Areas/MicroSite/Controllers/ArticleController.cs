using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeiDream.Mpa.Areas.MicroSite.Controllers
{
    public class ArticleController : Controller
    {
        // GET: MicroSite/Article
        public ActionResult Index()
        {
            return View();
        }
    }
}