// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;

List<Book> Bookshelf = new List<Book>();
bool t = true;
while (t)
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
    Console.WriteLine("10 - Вывод всего товара");
    Console.WriteLine("0 - Выход");

    int o = Convert.ToInt32(Console.ReadLine());
    switch (o)
    {
        case 1:
            Console.WriteLine("Введите ID: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == null)
            {
                Console.WriteLine("Без пустого айди нельзя");
                break;
            }
            Console.WriteLine("Введите название книги: ");
            string n = Console.ReadLine();
            if (n == null)
            {
                Console.WriteLine("Без пустого имени нельзя");
                break;
            }
            Console.WriteLine("Введите имя автора: ");
            string a = Console.ReadLine();
            if (a == null)
            {
                Console.WriteLine("Без пустого автора нельзя");
                break;
            }
            Console.WriteLine("Выберите жанр книги: 1 - Детектив, 2 - Фэнтези, 3 - Ужасы");
            int c = Convert.ToInt32(Console.ReadLine());
            Category g = (Category)c;

            Console.WriteLine("Введите год выпуска: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == null)
            {
                Console.WriteLine("Без года выпуска нельзя");
                break;
            }
            Console.WriteLine("Введите цену за товар: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == null)
            {
                Console.WriteLine("Без цены нельзя");
                break;
            }
            Bookshelf.Add(new Book(i, n, a, g, y, p));
            break;
        case 2:
            Console.Write("Введите ID книги для удаления: ");
            int removeId = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int m = 0; m < Bookshelf.Count; m++)
            {
                if (Bookshelf[m].Id == removeId)
                {
                    Bookshelf.RemoveAt(m);
                    found = true;
                    Console.WriteLine("Книга удалена!");
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Книга с таким ID не найдена.");
            break;
        case 3:
            int x = 0;
            Console.WriteLine("Введите название книги для поиска");
            string poisk = Console.ReadLine();
            Console.WriteLine("Результаты поиска: ");
            for (int m = 0; m < Bookshelf.Count; m++)
            {
                bool result1 = Bookshelf[m].name.ToLower().Contains(poisk);
                bool result2 = Bookshelf[m].name.ToUpper().Contains(poisk);
                if (result1 == true || result2 == true)
                {
                    Bookshelf[m].PrintInfo();
                    x++;
                    break;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("\n Книга с таким названием не найдена, так что вот всё:");
                foreach (Book stuff in Bookshelf)
                {
                    stuff.PrintInfo();
                }
            }
            break;
        case 4:
            int z = 0;
            Console.WriteLine("Введите автора для поиска");
            string find = Console.ReadLine();
            Console.WriteLine("Результаты поиска: ");
            for (int m = 0; m < Bookshelf.Count; m++)
            {
                bool result1 = Bookshelf[m].author.ToLower().Contains(find);
                bool result2 = Bookshelf[m].author.ToUpper().Contains(find);
                if (result1 == true || result2 == true)
                {
                    Bookshelf[m].PrintInfo();
                    z++;
                    break;
                }
            }
            if (z == 0)
            {
                Console.WriteLine("\n Книги этого автора не найдены, так что вот всё:");
                foreach (Book stuff in Bookshelf)
                {
                    stuff.PrintInfo();
                }
            }
            break;
        case 5:
            Console.WriteLine("Выберите категорию для поиска 1 - Детектив, 2 - Фэнтези, 3 - Ужасы");
            int v = Convert.ToInt32(Console.ReadLine());
            Category vv = (Category)v;
            for (int m = 0; m < Bookshelf.Count; m++)
            {
                if (Bookshelf[m].categ == vv)
                {
                    Bookshelf[m].PrintInfo();
                }
            }
            break;
        //Сортировка по названию
        case 6:
            Bookshelf = Bookshelf.OrderBy(x => x.name).ToList();
            break;
        //Сортировка по году
        case 7:

            break;
        //Дешевка + дорогая
        case 8:

            break;
        //Группировка книг по автору
        case 9:

            break;
        case 10:
            for (int m = 0; m < Bookshelf.Count; m++)
            {
                Console.WriteLine("------------------------------------------------");
                Bookshelf[m].PrintInfo();
            }
            break;
        case 0:
            return;
    }

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

    public void PrintInfo()
    {
        Console.WriteLine($"Книга НОМЕР {Id}");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Жанр: {categ}");
        Console.WriteLine($"Год выпуска: {publish_year}");
        Console.WriteLine($"Цена: {price}");
    }

}
enum Category
{
    Детектив = 1,
    Фэнтези,
    Ужасы
}



