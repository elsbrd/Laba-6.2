using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace lab6._2
{
    public class Admin
    {
        public Admin(List<Credit> arrayAggrement, Random rand4)
        { string[] MyBank = { "Приватбанк", "Ощадбанк", "Укрэксимбанк", "Укргазбанк", "Райффайзен", "Альфа-банк", "УкрСиббанк", "ПУМБ ", "OTP", "Crédit Agricole", "	Сбербанк", "Пивденный", "Citibank", "ПроКредит", "Таскомбанк", "Кредобанк", "Укрсоцбанк", "Проминвестбанк", "ING", "Банк Кредит Днепр"};
            for (int i = 0; i < arrayAggrement.Count; i++)
            {
                arrayAggrement[i].Bank = MyBank[rand4.Next(0, MyBank.Length)];
                arrayAggrement[i].SummBorg = (arrayAggrement[i].SummBorg + ((arrayAggrement[i].SummBorg/1000)*5));
            }
        }
    }
}