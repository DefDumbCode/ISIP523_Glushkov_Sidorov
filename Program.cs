// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

List<string> Names = new List<string>();
List<Student> Students = new List<Student>();


bool t = true;
while (t)
{
    Console.WriteLine("----------МЕНЮ----------");
    Console.WriteLine("1 - Добавить студента");
    Console.WriteLine("2 - Вывести инфу про студентов");
    Console.WriteLine("3 - Добавить препода");
    Console.WriteLine("4 - Вывести инфу про преподов");
    Console.WriteLine("5 - Добавить курс");
    Console.WriteLine("6 - Вывести инфу про курсы");
    Console.WriteLine("7 - Найти по Фамилии курсыыы");
    Console.WriteLine("8 - ВЫВЕСТИ ВСЁЁЁ");
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
            Console.WriteLine("Введите ФИО: ");
            string n = Console.ReadLine();
            if (n == null)
            {
                Console.WriteLine("Без пустого имени нельзя");
                break;
            }
            Console.WriteLine("Введите Дату рождения: (YYYY,MM,DD)");
            DateOnly d = DateOnly.Parse(Console.ReadLine());
            bool b = DateOnly.TryParse(Console.ReadLine(), out d);
            if (b == false)
            {
                Console.WriteLine("Ты пишешь херню.");
                break;
            }
            if (d == null)
            {
                Console.WriteLine("Без пустого др нельзя");
                break;
            }
            Console.WriteLine("Введите пол: ");
            string g = Console.ReadLine();
            if (g == null)
            {
                Console.WriteLine("Без пустого пола нельзя");
                break;
            }
            Console.WriteLine("Введите опыт работы с ПК В ГОДАХ: ");
            int e = Convert.ToInt32(Console.ReadLine());
            if (e == null)
            {
                Console.WriteLine("Без пустого опыта нельзя");
                break;
            }
            Console.WriteLine("Введите группу здоровья: ");
            string h = Console.ReadLine();
            if (h == null)
            {
                Console.WriteLine("Без пустого группы здоровья нельзя");
                break;
            }
            Students.Add(new Student(i, n, d, g, e, h));
            break;
        case 2:
            for (int p = 0; p < Students.Count; p++)
            {
                Students[p].Print();
            }
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
        case 8:
            break;
        case 0:
            return;
    }
}

class Course
{
    private int Id;
    private string Title;
    private string Description;
    private string Teacher;
    private List<string> Names;

    public Course(int Id, string Title, string Description, string Teacher, List<string> Names)
    {
        this.Id = Id;
        this.Title = Title;
        this.Description = Description;
        this.Teacher = Teacher;
        this.Names = Names;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}\nDescription: {Description}\nTeacher: {Teacher} ");
        foreach (var be in Names)
        {
            Console.WriteLine(be);
        }
    }

}
class Person
{
    private string FIO;
    private DateOnly Birthday;
    private string Gender;

    public Person(string fio, DateOnly birthday, string gender)
    {
        FIO = fio;
        Birthday = birthday;
        Gender = gender;
    }
    public virtual void Print()
    {
        Console.WriteLine($"FIO: {FIO}\nBirthday: {Birthday}\nGender: {Gender} ");
    }
}

class Student : Person
{
    private int StudentNumberID;
    private int PCExperience;
    private string TheHealthGroup;

    public Student(int id, string fio, DateOnly birthday, string gender, int PCExperience, string TheHealthGroup)
        : base(fio, birthday, gender) // вызов конструктора Person
    {
        this.StudentNumberID = id;
        this.PCExperience = PCExperience;
        this.TheHealthGroup = TheHealthGroup;
    }

    public override void Print()
    {
        Console.WriteLine("Student");
        base.Print();
        Console.WriteLine($"StudentNumberID: {StudentNumberID}\nPCExperience: {PCExperience}\n");
        Console.WriteLine($"TheHealthGroup: {TheHealthGroup}\n");
    }
}

class Teacher : Person
{
    private int TeacherNumberID;
    private int ExperienceYears;

    public Teacher(int ID, string fio, DateOnly birthday, string gender, int WorkExperience)
        : base(fio, birthday, gender)
    {
        this.TeacherNumberID = ID;
        this.ExperienceYears = WorkExperience;
    }

    public override void Print()
    {
        Console.WriteLine("Teacher");
        base.Print();
        Console.WriteLine($"ID: {TeacherNumberID}\n");
        Console.WriteLine($"ExperienceYears: {ExperienceYears}\n");
    }
}




