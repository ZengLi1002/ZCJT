using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZCJT.Web.Areas.Member
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Member/Default1/

        public ActionResult Index()
        {
            @{
    ViewBag.Title = "会员中心";
}

<h2>欢迎你！@User.Identity.Name 
    </h2>
            return View();
        }

    }
}
