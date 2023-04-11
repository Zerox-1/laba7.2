using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2
{
    abstract class Holding:IComparable
    {
        public Person Owner { get; set; } // владелец
        public double Cost { get; set; } // стоимость
        public int CompareTo(object obj)
        {
            Holding a=obj as Holding;
            if (a != null)
            {
                if(Cost < a.Cost) return -1;
                if(Cost > a.Cost) return 1;
                else return 0;
            }
            else return 1;
        }
    }
}
