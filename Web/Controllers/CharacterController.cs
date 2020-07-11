using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFFStats.Web.Controllers
{
    [RoutePrefix("character")]
    public class CharacterController : Controller
    {
        // GET: Character
        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}