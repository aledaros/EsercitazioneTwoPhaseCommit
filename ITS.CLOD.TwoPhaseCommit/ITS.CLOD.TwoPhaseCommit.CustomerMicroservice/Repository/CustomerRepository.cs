using Dapper.Contrib.Extensions;
using ITS.CLOD.TwoPhaseCommit.Event.Enteties;
using Microsoft.Data.SqlClient;

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


        public Customer GetCustomer(int customerId)
        {
            Customer customer= null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                customer=connection.Get<Customer>(customerId);
            }
            return customer;
            
        }

        public void InsertCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

    }
}
