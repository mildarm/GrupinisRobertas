using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190521GrupinisRobertas
{
    public interface IDuombaze
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

    class CsvFailas : IDuombaze
    {
        public void DuomenuTipas()
        {
            Console.WriteLine(".csv failas");
        }

        public void GautiDuomenis()
        {
            Console.WriteLine("Siunciu duomenis");
        }

        public void SiustiDuomenis()
        {
            Console.WriteLine("Gaunu duomenis");
        }

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
            Kompiuteris pc = new Kompiuteris(new CsvFailas());
            pc.Veiksmas();
        }
    }
}
