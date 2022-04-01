using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class VPEkzamen : Ispitanie
    {
        int ocenka;
        public VPEkzamen(int ocenka, string name, int sb) : base(name, sb)
        {
            this.ocenka = ocenka;
        }
        public override void Vivod()
        {
            Console.WriteLine("{0} сдал выпускной экзамен на {1} ", name, ocenka);
        }
    }
}
