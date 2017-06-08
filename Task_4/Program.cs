using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Invoice.
    В теле класса создать три поля int account, string customer, string provider которые должны
    быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
    дальнейшего изменения.
    В теле класса создать два закрытых поля string article, int quantity
    Создать метод расчета стоимости заказа с НДС и без НДС.
    Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
 */


namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(678904, "Alex", "Foxtrot") { Article = "USB-hab", Quantity = 6 };

            inv.CostCalculation(true);
            inv.CostCalculation(false);

            Console.WriteLine(new string('-',15));
            inv.ShowInvoiceInfo();

            Console.ReadKey();
        }
    }
}
