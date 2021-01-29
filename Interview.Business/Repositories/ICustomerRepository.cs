using System.Collections.Generic;
using Interview.Model.Types;

namespace Interview.Business.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string id);

        List<Customer> GetCustomers();
    }
}
