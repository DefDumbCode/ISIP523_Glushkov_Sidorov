// See https://aka.ms/new-console-template for more information

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
            Console.WriteLine("Выберите категорию товара: 1 - Еда, 2 - Оружие, 3 - Другое");
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
            Console.Write("Введите ID товара для удаления: ");
            int removeId = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int m = 0; m < Bookshelf.Count; m++)
            {
                if (Bookshelf[m].Id == removeId)
                {
                    Bookshelf.RemoveAt(m);
                    found = true;
                    Console.WriteLine("Товар удалён!");
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Товар с таким ID не найден.");
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
    
}
enum Category
{
    Детектив = 1,
    Фэнтези,
    Ужасы
}



