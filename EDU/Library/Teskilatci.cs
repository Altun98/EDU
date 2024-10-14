using EDU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public class Teskilatci : Muellim, IManager
    {
        public Teskilatci() : base()
        {

        }
        public Teskilatci(string name, string sname, int age, Fenn[] fenn, double maas, bool cins) : base(name, sname, age, fenn, maas, cins)
        {

        }

        public void IDo()
        {
            Console.WriteLine("Men tedbirleri teskil ediremmmm");
        }

        public void IsManager()
        {
            Console.WriteLine("Men teskilatci Zavucammmmm");
        }
        public double Maas { get { return maas; } set { maas = 2444; } }

        public override double Get_gelir(double _bonus, double _gelir)
        {
            return base.Get_gelir(_bonus, _gelir);
        }
        public override void Print()
        {
            Console.WriteLine("Men teskilatciyam: >>>>>"); base.Print();
        }
    }
}
