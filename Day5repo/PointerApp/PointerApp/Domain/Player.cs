using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerApp.Domain
{
    class Player
    {
        private string _name;
        private int _age;
        private int _matches;
        private static int _counter = 0;

        public Player(string _name, int _age, int _matches)
        {
            this._age = _age;
            this._name = _name;
            this._matches = _matches;
            _counter += 1;
        }

        public Player WhoIsElder(Player secondPlayer)
        {
            if (secondPlayer._age < this._age)
            {
                return secondPlayer;
            }
            return this;
        }
        


        public static int GetHeadCount()
        {
            return _counter;
        }

        public int Counter
        {

            get { return _counter; }
        }
        public int Age
        {
            get
            {
                return _age;
            }

        }
        public string Name
        {
            get { return _name; }

        }
        public int Matches
        {
            get
            {
                return _matches;
            }

        }




    }
}
