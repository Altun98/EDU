using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public class Sinif
    {
        // sinif clasimiz ve bunun terkibinde bir nece saheler var
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Test");
                }

            }
        }

        public int Capaste;

        private Sagird[] sagirds;
        private Fenn[] fenns;
        public int FennCapaste;

        // sinifin terkibinde sagir olduqu ucun sagir clasindan bir array alir
        public Sagird[] Sagirds
        {
            get { return sagirds; }
            set
            {

                if (value.Length <= Capaste)
                {
                    sagirds = value;
                }
                else
                {
                    Console.WriteLine($"Sinifde maksimum {Capaste} nefer sagir ola biler ");
                }
            }
        }
       // sinifin kecdiyi fenler olduu ucun sinif clasinin daxilinde fenn klasindan bir array yerlesdirilir
        public Fenn[] Fenns
        {
            get { return fenns; }
            set
            {
                if (value.Length <= FennCapaste)
                {
                    fenns = value;
                }
                else
                {
                    Console.WriteLine($"Bu sinifde maksimum {FennCapaste} sayda fenn tedris edile biler");
                };
            }
        }

        public Sinif()
        {
            Capaste = 1;
            FennCapaste = 1;
        }
        public Sinif(string _name, int _capeste, Sagird[] _sagirds, int _fennCapest, Fenn[] _fenns)
        {
            this.Name = _name;
            this.Capaste = _capeste;
            this.Sagirds = _sagirds;
            this.FennCapaste = _fennCapest;
            this.Fenns = _fenns;
        }
        public void Print()
        {
           
            if (Sagirds.Length > 0)
            {
                Console.WriteLine($"Sinifin ADI:{Name}");
                Console.WriteLine("Sinife olan sagirdler:");
                for (int i = 0; i < sagirds.Length; i++)
                {  
                    sagirds[i].Print();
                }
            }
        }
    }
}
