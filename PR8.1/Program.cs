using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---Меню--- \n 1) Каталог товаров \n 2) Корзина товаров \n 3) Заказы \n 4) Аккаунт \n 5) Выход");
                int q = Convert.ToInt32(Console.ReadLine());
                switch (q)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Регистрация или вход? \n 1) Регистрация \n 2) Вход");
                        int qq = Convert.ToInt32(Console.ReadLine());
                        switch (qq)
                        {
                            case 1:
                                //fghjk
                                break;
                            case 2:
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Адиос");
                        break;
                    deafult:
                        Console.WriteLine("Непонятный ввод, повторите пожалуйста");
                        break;
                }
                if (q == 5)
                    break;

            }
        }
    }
}
