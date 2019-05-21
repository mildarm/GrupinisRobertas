namespace _20190521GrupinisRobertas
{
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
}
