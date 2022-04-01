using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Ispitanie
    {
        public string name;
        public int sb;
        public Ispitanie(string name, int sb)
        {
            this.name = name;
            this.sb = sb;
        }
        virtual public void Vivod()
        {
            Console.WriteLine($"{name} средний балл за семестр: {sb}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Ispitanie temp = (Ispitanie)obj;
            return sb == temp.sb;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public virtual void Proverka()
        {

        }
    }
    
}
