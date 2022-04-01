using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Ekzamen : Ispitanie
    {
        string ter;
        int ocenka;
        public Ekzamen(int ocenka, string name, int sb, string ter) : base(name, sb)
        {
            this.ter = ter;
            this.ocenka = ocenka;
        }
        public override void Vivod()
        {
            Console.WriteLine($"{name} сдал экзамен на {ocenka} по {ter}");
        }
        public override void Proverka()
        {
            if (ocenka >= 4)
                Console.WriteLine($"{name} сдал экзамен на {ocenka}");
            else
                Console.WriteLine(name + " не сдал экзамен, оценка " + ocenka);
        }
    }
}
