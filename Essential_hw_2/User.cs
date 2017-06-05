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
        
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value != null)
                {
                    login = value;
                } else
                {
                    Console.WriteLine("Login can not be empty !!!");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name can not be empty !!!");
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                if (value != null)
                {
                    surname = value;
                }
                else
                {
                    Console.WriteLine("Surname can not be empty !!!");
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value <= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age can not be empty !!!");
                }
            }
        }

        public void ShowUserInfo()
        {
            Console.WriteLine("User info:\nlogin:{0}\n name:{1}\n surname:{2}\n age:{3}\n date:{4}", this.login, this.name, this.surname, this.age, this.date.ToString());
        }
    }
}
