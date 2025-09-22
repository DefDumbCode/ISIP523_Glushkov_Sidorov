// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
    public int Price;
    public int Quant;
    public Category Categ;

    public Product(string Name, int Price, int Quant, Category Categ)
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