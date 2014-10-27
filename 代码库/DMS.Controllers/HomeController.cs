using DMS.Common.Utils;
using DMS.Controllers.Core;
using DMS.IBLL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class HomeController : BaseController
    {
        [Dependency]
        public IHomeBLL homeBLL { get; set; }
        public ActionResult Index()
        {
            accountEnt = this.GetUserEnt();
            return View();
        }
    }
}
