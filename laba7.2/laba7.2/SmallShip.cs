using laba7._2.laba7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2
{
    class SmallShip : Transport,INalog
    {
        public int Paddle { get; set; } // количество вёсел в лодке
        public double Power { get; set; } // мощность двигателя в л.с.
        public SmallShip()
        {
            Owner = new Person();
            Cost = 0;
            Paddle = 0;
            Power = 0;
            Name = "";
            Capacity = 0;
        }
        public SmallShip(Person a, double b, int c,double d, string e, double f)
        {
            Owner = a;
            Cost = b;
            Paddle = c;
            Power = d;
            Name = e;
            Capacity = f;
        }
        public double nalog()
        {
            if (Power < 100) return Power * 10;
            else if (Power < 300) return Power * 20;
            else return Power * 200;
        }
    }
}
