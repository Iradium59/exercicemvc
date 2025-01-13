using ExerciceMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceMVC.Controllers
{
    public class ContactsController : Controller
    {
        private static List<Contact> contacts = new List<Contact>
        {
            new Contact { Id = 1, Name = "Alice Dupont", Email = "alice@example.com", Phone = "0102030405" },
            new Contact { Id = 2, Name = "Bob Martin", Email = "bob@example.com", Phone = "0605040302" },
            new Contact { Id = 3, Name = "Charlie Durand", Email = "charlie@example.com", Phone = "0708091011" }
        };

        public IActionResult Index()
        {
            ViewData["Title"] = "Liste des Contacts";
            return View(contacts);
        }

        public IActionResult Details(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
                return NotFound();

            ViewBag.ContactName = contact.Name;
            return View(contact);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            contact.Id = contacts.Max(c => c.Id) + 1;
            contacts.Add(contact);
            return RedirectToAction("Index");
        }
    }
}
