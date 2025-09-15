// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//
int a = 0;
Console.WriteLine("Сколько операций у вас за сегодня было? (2-40)");
a = Convert.ToInt32(Console.ReadLine());
string[] Operations = new string[a];
int[] Prices = new int[a];
string request = "";
string[] words = new string[2];
for (int i = 0; i < a; i++)
{
    request = Console.ReadLine();
    words = request.Split(new char[] { ';' },
    StringSplitOptions.RemoveEmptyEntries);
    words[1] = words[1].Trim(); 
    Operations[i] = words[0];
    Prices[i] = Convert.ToInt32(words[1]);

    
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
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += Prices[i];
            }
            Console.WriteLine($"Среднее: {sum/a}");

            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 0:
            return;
    }

}
