using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studentManagementSystems.Controllers
{
    //set admin role at global action
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}