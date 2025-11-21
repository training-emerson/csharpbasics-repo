using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Domain
{
    public class Order
    {

        private readonly string _id;
        private readonly string _name;
        private readonly DateTime _date;
        private List<OrderItem> _items; 

        public Order(string id, string name, DateTime date)
        {

            _id = id;
            _name = name;
            _date = date;
            _items= new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem item)
        {

            _items.Add(item);
        }


        public List<OrderItem> OrderItems
        {

            get { return _items; }
        }
    }
}
