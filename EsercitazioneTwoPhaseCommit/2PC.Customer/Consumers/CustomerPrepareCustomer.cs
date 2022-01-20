using _2PC.Coordinator.DTO;
using Dapper;
using MassTransit;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using _2PC.Customer.Entities;

namespace _2PC.Customer.Consumers
{
    public class CustomerPrepareCustomer : IConsumer<PrepareUpdateCustomer>
    {

        string _connectionString = "";
        public IConfiguration _configuration;
        public CustomerPrepareCustomer(IConfiguration configuration)
        {

            _configuration = configuration;
            _connectionString= _configuration.GetConnectionString("AzureDb");
        }
        public Task Consume(ConsumeContext<PrepareUpdateCustomer> context)
        {


            using var connection = new SqlConnection(_connectionString);

            const string query = @"SELECT 
      [fondo]
  FROM[dbo].[Customer]
where Id=@id";
            var customerFund = connection.QueryAsync<Customers>(query, new
            {
                id = context.Message.Guid
            });


            return customerFund;

        }
    }
}

