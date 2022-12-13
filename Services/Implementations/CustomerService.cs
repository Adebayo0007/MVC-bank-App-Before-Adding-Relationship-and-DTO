using Bank_App.Models;
using Bank_App.Repositories.Interfaces;
using Bank_App.Services.Interfaces;
using MVC_MobileBankApp.Models;

namespace Bank_App.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public Customer CreateCustomer(Customer customer)
        {
              var user = new User
            {
                Email = customer.Email,
                PassWord = customer.PassWord
            };
               Random random = new Random();
                Random rand = new Random();
                customer.AccountNumber = $"{random.Next(300,700).ToString()}{random.Next(100, 900).ToString()}{rand.Next(100,400).ToString()}0";
             return  _repo.CreateCustomer(customer);  
        }

        public void DeleteCustomerUsingAccountNumber(string accountNumber)
        {
             var customer = _repo.GetCustomerByAccountnumber(accountNumber);
           _repo.DeleteCustomerUsingAccountNumber(customer);
        }

        public IList<Customer> GetAllCustomer()
        {
              return _repo.GetAllCustomer();
        }

        public Customer GetCustomerByAccountnumber(string accountNumber)
        {
            return _repo.GetCustomerByAccountnumber(accountNumber);
        }

        public Customer Login(string email, string passWord)
        {
            return _repo.Login(email,passWord);
        }

        public Customer UpdateCustomer(Customer customer)
        {
                var customerr = _repo.GetCustomerByAccountnumber(customer.AccountNumber);
            if(customerr == null )
            {
                throw new DirectoryNotFoundException();
            }
            
            customerr.FirstName = customer.FirstName ?? customerr.FirstName;
            customerr.LastName = customer.LastName ?? customerr.LastName;
            customerr.Email = customer.Email ??  customerr.Email;
            customerr.PassWord = customer.PassWord ?? customerr.PassWord;
            customerr.Age = customer.Age != customerr.Age? customer.Age : customerr.Age;
            customerr.Address = customer.Address ?? customerr.Address;
            customerr.MaritalStatus = customer.MaritalStatus;
            customerr.AccountType = customer.AccountType;
            customerr.Pin = customer.Pin ?? customerr.Pin; 
            return _repo.UpdateCustomer(customerr);
        }
    }
}