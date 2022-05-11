using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterCRUD.Controllers
{
    public class OrdersController : Controller
    {
        masterEntities db = new masterEntities();
        public ActionResult Index()
        {
            return View();
        }
    }
}