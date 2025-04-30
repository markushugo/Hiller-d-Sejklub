namespace Hillerød_Sejklub.Models
{
    // Model for en motor
    public class Motor
    {
        private int _antalHorse;

        public int AntalHorse
        {
            get { return _antalHorse; }
            set { _antalHorse = value; }
        }

        public Motor(int antalHorse)
        {
            _antalHorse = antalHorse;
        }
    }
}

