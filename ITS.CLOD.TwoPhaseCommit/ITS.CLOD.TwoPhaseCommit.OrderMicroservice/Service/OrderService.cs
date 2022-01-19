using ITS.CLOD.TwoPhaseCommit.Event.Enteties;
using ITS.CLOD.TwoPhaseCommit.OrderMicroservice.Repository;

namespace ITS.CLOD.TwoPhaseCommit.OrderMicroservice.Service
{
    public class OrderService
    {
        public readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository=orderRepository;
        }

        public Order Getorder(int orderId)
        {
            return _orderRepository.GetOrder(orderId);

        }

        public void Insertorder(Order order)
        {
            _orderRepository.InsertOrder(order);
        }

        public void Updateorder(Order order)
        {
            _orderRepository.UpdateOrder(order);
        }



    }
}
