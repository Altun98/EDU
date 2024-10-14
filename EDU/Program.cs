using EDU.Library;
using System.Security.Cryptography;

namespace EDU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Evvelki

            Fenn f = new Fenn();//susmaya gore ana dili 
            Fenn f1 = new Fenn("Riyaziyyat");
            Fenn f3 = new Fenn("Biologiya");
            Fenn f4 = new Fenn("Kimya");
            Fenn f5 = new Fenn("Tarix");
            Fenn f6 = new Fenn("Fizika");
            Fenn f7 = new Fenn("Informatika");
            Fenn f8 = new Fenn("Coqrafiya");
            Fenn f9 = new Fenn("Musiqi");
            Fenn f10 = new Fenn("Texnologiya"); 
            //    f.Print();
            //    f1.Print();
            //    Teskilatci m = new Teskilatci();
            //    m.Name = "Mirmecid";
            //    m.Sname = "Hesimov";
            //    m.Age = 34;
            //    m.Cins = true;
            //    m.Maas = 5555;
            //    m.fenn = new Fenn[] { f, f1 };
            //    m.Print();

            //    Direktor m2 = new Direktor();
            //    m2.Name = "Mirmecid";
            //    m2.Sname = "Hesimov";
            //    m2.Age = 34;
            //    m2.Cins = true;
            //    m2.Maas = 5555;
            //    m2.fenn = new Fenn[] { f };
            //    m2.Print();

            //=====================
            #endregion

            // sagirdlerin siyahisi 
            #region Sagirdler
            Sagird s1 = new Sagird("Eltac", "Hesenov", 16);
            Sagird s2 = new Sagird("Qehraman", "Qabiyev", 16);
            Sagird s3 = new Sagird("Ismayil", "Ismayilov", 17);
            Sagird s4 = new Sagird("Hesen", "Memmedli", 15);
            Sagird s5 = new Sagird("Arzu", "Memmedova", 16);
            Sagird s6 = new Sagird("Gunay", "Hesenli", 16);
            Sagird s7 = new Sagird("Samire", "Qasimova", 17);
            Sagird s8 = new Sagird("Xedice", "Eliyeve", 15);
            Sagird s9 = new Sagird("Gozel", "Haciyeva", 16);
            Sagird s10 = new Sagird("Aysel", "Memmedova", 16);
            Sagird s11 = new Sagird("Afiq", "Abbasov", 17);
            Sagird s12 = new Sagird("Dadas", "Dasliyev", 15);
            Sagird s13 = new Sagird("Murad", "Muradov", 16);
            Sagird s14 = new Sagird("Gunduz", "Xelilov", 16);
            Sagird s15 = new Sagird("Eli", "Eliyev", 17);
            Sagird s16 = new Sagird("Nurlan", "Hesenzade", 15);
            #endregion

            Sagird[] sg = new Sagird[] { s1, s2 };
            Sagird[] sg1 = new Sagird[] { s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16 };
            //Siniflerin siyahisi 
            // her sinifin terkibinde birden cox sagird ve fen kecirile bilir
            #region Sinifler
            Sinif A10 = new Sinif();
            A10.Name = "10-A sinifi";
            A10.Capaste = 2;
            A10.Sagirds = sg;
            A10.FennCapaste = 5;
            A10.Fenns = new Fenn[] { f1, f, f5, f4, f3 };
            Sinif B10 = new Sinif();
            B10.Name = "10-B sinifi";
            B10.Capaste = 16;
            B10.Sagirds = sg1;
            B10.FennCapaste = 5;
            B10.Fenns = new Fenn[] { f1, f, f5 };

            #endregion

            Muellim m1 = new Muellim();
            m1.Name = "Nihad";
            m1.Sname = "Izzetli";
            m1.Age = 34;
            m1.Cins = true;
            m1.Maas = 2333;
            m1.fenn = new Fenn[] { f, f1 };
            m1.Sinifs = new Sinif[] { B10 };
            m1.Print();


        }
    }
}
