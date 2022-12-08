using Bank_App.Models;
using Bank_App.Repositories.Interfaces;
using MVC_MobileBankApp.ApplicationContext;
using MVC_MobileBankApp.Models;

namespace Bank_App.Repositories.Implementations
{
    public class TransactionRepository : ITransactionRepository 
    {
        private readonly ApplicationDbContext _context;
        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Transaction CreateTransaction(Transaction transaction,Customer reciever = null)
        {
            _context.Transactions.Add(transaction);
            _context.Customers.Update(reciever);
            _context.SaveChanges();
            return transaction;
        }

        public void DeleteTransactionUsingRefNum(Transaction refNum)
        {
             _context.Transactions.Remove(refNum);
             _context.SaveChanges();
        }

        public IList<Transaction> GetAllTransaction()
        {
            return _context.Transactions.ToList();
        }

        public IList<Transaction> GetAllTransactionUsingAccountNumber(string accountNumber)
        {
            return _context.Transactions.Where(a => a.AccountNumber == accountNumber).ToList();
        }

        public Transaction GetTransactionByRefNum(string refNum)
        {
             var transaction =_context.Transactions.SingleOrDefault(a => a.RefNum == refNum);
            return transaction;
        }
    }
}