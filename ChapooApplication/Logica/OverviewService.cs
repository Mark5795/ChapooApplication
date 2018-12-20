using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    class OverviewService
    {
        IOverviewDAL overviewDAL = new OverviewDAL();

        public List<OrderItem> OrderItemList(Function function)
        {
            List<OrderItem> orderItems = overviewDAL.GetOrderItemsForOverview(function);
            return orderItems;
        }

    }
}
