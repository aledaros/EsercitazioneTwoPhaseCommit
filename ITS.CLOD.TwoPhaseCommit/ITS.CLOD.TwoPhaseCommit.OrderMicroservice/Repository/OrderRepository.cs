using Dapper.Contrib.Extensions;
using ITS.CLOD.TwoPhaseCommit.Event.Enteties;
using Microsoft.Data.SqlClient;

namespace ITS.CLOD.TwoPhaseCommit.OrderMicroservice.Repository
{
    public class OrderRepository
    {


        public readonly string _connectionString;
        public readonly IConfiguration _configuration;
        public OrderRepository(IConfiguration configuration)
        {
            _configuration= configuration;
            _connectionString=_configuration.GetConnectionString("AzureDb");
        }


        public Order GetOrder(int orderId)
        {
            Order order = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                order=connection.Get<Order>(orderId);
            }
            return order;

        }

        public void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
