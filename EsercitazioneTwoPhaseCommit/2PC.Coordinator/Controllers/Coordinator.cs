using _2PC.Coordinator.DTO;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _2PC.Coordinator.Controllers
{

    [ApiController]
    [Route("test")]
    public class Coordinator : Controller
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public Coordinator(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint=publishEndpoint;
        }


        [HttpPost]
        public async Task<ActionResult> Send()
        {
            await _publishEndpoint.Publish(new PrepareUpdateCustomer
            {
                Fondo=1000,
                Id=1
            });
            return StatusCode(204);
        }



    }
}
