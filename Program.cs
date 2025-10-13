// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

List<string> CourseNames = new List<string>();
List<Student> Students = new List<Student>();
List<Teacher> Teachers = new List<Teacher>(); 
List<string> StudentName = new List<string>();
List<Course> Courses = new List<Course>();


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
    Console.WriteLine("7 - Найти по ФИО курсыыы");
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
            StudentName.Add(n);
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
            Console.WriteLine("Введите ID: ");
            int ii = Convert.ToInt32(Console.ReadLine());
            if (ii == null)
            {
                Console.WriteLine("Без пустого айди нельзя");
                break;
            }
            Console.WriteLine("Введите ФИО: ");
            string nn = Console.ReadLine();
            if (nn == null)
            {
                Console.WriteLine("Без пустого имени нельзя");
                break;
            }
            Console.WriteLine("Введите Дату рождения: (YYYY,MM,DD)");
            DateOnly dd = DateOnly.Parse(Console.ReadLine());
            bool bb = DateOnly.TryParse(Console.ReadLine(), out dd);
            if (bb == false)
            {
                Console.WriteLine("Ты пишешь херню.");
                break;
            }
            if (dd == null)
            {
                Console.WriteLine("Без пустого др нельзя");
                break;
            }
            Console.WriteLine("Введите пол: ");
            string gg = Console.ReadLine();
            if (gg == null)
            {
                Console.WriteLine("Без пустого пола нельзя");
                break;
            }
            Console.WriteLine("Введите опыт работы с ПК В ГОДАХ: ");
            int ee = Convert.ToInt32(Console.ReadLine());
            if (ee == null)
            {
                Console.WriteLine("Без пустого опыта нельзя");
                break;
            }
            Teachers.Add(new Teacher(ii, nn, dd, gg, ee));
            break;
        case 4:
            for (int p = 0; p < Teachers.Count; p++)
            {
                Teachers[p].Print();
            }
            break;
        case 5:
            Console.WriteLine("Введите ID: ");
            int iii = Convert.ToInt32(Console.ReadLine());
            if (iii == null)
            {
                Console.WriteLine("Без пустого айди нельзя");
                break;
            }
            Console.WriteLine("Введите Название курса: ");
            string nnn = Console.ReadLine();
            if (nnn == null)
            {
                Console.WriteLine("Без пустого Названия нельзя");
                break;
            }
            Console.WriteLine("Введите описание курса: ");
            string ddd = Console.ReadLine();
            if (ddd == null)
            {
                Console.WriteLine("Без пустого описания нельзя");
                break;
            }
            Console.WriteLine("Введите ФИО Преподавателя курса: ");
            string ttt = Console.ReadLine();
            if (ttt == null)
            {
                Console.WriteLine("Без пустого имени нельзя");
                break;
            }
            Console.WriteLine("Введите ФИО студентов курса через Enter. как закончите наберите 0: ");
            bool jj = true;
            while (jj)
            {
                string baba = Console.ReadLine();
                int count = 0;
                for (int x = 0; x < StudentName.Count; x++)
                {
                    if (baba == StudentName[x])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    CourseNames.Add(baba);
                }
                else
                {
                    Console.WriteLine("Такого студента нету в базе данных!");
                }
                if (baba == "0")
                {
                    Courses.Add(new Course(iii, nnn, ddd, ttt, CourseNames));
                    break;
                }
            }
            break;
        case 6:
            for (int p = 0; p < Courses.Count; p++)
            {
                Courses[p].Print();
            }
            break;
        case 7:
            Console.WriteLine("Введите ФИО по которому хотите провести поиски: ");
            string bebebe = Console.ReadLine();
            for(int x = 0; x < Courses.Count; x++)
            {
                if (Courses[x].CourseNames.Contains(bebebe))
                {
                    Console.WriteLine(Courses[x].Title);
                }
            }
            break;
        case 8:
            for (int p = 0; p < Students.Count; p++)
            {
                Students[p].Print();
            }
            for (int p = 0; p < Teachers.Count; p++)
            {
                Teachers[p].Print();
            }
            for (int p = 0; p < Courses.Count; p++)
            {
                Courses[p].Print();
            }
            break;
        case 0:
            return;
    }
}

class Course
{
    private int Id;
    public string Title;
    private string Description;
    private string Teacher;
    public List<string> CourseNames;

    public Course(int Id, string Title, string Description, string Teacher, List<string> CourseNames)
    {
        this.Id = Id;
        this.Title = Title;
        this.Description = Description;
        this.Teacher = Teacher;
        this.CourseNames = CourseNames;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}\nDescription: {Description}\nTeacher: {Teacher} ");
        foreach (var be in CourseNames)
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




