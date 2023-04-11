using laba7._2.laba7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2
{
    class Car : Transport,INalog
    {
        public double Power { get; set; } // мощность двигателя в л.с.
        public Car()
        {
            Owner = new Person();
            Cost = 0;
            Power = 0;
            Name = "";
            Capacity = 0;
        }
        public Car(Person a,double b,double c,string d,double e)
        {
            Owner = a;
            Cost = b;
            Power = c;
            Name = d;
            Capacity = e;
        }
        public Car(Car obj)
        {
            Owner = obj.Owner;
            Cost = obj.Cost;
            Power = obj.Power;
            Name = obj.Name;
            Capacity = obj.Capacity;
        }
        public double nalog()
        {
            if (Power < 100) return Power * 2.5;
            else if (Power < 150) return Power * 3.5;
            else if (Power < 200) return Power * 5;
            else if (Power < 250) return Power * 7.5;
            else if (Power < 410) return Power * 15;
            else return Power * 300;
        }
    }
}
