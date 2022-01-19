using ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Repository;
using ITS.CLOD.TwoPhaseCommit.Event.Enteties;

namespace ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Service
{
    public class CustomerService
    {

        public readonly CustomerRepository _customerRepository;

        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository=customerRepository;
        }

        public Customer GetCustomer(int customerId)
        {
            return _customerRepository.GetCustomer(customerId);

        }

        public void InsertCustomer(Customer customer)
        {
            _customerRepository.InsertCustomer(customer);   
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }


    }
}
