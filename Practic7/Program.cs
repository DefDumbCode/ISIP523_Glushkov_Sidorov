using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practic7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var capital = Core.Context.Warehouse_Part.ToList();
            var parts = Core.Context.Part.ToList();
            int count = 1;
            bool a = true;
                Console.WriteLine("Вы управляете автосервисом, куда каждый день приезжают клиенты со сломанными машинами." +
                    "Ваша задача — чинить их автомобили и зарабатывать деньги!");
                Console.WriteLine("Введите ваше имя: ");
                string b = Console.ReadLine();
                Player newPlayer = new Player // создание нового пользователя
                {
                    Name = b,
                    Balance = 300,
                    ID_Warehouse = 1
                };
                Console.WriteLine("Персонаж создан!");
                

            while (a)
            {
                newPlayer.Printinfo();
                foreach (var c in capital)
                {
                    for (int i = 0; i < parts.Count; i++)
                    {
                        if (c.ID_Part == parts[i].ID)
                        {
                            Console.WriteLine($"Деталь: {parts[i].Name}; Кол-во: {c.Count} \n");
                            break;
                        }
                    }
                }

                Console.WriteLine("Новый клиент!");
                Client rClient = FabClient.RandCar();
                rClient.Print();

                Console.WriteLine("Ваши действия? \n 1 - Поменять деталь \n 2 - Отказаться от ремонта");
                int o = Convert.ToInt32(Console.ReadLine());
                Part newPart = Core.Context.Part.First(p => p.Name == rClient.Trouble);
                Warehouse_Part G = Core.Context.Warehouse_Part.FirstOrDefault(w => w.ID_Part == newPart.ID);
                switch (o)
                { 
                    case 1:
                        if (G.Count > 0)
                        {
                            G.Count--;
                            Console.WriteLine("Ремонт прошёл успешно!");
                            newPlayer.Balance += (newPart.Price+25);
                        }
                        else
                        {
                            var f = capital.First(w => w.Count > 0);
                            Console.WriteLine("Необходимой детали не было, было взято что попало! \n Клиент вернулся очень злым!"); 
                            f.Count--;
                            newPlayer.Balance -= 75;
                        }
                            break;
                    case 2:
                        Console.WriteLine("Клиент был недоволен отказом, ШТРАФ 30 ЗОЛОТЫХ!");
                        newPlayer.Balance -= 30;
                        break;

                }
                Shop shop = new Shop();
                shop.Buy(newPlayer);



            }
  
                
        


        }

        

        class Client
        {
            public string Car;
            public string Trouble;
            public int TroubleId;

            public Client(string car, string trouble)
            {
                Car = car;
                Trouble = trouble;
            }

            public void Print()
            {
                Console.WriteLine($"Машина: {Car}; Проблема: {Trouble}");
            }


        }

        class FabClient
        {
            public static List<string> Cars = new List<string>() { "BMW", "Mercedes", "Lada", "Subaru" };
            public static List<string> Troubles = new List<string>() { "Дверь", "Лобовое стекло", "Выхлопная труба", "Двигатель" };

            public static Random rand = new Random();

            public static Client RandCar()
            {
                string Car = Cars[rand.Next(Cars.Count)];
                string Trouble = Troubles[rand.Next(Troubles.Count)];

                return new Client(Car, Trouble);
            }
                
        }

        class Shop
        {
            List<Part> parts = Core.Context.Part.ToList();

            public void Buy(Player newPlayer)
            {
                
                Console.WriteLine("Вы желаете заказать доставку в магазине? 1 - да/2 - нет");
                int m = Convert.ToInt32(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        bool purchase = false;
                        while(purchase != true)
                        {
                            Console.WriteLine("=====Добро пожаловать в МАГАЗИН=====");
                            foreach (var p in parts)
                            {
                                Console.WriteLine($"Товар: {p.Name}, Цена: {p.Price}");
                            }
                            Console.WriteLine($"Баланс: {newPlayer.Balance}");
                            Console.WriteLine("Что вы хотите взять?");
                            Console.WriteLine("Введите ТОЧНОЕ название товара которое вы хотите взять: ");
                            string l = Console.ReadLine();
                            Part newPart2 = Core.Context.Part.First(p => p.Name == l);
                            Warehouse_Part GG = Core.Context.Warehouse_Part.FirstOrDefault(w => w.ID_Part == newPart2.ID);
                            Console.WriteLine("Сколько вы хотите купить?");
                            int x = Convert.ToInt32(Console.ReadLine());
                            int xx = x * newPart2.Price;
                            if (xx > newPlayer.Balance)
                            {
                                Console.WriteLine("У вас недостаточно средств!");
                            }
                            else
                            {
                                newPlayer.Balance -= xx;
                                GG.Count += x;
                                Console.WriteLine($"Покупка успешна! Куплено {x} единиц {l}");
                                purchase = true;
                            }
                        }
                        
                            break;
                    case 2:

                        break;

                }

            }
        }
    }

}
