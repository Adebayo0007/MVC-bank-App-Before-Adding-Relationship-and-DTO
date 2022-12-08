using Bank_App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MVC_MobileBankApp.Models;
namespace Bank_App.Controllers
{
    public class TransactionController : Controller
    {
         private readonly ITransactionService _transactionService;
         private readonly ICustomerService _customerService;

        public TransactionController(ITransactionService transactionService, ICustomerService customerService)
        {
            _transactionService = transactionService;
            _customerService = customerService;
        }

         [HttpGet]
        public IActionResult IndexTransactionPage()
        {
            return View();
        }
        

        public IActionResult CreateTransaction()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult CreateTransaction(Transaction transaction,string reciever)
        {
            if(transaction != null)
            {
                _transactionService.CreateTransaction(transaction,reciever);
                TempData["success"] = "Transaction Successfully";
                return RedirectToAction(nameof(IndexTransactionPage));
            }
            else
            {
                ViewBag.Error = "Wrong Input";
               return View();
            }
        }

       
        //  public IActionResult DeleteManager(string managerId)
        // {            
        //     var manager = _service.GetManagerById(managerId);
        //     return View(manager);          
        // }

        // [HttpPost , ActionName("DeleteManager")]
        // [ValidateAntiForgeryToken]
        //  public IActionResult DeleteManagerConfirmed(string managerId)
        // {
        //     _service.DeleteManagerUsingId(managerId);
        //     return RedirectToAction(nameof(IndexManagerPage));
        // }

        //   [HttpGet]
        //  public IActionResult UpdateManager(string managerId)
        // {       
        //     if(managerId == null)
        //     {
        //         return NotFound();
        //     }
        //     var manager = _service.GetManagerById(managerId);
        //     if(manager == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(manager);
        // }

        // [HttpPost , ActionName("UpdateManager")]
        // [ValidateAntiForgeryToken]
        //  public IActionResult UpdateManager(Manager manager)
        // {
        //     _service.UpdateManager(manager);
        //     return RedirectToAction(nameof(Managers));
        // }


        //  public IActionResult LogInManager()
        // {
        //    return View();
           
        // }

        // [HttpPost , ActionName("LogInManager")]
        //  public IActionResult LogInConfirmed(string email,string passWord)
        // {
        //     if(email == null || passWord == null)
        //     {
        //         return NotFound();
        //     }
        //     var manager = _service.Login(email,passWord);
        //     if (manager == null)
        //     {
        //          ViewBag.Error = "Invalid Email or PassWord";
        //         return View();
        //     }
        //     else
        //     {
        //     return RedirectToAction(nameof(ManageAdmins));
        //     }
           
            
        // }


        
        //  public IActionResult Managers()
        // {
        //     var managers = _service.GetAllManager();
        //     return View(managers);
        // }

         
        //  public IActionResult ManagerDetails(string managerId)
        // {       
            
        //     var manager = _service.GetManagerById(managerId);
        //     return View(manager);
        // }


        
    }
}