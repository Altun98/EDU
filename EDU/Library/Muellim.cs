using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public class Muellim
    {
        //muellim clasinin terkibinde propert ve mueyyen metodlar var bele ki
        //bu propertiler public,private ve protected olaraq isarelenib ki buda bizim el catanliqmizi
        // mueyyen menada nezaretde saxlayir
        public int id { get; private set; }
        private string name;
        private string sname;
        private int age;
        public Fenn[] fenn;
        private Sinif[] sinifs;
        protected double maas;
        // cins propertisinin deyerini sadece oxumaqa icaze verilib
        public bool cins { get; private set; }
        //Cisn propertisinine deyer vermeye imkan yaradilib.
        public bool Cins
        {
            set { cins = value; }
        }

        // muellim clasinin boss konustructoru yaradilib ve mueyyen deyerler verilib 
        // en esasi muellim clasindan instans alindiqi anda hemin mellime fen verilmese 
        //muellim avtomatik olaraq riyyaziyyat muellimi kimi faliyyete baslayacaq.
        public Muellim()
        {
            this.id = Tool.get_id();
            this.name = "Muellim";
            this.sname = "Muellim";
            this.age = 24;
            var f = new Fenn("Riyaziyyat");
            this.fenn = new Fenn[1] { f };

        }
        //Muellim clasinin dolu konustruktoru
        public Muellim(string name, string sname, int age, Fenn[] fenn, double maas, bool cins)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.fenn = fenn;
            this.maas = maas;
            this.cins = cins;

        }
        //id nin deyerini sadece oxumaq mumkun olacaq 
        public int Id
        {
            get { return id; }
        }
        //Name deyerini rahatliqla oxumaq olacaq lakin muyyen sertler odendikden sonra
        //ona deyer vermek mumkun olacaq en azi uzunluqu 0 dan boyuk olacaq eger bu sert odenmese 
        // Name Test1 menimesedilecek
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    name = "Test1";
                }

            }
        }
        // Sname rahatliqla oxunaca deyer verildikde ise uzunluqu
        // 5 den boyuk deyilse ona Hemidli deyeri menimsedilecek
        public string Sname
        {
            get { return sname; }
            set
            {
                if (value.Length > 5)
                {
                    sname = value;
                }
                else
                {
                    sname = "Hemidli";
                }
            }

        }
        // Age nin deyeri rahatliqla oxunacaq lakin ona deyer verilende mueyyen setler daxilinde 
        // verilecek yeni  23 den boyuk ve 65 den kicik bu sert odenmedikde avtomatik olaraq 23 menimsedilecek
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 23 && value <= 65)
                {
                    age = value;
                }
                else
                {
                    age = 23;
                }
            }
        }
        // eger bu mellimin kecdiyi fenler hemin sinife tedris olunursa burada eks edilecekj 
        public Sinif[] Sinifs
        {
            get { return sinifs; }
            set
            {
                sinifs = value;
            }

        }

        //maas deyerine yeni deyer verildikde o 250 den boyuk 2800 den kicik olmalidir eks halda 251 olaraq verilecek
        public double Maas
        {
            get { return maas; }
            set
            {
                if (value > 250 && value < 2800)
                {
                    maas = value;
                }
                else
                {
                    maas = 251;
                }
            }
        }
        // Muellimin gelirini hesablamaq ucun virtual metod yatadilib ki daha sonra
        //muellim clasindan mirasliq almis klaslarda xususi ehtiyaclara gore ovverride edilsin
        public virtual double Get_gelir(double _bonus, double _gelir)
        {
            return maas + (_bonus * _gelir);
        }
        // Print metodu vasitesile melumatlarin cixarilmasi isi gorulecek
        public virtual void Print()
        {
            string Gender = "Qadin";
            if (cins) Gender = "kisi";
            Console.WriteLine($"Muellim ID={id} Name={name} Surname={sname} Age={age}" +
                $"gender={Gender} gelir={maas} ");
            if (fenn.Length > 0)
            {
                Console.WriteLine("Kecdiyi fenler:");
                for (int i = 0; i < fenn.Length; i++)
                {
                    fenn[i].Print();
                }
            }
            if (sinifs.Length > 0)
            {

                for (int i = 0; i < sinifs.Length; i++)
                {
                    sinifs[i].Print();
                }
            }

        }
    }
}
