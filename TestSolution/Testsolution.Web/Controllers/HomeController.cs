namespace Testsolution.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Entities;
    using Logic.Managers;
    using Data.Repositories;
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View("~/Views/Home.cshtml");
        }
        public ActionResult Details(int id)
        {
            //Todo don't like this need to refactor model/logic/entities
            PersonManager myPersonManager = new PersonManager(new PersonRepository());
            Person myPerson = myPersonManager.Get(id);
            return View("~/Views/Details.cshtml", myPerson);
        }
    }
}
