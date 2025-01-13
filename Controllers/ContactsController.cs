using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceMVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Je suis la page pour afficher les contacts...");
        }

        public IActionResult Details(int id)
        {
            return Content($"Je suis la page pour afficher le contact avec l'ID : {id}...");
        }

        public IActionResult Add()
        {
            return Content("Je suis la page pour ajouter un contact...");
        }
    }
}
