using Bank_App.Models;
using Bank_App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    public class CEOController : Controller
    {

          private readonly ICEOService _service;

        public CEOController(ICEOService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult IndexCEOPage()
        {
            return View();
        }
          public IActionResult ManageManagers()
        {
            return View();
        }

        public IActionResult CreateCEO()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult CreateCEO(CEO ceo)
        {
            if(ceo != null)
            {
                _service.CreateCEO(ceo);
                TempData["success"] = "Manager Created Successfully";
                return RedirectToAction(nameof(IndexCEOPage));
            }
            else
            {
                ViewBag.Error = "Wrong Input";
               return View();
            }
        }

       
         public IActionResult DeleteCEO(string ceoId)
        {            
            var ceo = _service.GetCEOById(ceoId);
            return View(ceo);          
        }

        [HttpPost , ActionName("DeleteCEO")]
        [ValidateAntiForgeryToken]
         public IActionResult DeleteCEOConfirmed(string ceoId)
        {
            _service.DeleteCEOUsingId(ceoId);
            return RedirectToAction(nameof(CEOs));
        }

          [HttpGet]
         public IActionResult UpdateCEO(string ceoId)
        {       
            if(ceoId == null)
            {
                return NotFound();
            }
            var ceo = _service.GetCEOById(ceoId);
            if(ceo == null)
            {
                return NotFound();
            }
            return View(ceo);
        }

        [HttpPost , ActionName("UpdateCEO")]
        [ValidateAntiForgeryToken]
         public IActionResult UpdateCEO(CEO ceo)
        {
            _service.UpdateCEO(ceo);
            return RedirectToAction(nameof(CEOs));
        }


         public IActionResult LogInCEO()
        {
           return View();
           
        }

        [HttpPost , ActionName("LogInCEO")]
         public IActionResult LogInConfirmed(string email,string passWord)
        {
            if(email == null || passWord == null)
            {
                return NotFound();
            }
            var manager = _service.Login(email,passWord);
            if (manager == null)
            {
                 ViewBag.Error = "Invalid Email or PassWord";
                return View();
            }
            else
            {
            return RedirectToAction(nameof(ManageManagers));
            }
           
            
        }


        
         public IActionResult CEOs()
        {
            var ceos = _service.GetAllCEO();
            return View(ceos);
        }

         
         public IActionResult CEODetails(string ceoId)
        {       
            
            var ceo = _service.GetCEOById(ceoId);
            return View(ceo);
        }
        
    }
}