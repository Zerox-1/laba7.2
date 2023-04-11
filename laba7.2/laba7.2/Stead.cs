using laba7._2.laba7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2
{
    class Stead : Holding,INalog
    {
        public double Area { get; set; } // площадь
        public Stead(Person a,double b,double area)
        {
            Owner = a;
            Cost = b;
            Area = area;
        }
        public Stead()
        {
            Owner=new Person();
            Cost = 0;
            Area = 0;
        }
        public Stead(Stead obj)
        {
            Owner = obj.Owner;
            Cost = obj.Cost;
            Area=obj.Area;
        }
        public double nalog()
        {
            if (Area >= 1000)
            { return Cost*0.3/100; }
            else
            {
                return Cost * 1.5/100;
            }
        }
    }
}
