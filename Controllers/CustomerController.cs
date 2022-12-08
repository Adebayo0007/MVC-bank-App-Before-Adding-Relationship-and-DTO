using Bank_App.Models;
using Bank_App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MVC_MobileBankApp.Models;

namespace Bank_App.Controllers
{
    public class CustomerController : Controller
    {
         private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        
        [HttpGet]
        public IActionResult CustomerIndexPage()
        {
            return View();
        }
         public IActionResult ManageTransaction()
        {
            return View();
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult CreateCustomer(Customer customer)
        {
            if(customer != null)
            {
                _service.CreateCustomer(customer);
                TempData["success"] = "Registration Successfully";
                return RedirectToAction(nameof(CustomerIndexPage));
            }
            else
            {
                ViewBag.Error = "Wrong Input";
               return View();
            }

           
            
        }
        
         public IActionResult DeleteCustomer(string accountNumber)
        {       
          
            var admin = _service.GetCustomerByAccountnumber(accountNumber);

            return View(admin);          
        }

        [HttpPost , ActionName("DeleteCustomer")]
        [ValidateAntiForgeryToken]
         public IActionResult DeleteCustomerConfirmed(string accountNumber)
        {
            _service.DeleteCustomerUsingAccountNumber(accountNumber);
            return RedirectToAction(nameof(Customers));
        }

          [HttpGet]
         public IActionResult UpdateCustomer(string accountNumber)
        {       
            if(accountNumber == null)
            {
                return NotFound();
            }
            var customer = _service.GetCustomerByAccountnumber(accountNumber);
            if(customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost , ActionName("UpdateCustomer")]
        [ValidateAntiForgeryToken]
         public IActionResult UpdateCustomer(Customer customer)
        {
            _service.UpdateCustomer(customer);
            return RedirectToAction(nameof(Customers));

            
            // return RedirectToAction(nameof(Customers), new Object{id = customer});
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
            var customer = _service.Login(email,passWord);
            if (customer == null)
            {
                 ViewBag.Error = "Invalid Email or PassWord";
                return View();
            }
            else
            {
            return RedirectToAction(nameof(ManageTransaction));
            }
           
            
        }
        
         public IActionResult Customers()
        {
            var customers = _service.GetAllCustomer();
            return View(customers);
        }

       

          [HttpGet]
         public IActionResult Details(string accountNumber)
        {       
            
            var customer = _service.GetCustomerByAccountnumber(accountNumber);
            return View(customer);
        }



    }
}