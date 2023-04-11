using laba7._2.laba7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2
{
    class Horse : Transport,INalog
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public Horse()
        {
            Owner = new Person();
            Cost = 0;
            Age = 0;
            Weight = 0;
            Name = "";
            Capacity = 0;
        }
        public Horse(Person a, double b = 0, int c = 0, double d = 0, string e = "", double f = 0)
        {
            Owner = a;
            Cost = b;
            Age = c;
            Weight = d;
            Name = e;
            Capacity = f;
        }
        public Horse(Horse obj)
        {
            Owner = obj.Owner;
            Cost = obj.Cost;
            Age = obj.Age;
            Weight = obj.Weight;
            Name = obj.Name;
            Capacity = obj.Capacity;
        }
        public double nalog()
        {
            return 200;
        }
    }
}
