using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePersonBMI.Domain
{
    internal class Person
    {
        //attributes

        private string _personname;
        private float _age;
        private float _weight; // in Kgs
        private float _height; // in cms
        private const float MaxWeight = 500f;
        private const float MinWeight = 10f;
        private const float MaxHeight = 200f;
        private const float MinHeight = 30f;
        private bool _PersonOnExercise;
        private bool _PersonOnFastFood;


        public string Name
        {
            get
            {
                return _personname;
            }
            set
            {
                _personname = value;
            }
        }
        public float Height
        {
            get
            {
                return _height;
            }
            set 
            { 
                _height = SanitizeHeight(value); 
            }

           }

        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                    _weight = SanitizeWeight(value);
            }
        }

        public float BMI()
        {
            return _weight * 10000 / (_height*_height);

        }
        public float Exercise()
        {
            return _weight - 10;

        }
        public float Eat()
        {
            return _weight + 20;

        }

        public float SanitizeWeight(float chars)
        {
            if (chars<MinWeight)
               return MinWeight;
            if (chars>MaxWeight)
                return MaxWeight;
            return chars;
        
        }

        public float SanitizeHeight(float charac)
        {
            if (charac < MinHeight)
                return MinHeight;
            if (charac > MaxHeight)
                return MaxHeight;
            return charac;

        }
    }
}
