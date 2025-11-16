using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            User NewUser = null;
            bool In_Acc = false;
            while (true)
            {
                Console.WriteLine("---Меню--- \n 1) Каталог товаров \n 2) Корзина товаров \n 3) Заказы \n 4) Аккаунт \n 5) Выход");
                int q = Convert.ToInt32(Console.ReadLine());
                switch (q)
                {
                    case 1:
                        Shop shopp = new Shop();
                        shopp.Buy(NewUser, In_Acc);
                        break;
                    case 2:
                       
                        Console.WriteLine("---КОРЗИНА---");

                        var userProducts = Core.Context.User_Product
                        .Where(up => up.ID_User == NewUser.ID)
                        .ToList();
                        foreach (var u in userProducts)
                        {
                            Console.WriteLine($"ID: {u.ID} Название: {u.Product.Name}, Цена {u.Product.Price * u.Amount}, Кол-во {u.Amount}");
                        }
                        Console.WriteLine("Вы хотите купить определенный товар или всю корзину? \n 1) Один \n 2) Всё");
                        int qqq = Convert.ToInt32(Console.ReadLine());
                        switch (qqq)
                        {
                            case 1:
                                Console.WriteLine("Введите ID, который вы хотите купить.");
                                int i = Convert.ToInt32(Console.ReadLine());
                                User_Product UsProd3 = Core.Context.User_Product.FirstOrDefault(u => u.ID == i);

                                break;
                            case 2:
                                break;
                        }
                        Console.WriteLine("В какой ПВЗ вы хотите это заказать?");
                        List<PVZ> pvz = Core.Context.PVZ.ToList();
                        foreach (var u in pvz)
                        {
                            Console.WriteLine($"ID: {u.ID} Адрес: {u.Adress}");
                        }
                        Console.WriteLine("Введите ID нужного ПВЗ:");
                        int ii = Convert.ToInt32(Console.ReadLine());
                        PVZ pVZ = Core.Context.PVZ.FirstOrDefault(p => p.ID == ii);
                        break;
                    case 3:
                        Console.WriteLine(DateTime.Now);
                        break;
                    case 4:
                        if(In_Acc == true)
                        {
                            Console.WriteLine("Вы уже вошли в аккаунт!");
                            NewUser.PrintInfo();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Регистрация или вход? \n 1) Регистрация \n 2) Вход");
                            int qq = Convert.ToInt32(Console.ReadLine());
                            switch (qq)
                            {
                                case 1:
                                    NewUser = new User();
                                    NewUser.Regist(ref In_Acc);
                                    
                                    break;
                                case 2:
                                    NewUser = new User();
                                    NewUser.Log_In(ref NewUser, ref In_Acc);
                                    Console.WriteLine(NewUser.FIO);
                                    break;
                            }
                            break;
                        }
                            
                    case 5:
                        Console.WriteLine("Адиос");
                        break;
                    default:
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
                    Core.Context.User_Product.Add(New_Us_Prod);
                    Core.Context.SaveChanges();
                }
                
            }
        }

    }
}
