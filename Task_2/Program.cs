using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Converter.
    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
    и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public
    Converter(double usd, double eur, double rub).
    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
    также программа должна производить конвертацию из указанных валют в гривну.
*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter05062017 = new Converter( 26.27, 29.47, 0.46);

            converter05062017.ToRub(22000);
            converter05062017.ToUsd(22000);
            converter05062017.ToEur(22000);
            Console.ReadKey();
        }
    }
}
