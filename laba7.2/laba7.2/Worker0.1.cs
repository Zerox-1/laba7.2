using laba7._2.laba7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7_2;

internal class Worker:Person,INalog
{
    public double Salary { get; set; }
    public int Bonus { get; set; }
    public Worker() : this("noname", "", new DateTime(), 'м', 0, 0) { }
    public Worker(string fn, string sn, DateTime d, char s, double sal, int p) : base(fn, sn, d, s)
    {
        Salary = sal;
        Bonus = p;
    }
    // весь заработок = оклад + премия
    public double TotalPay()
    {
        return Salary * (1 + Bonus / 100.0);
    }
    public double nalog()
    {
        return TotalPay()*0.13;
    }
}
