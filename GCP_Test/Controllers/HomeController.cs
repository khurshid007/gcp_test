using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace GCP_Test.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public void pullGit()
        {
            //string command = @"/test.cmd";  
        }
    }
}
