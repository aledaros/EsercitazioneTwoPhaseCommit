﻿using ITS.CLOD.TwoPhaseCommit.Event.Entities.DTO;
using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace ITS.CLOD.TwoPhaseCommit.Cordinator.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public readonly IPublishEndpoint _endpoint;
        public Guid TransactionId;
        public CoordinatorController(IPublishEndpoint endpoint)
        {
            _endpoint=endpoint;
        }

        [HttpPost]
        [Route("/coordinator/insertOrder")]
        public async Task<IActionResult> InsertOrder(InsertOrderDto insertOrder)
        {
            TransactionId=Guid.NewGuid();
            await _endpoint.Publish(new PrepareUpdateCustomer(TransactionId, insertOrder.Fund, insertOrder.CustomerId));

            return Ok();
        }
    }
}
