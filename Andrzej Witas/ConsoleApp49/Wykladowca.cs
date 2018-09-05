using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    public class Wykladowca : BazaOsoba, IOsob
    {
        private int numerLegitymacji;
        private string tytulNaukowy;

        public Wykladowca(string a, string b, int c, int d, int x, string y)
            : base(a, b, c, d)
        {
            this.NumerLegitymacji = x;
            this.TytulNaukowy = y;
        }

        public int NumerLegitymacji { get => numerLegitymacji; set => numerLegitymacji = value; }
        public string TytulNaukowy { get => tytulNaukowy; set => tytulNaukowy = value; }

        public override string ToString() //dokonczyc
        { 
            string temp1 = "Wykładowca to ";
            string temp2 = imie + " " + nazwisko + " " + wiek + " " + pesel + " " + numerLegitymacji + " " + tytulNaukowy;
            return temp1 + temp2;
        }
    }
}
