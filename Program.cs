// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine("Введите название товара: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите цену товара: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара: ");
            int d = Convert.ToInt32(Console.ReadLine());
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
            Console.Write("Введите ID товара который хочите заказатт: ");
            int dih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько хотиете заказать? ");
            int bruh = Convert.ToInt32(Console.ReadLine());
            prod[dih].Quant += bruh;
            break;
        case 4:
            Console.Write("Введите ID товара который хочите продать: ");
            int duh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько хотите продать? ");
            int brb = Convert.ToInt32(Console.ReadLine());
            double sale = prod[duh].Price * brb;
            sales.Add(sale);
            Console.WriteLine($"Получено {sale} деньгов");
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
                Console.WriteLine("\n Товар с таким ID не найден, так что вот всё:");
                foreach (Product product in prod)
                {
                    product.PrintInfo();
                }
            break;
        case 6:
            
            break;
        case 7:
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