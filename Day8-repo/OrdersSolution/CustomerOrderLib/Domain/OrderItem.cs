using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderLib.Domain
{
    public class OrderItem
    {
        private string _id;
        private string _name;
        private double _unitprice;
        private double _quantity;

        public string Id { get { return _id; } }
            public string Name { get { return _name; } }
        
        public double Unitprice { get { return _unitprice; } }

         public double quanity {  get { return _quantity; } }   



    }
}
