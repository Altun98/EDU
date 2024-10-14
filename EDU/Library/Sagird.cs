using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDU.Library
{
    public class Sagird
    {
        public string SagName { get; set; }
        public string SagSurname { get; set; }
        public int Age { get; set; }
        public Sagird(string _name,string _surname,int _age)
        {
            this.SagName = _name;
            this.SagSurname = _surname;
            this.Age = _age;
        }
        public void Print()
        {
            Console.WriteLine($"Sagirdin adı:= {SagName} Şagirdin soyaadı:{SagSurname} Şagirdin yaşı:{Age}");
        }
    }

}

