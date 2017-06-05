using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_hw_2
{
    class User
    {
        string login;
        string name;
        string surname;
        int age;
        readonly DateTime date;

        public User()
        {
            this.date = DateTime.Now;
        }

        public User(string login,
                    string name,
                    string surname,
                    int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = DateTime.Now;
        }
        /*
        public string UserInfo()
        {
            string result = string.Format("User info:\nlogin:{0}\nname:{1}\nsurname:{2}\nage:{3}\ndate:{4}", login, name, surname, this.age, this.date);
            return result;
        }
        */
        public void ShowUserInfo()
        {
            Console.WriteLine("User info:\nlogin:{0}\n name:{1}\n surname:{2}\n age:{3}\n date:{4}", this.login, this.name, this.surname, this.age, this.date.ToString());
        }
    }
}
