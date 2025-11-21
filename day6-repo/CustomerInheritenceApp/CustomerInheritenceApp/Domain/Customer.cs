using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInheritenceApp.Domain
{
    class Customer :Object
    {

        private string _id;
        private string _name;
        private string _location;
        private string _state;

        public Customer(string id, string name):this(id, name, "Noida")
        {
            //_id = id;
            //_name = name;
            //_location = "Noida";
        }

        public Customer(string id, string name, string location):this(id, name, location, "India")
        {
            //_id = id;
            //_name = name;
            //this. _location = location;
        }

        public Customer(string id, string name, string location, string state)
        {
            _id = id;
            _name = name;
            _location = location;
            _state = state;
            Console.WriteLine("Customer Created");
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }

        public string Name { get { return _name; } }
        public string Location { get { return _location; } }

        public string State { get { return _state; } }

        public override string ToString()
        {
            return $"id is {_id}, name is {_name} location is {_location} and state is {_state}";
        }
        public override bool Equals(object second)
        {
            Customer other = second as Customer; //casting
            return (this._id == other._id && this._name == other._name);
        }
    }
}
