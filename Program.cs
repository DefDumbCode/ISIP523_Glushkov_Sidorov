// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


bool a = true;
while (a)
{
    Console.WriteLine("----------МЕНЮ----------");
    Console.WriteLine("1 - Добавить книгу");
    Console.WriteLine("2 - Удалить книгу");
    Console.WriteLine("3 - Найти книгу по названию");
    Console.WriteLine("4 - Найти книгу по автору");
    Console.WriteLine("5 - Найти книгу по жанру");
    Console.WriteLine("6 - Отсортировать книги по названию");
    Console.WriteLine("7 - Отсортировать книги по году");
    Console.WriteLine("8 - Вывести самую дорогую и самую дешевую книгу");
    Console.WriteLine("9 - Группировка книг по автору");
}

class Book
{

    public static int id = 1;
    public int Id;
    public string name;
    public string author;
    public Category categ;
    public int publish_year;
    public int price;



    public Book(int Id, string name, string author, Category categ, int publish_year, int price)
    {
        this.Id = Id;
        this.name = name;
        this.author = author;
        this.categ = categ;
        this.publish_year = publish_year;
        this.price = price;

    }
    
}
enum Category
{
    Детектив = 1,
    Фэнтези,
    Ужасы
}



