﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
        public Table Table { get; set; }
        public int Count { get; set; }
        public bool OrderStatus { get; set; }
        public string Comment { get; set; }        

        public OrderItem()
        {

        }

        public OrderItem(Order Order, MenuItem MenuItem, int Count, Table Table, string Comment)
        {
            this.Order = Order;
            this.MenuItem = MenuItem;
            this.Count = Count;
            this.Table = Table;
            this.Comment = Comment;
        }
    }
}
