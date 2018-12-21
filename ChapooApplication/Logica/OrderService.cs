using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    class OrderService
    {
        IOrderDAL orderDAL = new OrderDAL();
        IOrderItemDAL orderItemDAL = new OrderItemDAL();

        public List<OrderItem> CreateOrder(List<OrderItem> orderItems, MenuItem menuItem, string Comment, Order order)
        {
            OrderStatus orderStatus = OrderStatus.Prepare;
            foreach (OrderItem Item in orderItems)
            {
                if (Item.MenuItem.Name == menuItem.Name)
                {
                    Item.Count++;
                    return orderItems;
                }
            }
            OrderItem orderItem = new OrderItem(0, order, menuItem, 1, orderStatus, Comment);
            orderItems.Add(orderItem);

            return orderItems;
        }

        public void AddOrder(List<OrderItem> orderItems)
        {

            int OrderId = orderDAL.AddOrder(orderItems[0].Order);
            foreach (OrderItem item in orderItems)
            {
                item.Order.OrderId = OrderId;
                orderItemDAL.AddOrderItem(item);
            }
        }
    }
}
