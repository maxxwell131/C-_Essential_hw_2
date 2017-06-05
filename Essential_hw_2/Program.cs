using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Задание:
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
    заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
    (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
    Реализуйте вывод на экран информации о пользователе.
 */

namespace Essential_hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User emptyUser = new User();
            emptyUser.ShowUserInfo();

            User currentUserInfo = new User("admin", "Ivan", "Stepanov", 25);
            //string result = user.UserInfo;
            //Console.WriteLine(currentUserInfo.UserInfo);
            currentUserInfo.ShowUserInfo();
            Console.ReadKey();
        }
    }
}
