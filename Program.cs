// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

List<string> Courses = new List<string>();
List<string> Names = new List<string>();

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
    private List<string> Courses;
    private string TheHealthGroup;

    public Student(int id, string fio, DateOnly birthday, string gender, int PCExperience, List<string> Courses, string TheHealthGroup)
        : base(fio, birthday, gender) // вызов конструктора Person
    {
        StudentNumberID = id;
        this.PCExperience = PCExperience;
        this.Courses = Courses;
        this.TheHealthGroup = TheHealthGroup;
    }

    public override void Print()
    {
        Console.WriteLine("Student");
        base.Print();
        Console.WriteLine($"StudentNumberID: {StudentNumberID}\nPCExperience: {PCExperience}\n");
        Console.WriteLine("Courses:");
        foreach (var be in Courses)
        {
            Console.WriteLine(be);
        }
        Console.WriteLine($"TheHealthGroup: {TheHealthGroup}\n");
    }
}

class Teacher : Person
{
    private List<string> Courses;
    private int ExperienceYears;

    public Teacher(string fio, DateOnly birthday, string gender, List<string> Courses, int WorkExperience)
        : base(fio, birthday, gender)
    {
        Courses = Courses;
        ExperienceYears = WorkExperience;
    }

    public override void Print()
    {
        Console.WriteLine("Teacher");
        base.Print();
        foreach (var be in Courses)
        {
            Console.WriteLine(be);
        }
        Console.WriteLine($"ExperienceYears: {ExperienceYears}\n");
    }
}




