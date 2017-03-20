using LibDatabase.InterfaceEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskRepository _repository;

       

        public HomeController(ITaskRepository repository)
        {
            this._repository = repository;
        }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(_repository.TasksAll());
        }
	}
}