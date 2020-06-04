using System;
using System.Collections.Generic;
using System.Text;
namespace lab6._2
{
    public class FurnitureShop
    {
        private List<Credit> allClient;
        private SortClient<Credit> sortClient;

        public FurnitureShop(Client[] clientList)
        {
            allClient = new List<Credit>();
            for (int i = 0; i < clientList.Length; i++)
            {
                allClient.Add(clientList[i].Credit);
            }

            sortClient = new SortClient<Credit>(allClient);
        }

        public SortClient<Credit> SortClient
        {
            get { return sortClient; }
            set { sortClient= value; }
        }

        public void outputClient()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("НЕОДОБРЕННЫЕ КРЕДИТЫ");
            Console.WriteLine("============================================================");
            for (int i = 0; i < sortClient.ArrayDisaggrement.Count; i++)
            {
                Console.WriteLine(sortClient.ArrayDisaggrement[i].ToString());
                Console.WriteLine("============================================================");
            }

            Console.WriteLine("============================================================");
            Console.WriteLine("ОДОБРЕННЫЕ КРЕДИТЫ");
            Console.WriteLine("============================================================");
            for (int i = 0; i < sortClient.ArrayAggrement.Count; i++)
            {
                Console.WriteLine(sortClient.ArrayAggrement[i].ToString());
                Console.WriteLine("============================================================");
            }
        }
    
    }
}