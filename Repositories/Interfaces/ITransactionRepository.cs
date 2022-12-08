using Bank_App.Models;
using MVC_MobileBankApp.Models;

namespace Bank_App.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction CreateTransaction(Transaction transaction,Customer reciever);
       void DeleteTransactionUsingRefNum(Transaction refNum);
       Transaction GetTransactionByRefNum(string refNum);
       IList<Transaction> GetAllTransactionUsingAccountNumber(string accountNumber);
       IList<Transaction> GetAllTransaction(); 
    }
}