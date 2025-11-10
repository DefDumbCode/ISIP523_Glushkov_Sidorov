using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8._1
{
    internal class Register
    {
        public virtual void Regist()
        {
            Console.WriteLine("Введите свое ФИО: ");
            string n = Console.ReadLine();
            Console.WriteLine("Введите свой номер телефона: (Формат 89999999999)");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пароль: ");
            string p = Console.ReadLine();
            Console.WriteLine("Введите пароль повторно: ");
            string pp = Console.ReadLine();
            if (p == pp)
            {
                User login = new User
                {
                    FIO = n,
                    Phone_num = t,
                    Password = p
                };

                Core.Context.User.Add(login);
                Core.Context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Пароли не совпадают");
            }


        }
        public virtual void Log_In(User login)
        {
            List<User> users = Core.Context.User.ToList();
            Console.WriteLine("Номер телефона: (Формат 89999999999)");
            int t = Convert.ToInt32(Console.ReadLine());
            User fg = users.FirstOrDefault(u => u.Phone_num == t);
            if (fg != null)
            {
                Console.WriteLine("Пароль: ");
                string p = Console.ReadLine();
                if (fg.Password == p)
                {
                    login = fg;
                }
            }
            else
            {

                Console.WriteLine("Аккаунта с таким номером не существует");
                return;
            }

        }
    }
}
