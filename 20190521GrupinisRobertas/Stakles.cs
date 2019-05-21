using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190521GrupinisRobertas
{
    class Stakles : IRobertas
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        

        public void DuomenuTipas()
        {
            Console.WriteLine("Stakles");
        }

        public void GautiDuomenis()
        {
            Console.WriteLine("Gaunami duomenis");
        }

        public void SiustiDuomenis()
        {
            Console.WriteLine("Siunciami duomenis");
        }
    }
}
