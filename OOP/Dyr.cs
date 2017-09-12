namespace OOP
{
    class Dyr
    {
        private string navn;
        private int antalBen;

        // ctor
        public Dyr() : this("", 4)
        {

        }

        public Dyr(string navn, int antalBean)
        {
            this.navn = navn;
            this.antalBen = antalBean;
        }
    }
}
