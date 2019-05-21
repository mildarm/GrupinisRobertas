using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190521GrupinisRobertas
{
    interface IDuombaze
    {
        void GautiDuomenis(); // Gauna duomenis is DB
        void SiustiDuomenis();// Siuncia i DB
        void DuomenuTipas();// 
    }

    interface IRobertas
    {
        void GautiDuomenis(); // Gauna duomenis is DB
        void SiustiDuomenis();// Siuncia i DB
        void DuomenuTipas();// 
    }


    public class Kompiuteris
    {
        private IDuombaze duombaze;

        public Kompiuteris(IDuombaze dbaze)
        {
            duombaze = dbaze;
        }

        public void Veiksmas()
        {
            duombaze.GautiDuomenis();
            duombaze.SiustiDuomenis();
            duombaze.DuomenuTipas();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
