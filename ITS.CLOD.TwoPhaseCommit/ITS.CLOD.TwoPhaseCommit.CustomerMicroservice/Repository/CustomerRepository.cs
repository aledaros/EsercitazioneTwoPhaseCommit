using ITS.CLOD.TwoPhaseCommit.Event.Enteties;

namespace ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Repository
{
    public class CustomerRepository
    {


        public readonly string _connectionString;
        public readonly IConfiguration _configuration;
        public CustomerRepository(IConfiguration configuration)
        {
            _configuration= configuration;
            _connectionString=_configuration.GetConnectionString("AzureDb");
        }


        public Customer GetCustomer(int id)
        {

        }

        public void InsertCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

    }
}
