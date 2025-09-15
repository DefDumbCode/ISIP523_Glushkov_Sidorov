// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");

int a = 0;
Console.WriteLine("Сколько операций у вас за сегодня было? (2-40)");
a = Convert.ToInt32(Console.ReadLine());
string[] Operations = new string[a];
double[] Prices = new double[a];
string request = "";
string[] words = new string[2];
for (int i = 0; i < a; i++)
{
    request = Console.ReadLine();
    words = request.Split(new char[] { ';' },
    StringSplitOptions.RemoveEmptyEntries);
    words[1] = words[1].Trim(); 
    Operations[i] = words[0];
    Prices[i] = Convert.ToDouble(words[1]);

    
}

bool p = true;
while (p)
{
    Console.WriteLine("1. Вывод данных");
    Console.WriteLine("2. Статистика (среднее, максимальное, минимальное, сумма)");
    Console.WriteLine("3. Сортировка по цене (пузырьковая сортировка)");
    Console.WriteLine("4. Конвертация валюты (пользователь вводит курс или выбирает из списка)");
    Console.WriteLine("5. Поиск по названию ");
    Console.WriteLine("0. Выход");

    int o = Convert.ToInt32(Console.ReadLine());
    switch (o)
    {
        case 1:
            for(int i = 0; i < a; i++)
            {
                Console.WriteLine($"{Operations[i]}; {Prices[i]}");
            }
            break;
        case 2:
            double sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += Prices[i];
            }
            Console.WriteLine($"Среднее: {sum/a}");
            int min = 100000;
            foreach (int i in Prices)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine($"Минимальное: {min}");
            int max = 0;
            foreach (int i in Prices)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Максимальное: {max}");
            Console.WriteLine($"Сумма: {sum}");
            break;
        case 3:
            for (int i = 1; i < Prices.Length; i++)
            {
                for (int j = 0; j < Prices.Length - 1; j++)
                {
                    if (Prices[j] > Prices[j + 1])
                    {
                        double c = Prices[j];
                        Prices[j] = Prices[j + 1];
                        Prices[j + 1] = c;
                        string d = Operations[j];
                        Operations[j] = Operations[j + 1];
                        Operations[j + 1] = d;
                    }
                }
            }
            break;
        case 4:

            Console.WriteLine("1. Доллары");
            Console.WriteLine("2. Евро");
            Console.WriteLine("3. Свой вариант");
            int bebebe = Convert.ToInt32(Console.ReadLine());
            switch (bebebe)
            {
                case 1:
                    for (int i = 0; i < a; i++)
                    {
                        Prices[i] = Prices[i] * 0.012;
                    }
                    break;
                case 2:
                    for (int i = 0; i < a; i++)
                    {
                        Prices[i] = Prices[i] * 0.01;
                    }
                    break;
                case 3:
                    double kurs = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        Prices[i] = Prices[i] * kurs;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nКонвертировано.");
            break;

        case 5:
            Console.WriteLine("Найти:");
            string poisk = Console.ReadLine();
            Console.WriteLine("Результаты поиска: ");
            for (int i = 0; i < Operations.Length; i++)
            {
                bool result1 = Operations[i].ToLower().Contains(poisk);
                if (result1 == true)
                {
                    Console.WriteLine(Operations[i]);
                    a++;
                }
                bool result2 = Operations[i].ToUpper().Contains(poisk);
                if (result2 == true)
                {
                    Console.WriteLine(Operations[i]);
                    a++;
                }
            }

            if (a == 0)
            {
                Console.WriteLine("Ничего не найдено!");
            }
            break;
        case 0:
            return;
    }

}
