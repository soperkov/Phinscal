using Phinscal.Models;

namespace Phinscal.Services
{
    public class OrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }
        public List<OrderModel> GetOrders()
        {
            return _context.Orders.OrderByDescending(o => o.CreatedAt).ToList();
        }

        public OrderModel? GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        public bool PlaceOrder(OrderFormModel formModel, int userId)
        {
            var newOrder = new OrderModel
            {
                DeliveryAddress = formModel.DeliveryAddress!,
                UserId = userId,
                DeliveryDate = formModel.DeliveryDate,
                PaymentMethod = formModel.PaymentMethod!,
                CardPayment = formModel.CardPayment,
                InventoryManagement = formModel.InventoryManagement,
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return true;
        }

        public void DeleteOrder(int orderId)
        {
            var order = GetOrderById(orderId);

            if (order != null) 
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }

}

