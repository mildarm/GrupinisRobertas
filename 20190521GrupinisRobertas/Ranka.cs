﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190521GrupinisRobertas
{
    class Ranka : IRobertas
    {

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Ranka(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void DuomenuTipas()
        {
            Console.WriteLine("Mums nesvarbu");
        }

        public void GautiDuomenis()
        {
            Console.WriteLine("Duomenis gauti");
        }

        public void SiustiDuomenis()
        {
            Console.WriteLine(" x = {0}, y = {1}, z = {2}",x,y,z);
        }
    }

}
