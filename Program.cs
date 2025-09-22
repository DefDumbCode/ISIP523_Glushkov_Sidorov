// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Product> prod = new List<Product>();
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
            Console.WriteLine("Введите название товара: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите цену товара: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите категорию товара: 1 - Еда, 2 - Оружие, 3 - Другое");
            int y = Convert.ToInt32(Console.ReadLine());
            Category r;
            switch (y)
            {
                case 1:
                    r = Category.Еда;
                    prod.Add(new Product(b, c, d, r));
                    break;
                case 2:
                     r = Category.Оружие;
                    prod.Add(new Product(b, c, d, r));
                    break;
                case 3:
                     r = Category.Другое;
                    prod.Add(new Product(b, c, d, r));
                    break;
            }
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
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
    public static int Id = 1;
    public string Name;
    public double Price;
    public int Quant;
    public Category Categ;

    public Product(string Name, double Price, int Quant, Category Categ)
    {
        Id++;
        this.Name = Name;
        this.Price = Price;
        this.Quant = Quant;
        this.Categ = Categ;
    }
}

enum Category
{
    Еда = 1,
    Оружие,
    Другое
}