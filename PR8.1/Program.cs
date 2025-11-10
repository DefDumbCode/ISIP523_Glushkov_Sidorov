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
            User NewUser = new User();
            bool In_Acc = false;
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
                                NewUser.Regist(In_Acc);
                                break;
                            case 2:
                                NewUser.Log_In(NewUser, In_Acc);
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

        class Shop
        {
            List<Product> products = Core.Context.Product.ToList();

            public void Buy(User NewUser, bool In_Acc)
            {
                Console.WriteLine("---КАТАЛОГ---");
                foreach (Product p in products)
                {
                    Console.WriteLine($"Товар: {p.Name}, Цена: {p.Price}");
                }
                if (In_Acc == false)
                {
                    Console.WriteLine("Так как вы не вошли в аккаунт, вы не можете совершать покупки");
                }
                else
                {
                    Console.WriteLine("Введите точное название товара, который вы хотите купить.");
                    string l = Console.ReadLine();
                    Product Prod2 = Core.Context.Product.FirstOrDefault(p => p.Name == l);
                    Console.WriteLine("Сколько вы хотите купить?");
                    int x = Convert.ToInt32(Console.ReadLine());
                    User_Product New_Us_Prod = new User_Product
                    {
                        ID_User = NewUser.ID,
                        ID_Product = Prod2.ID,
                        Amount = x
                    };
                    Console.WriteLine($"Вы добавили в корзину {l} единиц предмета {x}");
                }
                
            }
        }

    }
}
