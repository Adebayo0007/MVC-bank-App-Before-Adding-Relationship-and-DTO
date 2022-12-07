using Microsoft.AspNetCore.Mvc;
using MVC_MobileBankApp.Models;
using MVC_MobileBankApp.Services.Interfaces;

namespace MVC_MobileBankApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult IndexPage()
        {
            return View();
        }

        public IActionResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult CreateAdmin(Admin admin)
        {
            if(admin != null)
            {
                _service.CreateAdmin(admin);
                TempData["success"] = "Admin Created Successfully";
                return RedirectToAction(nameof(IndexPage));
            }
            else
            {
                ViewBag.Error = "Wrong Input";
               return View();
            }

           
            
        }

        // [HttpGet]
         public IActionResult DeleteAdmin(string staffId)
        {       
            // if(staffId == null)
            // {
            //     return NotFound();
            // }
            var admin = _service.GetAdminById(staffId);
            // if(admin == null)
            // {
            //     return NotFound();
            // }

            //  if(staffId == null)
            // {
            //     return NotFound();
            // }
            // var admin = _service.GetAdminById(staffId);
            // if(admin == null)
            // {
            //     return NotFound();
            // }

            return View(admin);          
        }

        [HttpPost , ActionName("DeleteAdmin")]
        [ValidateAntiForgeryToken]
         public IActionResult DeleteAdminConfirmed(string staffId)
        {
            _service.DeleteAdminUsingId(staffId);
            return RedirectToAction(nameof(Admins));
        }

          [HttpGet]
         public IActionResult UpdateAdmin(string staffId)
        {       
            if(staffId == null)
            {
                return NotFound();
            }
            var admin = _service.GetAdminById(staffId);
            if(admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        [HttpPost , ActionName("UpdateAdmin")]
        [ValidateAntiForgeryToken]
         public IActionResult UpdateAdmin(Admin admin)
        {
            _service.UpdateAdmin(admin);
            return RedirectToAction(nameof(Admins));
        }


         public IActionResult LogIn()
        {
           return View();
           
        }

        [HttpPost , ActionName("LogIn")]
         public IActionResult LogInConfirmed(string email,string passWord)
        {
            if(email == null || passWord == null)
            {
                return NotFound();
            }
            var admin = _service.Login(email,passWord);
            if (admin == null)
            {
                 ViewBag.Error = "Invalid Email or PassWord";
                return View();
            }
            else
            {
            return RedirectToAction(nameof(IndexPage));
            }
           
            
        }


        
         public IActionResult Admins()
        {
            var admins = _service.GetAllAdmin();
            return View(admins);
        }

        //  [HttpGet("{staffId}")]
        //  public IActionResult Details([FromQuery] Admin admin)
        // {
             
        //     var adminn = _service.GetAdminById(admin);
        //     return View(adminn);
        //     // return RedirectToAction(nameof(Admins));
        // }

          [HttpGet("{staffId}")]
         public IActionResult Details([FromRoute]string staffId)
        {       
            
            var admin = _service.GetAdminById(staffId);
            return View(admin);
        }



        
    }
}