using System.Web.Mvc;
using DoubleSave.ExternalServices;
using DoubleSave.Models;

namespace DoubleSave.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration registration)
        {
            if (ModelState.IsValid)
            {
                var service = new SomeExternalService();
                var confirmationStuff = service.Save(registration.Name, registration.CreditCardNumber);

                registration.PaymentConfirmation = confirmationStuff.PaymentConfirmation;
                registration.RegistrationConfirmation = confirmationStuff.RegistrationConfirmation;

                return View("Confirmation", registration);
            }

            return View("Index", registration);
        }
    }
}