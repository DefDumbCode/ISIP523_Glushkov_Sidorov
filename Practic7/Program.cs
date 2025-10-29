using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
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
                newPlayer.Printinfo();
                var capital = Core.Context.Warehouse_Part.ToList();
                var parts = Core.Context.Part.ToList();
                foreach (var c in capital)
                {
                    for (int i = 0; i < parts.Count; i++)
                    {
                        if(c.ID_Part == parts[i].ID)
                        {
                            Console.WriteLine($"Деталь: {parts[i].Name}; Кол-во: {c.Count} \n");
                            break;
                        }
                    }
                }
                
            }
        }
    }

}
