using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Test : Ispitanie
    {
        int ocenka;
        public Test(int ocenka, string name, int sb) : base(name, sb)
        {
            this.ocenka = ocenka;

        }
        public override void Vivod()
        {
            Console.WriteLine($"{name} получил за итоговый тест {ocenka} ");
        }
        public override void Proverka()
        {
            if (ocenka >= 4)
                Console.WriteLine(name + " сдал тест\nОтметка за тест: " + ocenka);
            else
                Console.WriteLine(name + " не сдал тест\nОценка за тест: " + ocenka);
        }

    }
}
