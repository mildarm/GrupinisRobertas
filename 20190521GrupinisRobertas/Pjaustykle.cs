using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190521GrupinisRobertas
{
    class Pjaustykle: IRobertas
    {
        public int Properties { get; set; }

        public void DuomenuTipas()
        {
            Console.WriteLine("Pjaustykle");
        }

        public void GautiDuomenis()
        {
            Console.WriteLine("Gaunami duomenys");
        }

        public void SiustiDuomenis()
        {
            Console.WriteLine("Siunciami duomenys");
        }
    }
}
