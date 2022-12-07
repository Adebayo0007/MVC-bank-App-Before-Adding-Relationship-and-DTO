using Bank_App.Models;
namespace MVC_MobileBankApp.Repositories
{
    public interface ICEORepository
    {
        CEO CreateCEO(CEO ceo);
        CEO UpdateCEO(CEO ceo);
       void DeleteCEOUsingCEOId(CEO ceoId);
       CEO Login(string email, string passWord);
       CEO GetCEOById(string ceoId);
       IList<CEO> GetAllCEO(); 

    }
}