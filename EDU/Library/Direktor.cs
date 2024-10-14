using EDU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public class Direktor : Muellim, IDirector
    {
        public Direktor() : base()
        {

        }
        public Direktor(string name, string sname, int age, Fenn[] fenn, double maas, bool cins) : base(name, sname, age, fenn, maas, cins)
        {
        }
        public double Maas { get { return maas; } set { maas = 3000; } }

        public override double Get_gelir(double _bonus, double _gelir)
        {
            return base.Get_gelir(_bonus, _gelir);
        }
        public override void Print()
        {
            Console.WriteLine("Men Directoram: >>>>>"); base.Print();
        }
        public void IsDirector()
        {
            Console.WriteLine("Men Yeke Direktoram>>>>>>>");
        }
    }
}
