using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestPartialView.Models;

namespace TestPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TextBoxBinding objTextboxBindings = new TextBoxBinding();
            return View(objTextboxBindings); // Returning model
        }

        [ChildActionOnly]
        public ActionResult _TestIndex(TextBoxBinding viewModel)
        {
            return PartialView("_TestIndex", viewModel);
        }

        [HttpPost]
        public ActionResult _TestIndex(TextBoxBinding viewModel, string garbage)
        {

            viewModel.ValueHolders.Add(new ValueHolder { ID = viewModel.ID, ValueProperty = viewModel.Name });
            return PartialView("_TestIndex", viewModel);
        }

        [HttpPost]
        public ActionResult GetData(string[] names)
        {



            return View();
        }
    }
}