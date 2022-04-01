using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Ispitanie[] p = new Ispitanie[5];
            p[0] = new Ispitanie("Иванов И.И.", 5);
            p[1] = new Test(2, "Петров П.П.", 7);
            p[2] = new Ekzamen(6, "Иванов", 5, "ЗКИ");
            p[3] = new Ispitanie("Петров П.П.", 7);
            p[4] = new VPEkzamen(5, "Петров", 7);
            foreach (var item in p)
            {
                item.Vivod();
            }
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Узнать сдал ли тест {0}\n1-да 2-нет", p[1].name);
            int y = int.Parse(Console.ReadLine());
            if (y == 1)
                p[1].Proverka();
            Console.WriteLine();
            Console.WriteLine("Узнать сдал ли {0} экзамен\n1-да 2-нет", p[2].name);
            y = int.Parse(Console.ReadLine());
            if (y == 1)
                p[2].Proverka();
            Console.WriteLine();
            Console.WriteLine($"Сравнить средний балл за семестр {p[0].name} и {p[3].name}\n1-да 2-нет");
            y = int.Parse(Console.ReadLine());
            if (y == 1)
            {
                Console.WriteLine($"Средние баллы\nИванов: {p[0].sb}\nПетров: {p[3].sb}");
                if (p[0].Equals(p[3]))
                    Console.WriteLine("Значение равны");
                else
                    Console.WriteLine("Не равны");
            }
            Console.ReadKey();
        }

    }
}
