using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Domain
{
    public class Customer
    {

        private readonly string _id;
        private readonly string _name;
        private List<Order> _orders;

        public Customer(string id, string name)
        {
            _id = id;
            _name = name;
            _orders = new List<Order>();

        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> Orders
        {
            get
            {
                return _orders;
            }


        }

        public string Id { get { return _id; } }
        public string Name { get { return _name; } }

    }
}
