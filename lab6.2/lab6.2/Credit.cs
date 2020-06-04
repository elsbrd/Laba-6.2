using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace lab6._2
{
    public class Credit
    {
                private double priceIteam; //цена товара
                private bool delay; //просрочка кредита
                private const double interestRate = 12; //процентная ставка
                private bool isuue;//выдан
                private int period;//срок
                private string prodact;//товар
                private double monthlyPayment;// выплата за месяц
                private double clientPayment;// зарплата клиента за месяц
                private double summBorg;//сумма которую нужно виплатить покупателю (уменьшается/увеличивается) 
                private string bank;
               
        
                public Credit(double clientPayment,Random rand1)//конструктор
                {
                    this.clientPayment = clientPayment;
                    string[] MyProdact = new string[] {"Модульная кухня","Офисное кресло","Офисный шкаф", "Письменный стол","Кухонный стол", "Журнальный стол", "Деревянный стул", "Металицеский стул", "Пластиковый стул", "Шкаф купе", "Тканевый диван", "Кожаный диван", "Пуф", "Кресло", "Кровать","Стелаж для книг", "Подставка для обуви", "Вешалка для обуви", "Тумба", "Зеркало", "Фурнитура", "Вешалка для одежды"};
                    this.prodact = MyProdact[rand1.Next(0, MyProdact.Length)];
                    this.priceIteam = rand1.Next(1000, 30000);
                    if (priceIteam /clientPayment > 0.3)
                    {
                        this.isuue = true;
                        this.delay = false;
                        this.period = (int)Math.Ceiling((priceIteam + ((priceIteam / 100) * interestRate)) / clientPayment);
                        this.monthlyPayment = (priceIteam + ((priceIteam / 100) * interestRate)) / period;
                        this.summBorg = (priceIteam + ((priceIteam / 100) * interestRate));
                        this.bank = "---";
                    }
                    else
                    {
                        this.isuue = false;
                    }
                }

                public double SummBorg
                {
                    get => summBorg;
                    set => summBorg = value;
                }

                public string Bank
                {
                    get { return bank; }
                    set { bank = value; }
                }
                public double ClientPayment
                {
                    get { return clientPayment; }
                    set { clientPayment = value; }
                }
                

                public double PriceIteam
                {
                    get { return priceIteam; }
                    set { priceIteam = value; }
        
                }
        
                public bool Delay
                {
                    get { return delay; }
                    set { delay = value; }
        
                }
                public double InterestRate
                {
                    get {return interestRate; }
                    //set {interestRate= value; }
                }
        
                public bool Isuue
                {
                    get {return isuue; }
                    set {isuue = value; }
                }
        
                public int Period
                {
                    get {return period; }
                    set {period = value; }
                }
        
                public string Prodact
                {
                    get {return prodact; }
                    set {prodact = value; }
                }
                public double MonthlyPayment
                {
                    get { return monthlyPayment; }
                    set {monthlyPayment = value; }
                }
                public override string ToString()
                {
                    return ("Статус кредита: " + isuue +" \nМебель: "+prodact+ " \nПериод оплаты: " + period+ " \nВыплата за месяц: " + monthlyPayment+" \nЦена за товар: "+ priceIteam +" \nБанк: "+bank+" \nБыла ли несвоевременная оплата: "+delay+" \nДолг перед банком: " + SummBorg+" \n");
                }
                

                
    }
}