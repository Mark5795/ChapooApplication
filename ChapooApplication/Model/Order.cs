﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public Table Table { get; set; }
        public TimeSpan OrderTime { get; set; }
        public DateTime Date { get; set; }
        public bool Paid { get; set; }
        public int PaymentMethod { get; set; }

        public Order()
        {

        }

        public Order(int OrderId, Table Table, TimeSpan OrderTime, DateTime Date, bool Paid, int PaymentMethod)
        {
            this.OrderId = OrderId;
            this.Table = Table;
            this.OrderTime = OrderTime;
            this.Date = Date;
            this.Paid = Paid;
            this.PaymentMethod = PaymentMethod;
        }

        public Order(int OrderId)
        {
            this.OrderId = OrderId;
        }
    }
}
