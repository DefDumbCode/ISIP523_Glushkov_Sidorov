using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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


            }
  
                
        


        }

        

        class Client
        {
            public string Car;
            public string Trouble;

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
            public List<string> Cars = new List<string>() { "BMW", "Mercedes", "Lada", "Subaru" };
            public List<string> Troubles = new List<string>() { "Подорвало дверь", "Пробило стекло", "Пробило трубу", "Белка в двигателе" };

            public static Random rand = new Random();

            public static Client RandCar(List<string> Cars, List<string> Troubles)
            {
                string Car = Cars[rand.Next(Cars.Count)];
                string Trouble = Troubles[rand.Next(Troubles.Count)];

                return new Client(Car, Trouble);
            }
                
        }
    }

}
