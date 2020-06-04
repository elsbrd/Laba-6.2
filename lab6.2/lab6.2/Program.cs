using System;
using lab6._2.Properties;

namespace lab6._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client[] arrClient = new Client[100];
            Random rand1 = new Random();
            for (int i = 0; i < arrClient.Length; i++)
            {
                arrClient[i] = new Client(rand1);
            }
            FurnitureShop furnitureShop = new FurnitureShop(arrClient);
            furnitureShop.outputClient();
            Admin administrator = new Admin(furnitureShop.SortClient.ArrayAggrement,rand1);
            Bank bank = new Bank(furnitureShop.SortClient.ArrayAggrement,rand1);
            bank.OutBank(furnitureShop.SortClient.ArrayAggrement);
            bank.OutDelayClient(furnitureShop.SortClient.ArrayAggrement);
        }
    }
}