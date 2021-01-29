using Interview.Model.Types;

namespace Interview.Model.Requests
{
    public class CreateCustomer
    {
        public Customer Customer { get; set; }
    }

    public class UpdateCustomer
    {
        public Customer Customer { get; set; }
    }
}