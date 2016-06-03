using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace BeiDream.PnSpa.Areas.MicroSite.Controllers
{
    public class ArticleController : AbpController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
