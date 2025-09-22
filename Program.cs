// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");
List<Product> prod = new List<Product>();
List<double> sales = new List<double>();
List<string> sold_stuff = new List<string>();
List<int> sold_amount = new List<int>();


bool a = true;
while (a)
{
    Console.WriteLine("-----МЕНЮ-----");
    Console.WriteLine("1 - Добавить товар");
    Console.WriteLine("2 - Удалить товар");
    Console.WriteLine("3 - Заказать поставку товара");
    Console.WriteLine("4 - Продать товар");
    Console.WriteLine("5 - Поиск товара по коду");
    Console.WriteLine("6 - Поиск товара по названию");
    Console.WriteLine("7 - Поиск товара по категории");
    Console.WriteLine("0 - Выход");

    int o = Convert.ToInt32(Console.ReadLine());
    switch (o)
    {
        case 1:
            Console.WriteLine("Введите ID товара: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == null)
            {
                Console.WriteLine("Без пустого айди нельзя");
                break;
            }
            Console.WriteLine("Введите название товара: ");
            string b = Console.ReadLine();
            if (b == null)
            {
                Console.WriteLine("Без пустого имени нельзя");
                break;
            }
            Console.WriteLine("Введите цену товара: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (c == null)
            {
                Console.WriteLine("Без пустой цены нельзя");
                break;
            }
            Console.WriteLine("Введите кол-во товара: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == null)
            {
                Console.WriteLine("Без товара нельзя");
                break;
            }
            Console.WriteLine("Выберите категорию товара: 1 - Еда, 2 - Оружие, 3 - Другое");
            int f = Convert.ToInt32(Console.ReadLine());
            Category r = (Category)f;
            prod.Add(new Product(p, b, c, d, r));
            break;
        case 2:
            Console.Write("Введите ID товара для удаления: ");
            int removeId = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < prod.Count; i++)
            {
                if (prod[i].Id == removeId)
                {
                    prod.RemoveAt(i);
                    found = true;
                    Console.WriteLine("Товар удалён!");
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Товар с таким ID не найден.");
            break;
        case 3:
            int l = 0;
            Console.Write("Введите ID товара который хочите заказатт: ");
            int dih = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < prod.Count; i++)
            {
                if (prod[i].Id == dih)
                {
                    Console.WriteLine("Сколько хотиете заказать? ");
                    int bruh = Convert.ToInt32(Console.ReadLine());
                    prod[dih].Quant += bruh;
                    l++;

                }
            }
            if (l == 0) {
                Console.WriteLine("НУ ТЫ ТУПОЙ ИЛИ НЕТ, ВВЕДИ СУЩЕСТВУЮЩИЙ ID!!!!11111");
                break;
            }
            break;

        case 4:
            int m = 0;
            Console.Write("Введите ID товара который хочите продать: ");
            int duh = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < prod.Count; i++)
            {
                if (prod[i].Id == duh)
                {
                    Console.WriteLine("Сколько хотите продать? ");
                    int brb = Convert.ToInt32(Console.ReadLine());
                    if (prod[i].Quant >= brb)
                    {
                        double sale = prod[duh].Price * brb;
                        sales.Add(sale);
                        Console.WriteLine($"Получено {sale} деньгов");
                        m++;
                    }
                    else
                    {
                        Console.WriteLine("Ты не настолько богатый, идиот.");
                        m++;
                        break;
                    }

                }
            }
            if (m == 0)
            {
                Console.WriteLine("НУ ТЫ ТУПОЙ ИЛИ НЕТ, ВВЕДИ СУЩЕСТВУЮЩИЙ ID!!!!11111");
                break;
            }
            break;
        case 5:
            Console.Write("Введите ID товара для поиска: ");
            int findID = Convert.ToInt32(Console.ReadLine());

            bool foundd = false;

            for (int i = 0; i < prod.Count; i++)
            {
                if (prod[i].Id == findID)
                {
                    foundd = true;
                    Console.WriteLine("Товар найден!");
                    prod[i].PrintInfo();
                    break;
                }
            }

            if (!foundd)
            {
                Console.WriteLine("\n Товар с таким ID не найден, так что вот всё:");
                foreach (Product product in prod)
                {
                    product.PrintInfo();
                }
            }
            break;
        case 6:
            int x = 0;
            Console.WriteLine("Введите название товара для поиска");
            string poisk = Console.ReadLine();
            Console.WriteLine("Результаты поиска: ");
            for (int i = 0; i < prod.Count; i++)
            {
                bool result1 = prod[i].Name.ToLower().Contains(poisk);
                bool result2 = prod[i].Name.ToUpper().Contains(poisk);
                if (result1 == true || result2 == true)
                {
                    prod[i].PrintInfo();
                    x++;
                    break;
                }
            }
            if(x == 0)
            {
                Console.WriteLine("\n Товар с таким названием не найден, так что вот всё:");
                foreach (Product product in prod)
                {
                    product.PrintInfo();
                }
            } 
            break;
        case 7:
            Console.WriteLine("Выберите категорию для поиска 1 - Еда, 2 - Оружие, 3 - Другое");
            int v = Convert.ToInt32(Console.ReadLine());
            Category vv = (Category)v;
            for (int i = 0; i < prod.Count; i++)
            {
                if (prod[i].Categ == vv)
                {
                    prod[i].PrintInfo();
                }
            }
            break;
        case 0:
            return;
    }
}

class Product
{
    public static int id = 1;
    public int Id;
    public string Name;
    public double Price;
    public int Quant;
    public Category Categ;

    public Product(int Id, string Name, double Price, int Quant, Category Categ)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        this.Quant = Quant;
        this.Categ = Categ;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"ПРОДУКТ НОМЕР {Id}");
        Console.WriteLine($"Имя продукта: {Name}");
        Console.WriteLine($"Цена продукта: {Price}");
        Console.WriteLine($"Кол-во продукта: {Quant}");
        Console.WriteLine($"Категория: {Categ}");
    }
}

enum Category
{
    Еда = 1,
    Оружие,
    Другое
}