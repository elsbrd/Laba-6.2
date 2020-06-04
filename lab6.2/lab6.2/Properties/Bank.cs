using System;
using System.Collections.Generic;

namespace lab6._2.Properties
{
    public class Bank
    {
        private static int countClientDelay = 0;
        public Bank(List<Credit> arrayAggrement, Random rand5)
        {
            for (int i = 0; i < arrayAggrement.Count; i++)
            {
                int period = arrayAggrement[i].Period;
                for (int j = 0; j < period; j++)
                {
                    bool randomBool = rand5.Next(2) == 1; // 0 = false, 1 = true;
                    if (randomBool)
                    {
                        arrayAggrement[i].SummBorg = (arrayAggrement[i].SummBorg - arrayAggrement[i].MonthlyPayment);
                        arrayAggrement[i].Period -= 1;
                    }
                    else
                    {
                        arrayAggrement[i].Delay = true;
                        int dayDelay = rand5.Next(1, 7);
                        for (int k = 0; k < dayDelay; k++)
                        {
                            arrayAggrement[i].SummBorg = (arrayAggrement[i].SummBorg + (arrayAggrement[i].ClientPayment / 100) * 2);
                        }

                        arrayAggrement[i].Period = (int) (Math.Ceiling((arrayAggrement[i].SummBorg / arrayAggrement[i].ClientPayment)));
                    }

                    if (arrayAggrement[i].SummBorg <= 700)
                    {
                        arrayAggrement[i].SummBorg = 0;
                        arrayAggrement[i].Period = 0;
                    }
                }
            }
        }

        public void OutBank(List<Credit> arrClient)
        { Console.WriteLine("============================================================");
            Console.WriteLine("ВЫВОД ОПЛАТ КРЕДИТОВ КЛИЕНТАМИ ЗА СРОК ОПЛАТЫ: ");
            Console.WriteLine("============================================================");
            for (int i = 0; i < arrClient.Count; i++)
            {
                Console.WriteLine(arrClient[i].ToString());
                Console.WriteLine("============================================================");
            }
        }

        public void OutDelayClient(List<Credit> arrClient)
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("КЛИЕНТЫ, КОТОРЫЕ ПРОСРОЧИЛИ ОПЛАТУ:");
            Console.WriteLine("============================================================");
            for (int i = 0; i < arrClient.Count; i++)
            {
                if (arrClient[i].Delay == true)
                {
                    Console.WriteLine("У ДАННОГО КЛИЕНТА СУММА ДОЛГА ПЕРЕД БАНКОВ СОСТАВЛЯЕТ: "+arrClient[i].SummBorg);
                    Console.WriteLine("============================================================");
                    countClientDelay++;
                }
            }
            Console.WriteLine("КОЛИЧЕСТВО КЛИЕНТОВ, КОТОРЫЕ ПРОСРОЧИЛИ ОПЛАТУ: " + countClientDelay);
            Console.WriteLine("============================================================");
        }
        
    }
}