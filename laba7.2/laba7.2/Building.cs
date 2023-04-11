using laba7._2.laba7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2
{
    class Building : Holding,INalog
    {
        public string Address { get; set; } // адрес
        public Building(Person a,double b,string address="")
        {
            Owner = a;
            Cost=b;
            Address = address;
        }
        public Building()
        {
            Owner=new Person();
            Cost=0;
            Address = "";
        }
        public Building(Building obj)
        {
            Owner=obj.Owner;
            Cost=obj.Cost;
            this.Address = obj.Address;
        }
        public double nalog()
        {
            return Cost*0;
        }
    }
}
