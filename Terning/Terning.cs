using System;

namespace Terning
{
    class Terning
    {
        public int vaerdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            this.vaerdi = 1;
            snyd = false;
        }

        public Terning(bool snyd)
        {
            this.vaerdi = 1;
            this.snyd = snyd;
        }

        public void Skriv()
        {
            Console.WriteLine("["+vaerdi+"]");
        }

        public void Ryst()
        {
            if (!this.snyd)
            {
                this.vaerdi = rnd.Next(1, 7);
            }
            else
            {
                this.vaerdi = 6;
            }
        }
    }
}
