using System;

namespace lab6._2
{
    public class Client
    {
        private Credit credit;

        public Client(Random rand3)
        {
            this.credit = new Credit(rand3.Next(1000, 30000), rand3);
        }

        public Credit Credit
        {
            get { return credit; }
        }
    }

}