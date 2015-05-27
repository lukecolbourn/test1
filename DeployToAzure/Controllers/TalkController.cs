using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeployToAzure.Controllers
{
    public class TalkController : Controller
    {
        //
        // GET: /Talk/
        public ActionResult Index()
        {
            return View(Messaging.MessageStorage.GetTenMessages());
        }
	}
}