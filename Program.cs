// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

double c = 0;
int w = 0;
int s = 0;
List<string> small = new List<string>();
List<string> big = new List<string>();
Dictionary <char, double> dictionary = new Dictionary<char, double>();
string small_word = "бебебе";
string big_word = "б";
string small_check = "";
string big_check = "";
int v = 0;
int con = 0;
string glas = "аеёиоуыэюяaeiouy";
string sogl = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxz";

List <Stat> statist = new List<Stat>();

bool a = true;
while (a)
{
    Console.WriteLine("-----МЕНЮ-----");
    Console.WriteLine("1 - Разобрать текст");
    Console.WriteLine("2 - Вывести статистику по предыдущим текстам");
    Console.WriteLine("0 - Выход");

    int o = Convert.ToInt32(Console.ReadLine());
    switch (o)
    {
        case 1:
            {
                c = 0;
                w = 0;
                s = 0;
                v = 0;
                con = 0;
                small.Clear();
                big.Clear();
                dictionary.Clear();
                small_word = "бебебе";
                big_word = "б";
                small_check = "";
                big_check = "";

                Console.WriteLine("Введите свой текст: ");
                string t = Console.ReadLine();
                foreach (char let in t.ToLower())
                {
                    if (let == ' ')
                    {
                        w++;
                        if (small_check == "")
                        {
                            continue;
                        }
                        if (small_check.Length < small_word.Length)
                        {
                            small_word = small_check;
                            small_check = "";
                            small.Clear();
                        }
                        else if (small_check.Length == small_word.Length)
                        {
                            small.Add(small_check);
                            small_check = "";
                        }
                        if (big_check.Length > big_word.Length)
                        {
                            big_word = big_check;
                            big_check = "";
                            big.Clear();
                        }
                        else if (big_check.Length == big_word.Length)
                        {
                            big.Add(big_check);
                            big_check = "";
                        }
                        small_check = "";
                        big_check = "";
                    }
                    else if (let == '-')
                    {
                        w--;
                    }
                    else if (let == '.' || let == '!' || let == '?')
                    {
                        s++;

                    }
                    else if (glas.Contains(let))
                    {
                        v++;
                        small_check += let;
                        big_check += let;
                        if (dictionary.ContainsKey(let))
                        {
                            dictionary[let]++;
                        }
                        else
                        {
                            dictionary[let] = 1;
                        }
                    }
                    else if (let == '"' || let == ',' || let == ':')
                    {
                        continue;
                    }
                    else if (!glas.Contains(let))
                    {
                        con++;
                        small_check += let;
                        big_check += let;
                        if (dictionary.ContainsKey(let))
                        {
                            dictionary[let]++;
                        }
                        else
                        {
                            dictionary[let] = 1;
                        }
                    }
                    //Console.WriteLine(small_word);
                    //Console.WriteLine(big_word);
                    c++;

                }
                w++;
                if (c > 100)
                {
                    Console.WriteLine($"Знаков = {c}");
                    Console.WriteLine($"Слов = {w}");
                    Console.WriteLine($"Предложений = {s}");
                    Console.WriteLine($"Гласных = {v}");
                    Console.WriteLine($"Согласных = {con}");
                    Console.WriteLine("Список самых маленьких слов: ");
                    foreach (var slovo in small)
                    {
                        Console.WriteLine(slovo);
                    }
                    Console.WriteLine("Список самых больших слов: ");
                    foreach (var be in big)
                    {
                        Console.WriteLine(be);
                    }

                    Console.WriteLine("Процентное соотношение букв в тексте: ");
                    foreach (var ba in dictionary)
                    {
                        double percentage = (ba.Value / c) * 100;
                        Console.WriteLine($"Буква = {ba.Key}; Кол-во = {ba.Value}; Процент от {c} = {percentage:f3};");
                    }

                }
                else
                {
                    Console.WriteLine("В тексте меньше ста символов!");
                }

                statist.Add(new Stat(t, c, w, s, v, con, small, big, dictionary));

                break;
            }
        case 2:
            {
                for (int i = 0; i < statist.Count; i++)
                {
                    Console.WriteLine($"Текст #{i + 1}");
                    statist[i].PrintInfo();
                }
                break;
            }
        case 0:
            {
                return;
            }
    }
}

class Stat
{


    public string text;
    public double count;
    public int words;
    public int sent;
    public int vowel;
    public int cons;
    public List<string> small;
    public List<string> big;
    public Dictionary<char, double> dictionary;
    

    public Stat(string text, double count, int words, int sent, int vowel, int cons, List<string> small, List<string> big, Dictionary<char, double> dictionary)
    {
        this.text = text;
        this.count = count;
        this.words = words;
        this.sent = sent;
        this.vowel = vowel;
        this.cons = cons;
        this.small = small;
        this.big = big;
        this.dictionary = dictionary;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Текст: {text}");
        Console.WriteLine($"Знаки: {count}");
        Console.WriteLine($"Слов: {words}");
        Console.WriteLine($"Предложений: {sent}");
        Console.WriteLine($"Гласных: {vowel}");
        Console.WriteLine($"Согласных: {cons}");

        Console.WriteLine("Самые маленькие слова:");
        foreach (var be in small)
        {
            Console.WriteLine(be);
        }

        Console.WriteLine("Самые большие слова:");
        foreach (var ba in big)
        {
            Console.WriteLine(ba);
        }

        Console.WriteLine("Частота букв:");
        foreach (var letter in dictionary)
        {
            double percentage = (letter.Value / count) * 100;
            Console.WriteLine($"  {letter.Key}: {letter.Value} шт. ({percentage:f2}%)");
        }
    }
}



