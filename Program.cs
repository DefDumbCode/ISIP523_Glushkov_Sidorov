// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите свой текст: ");
string text = Console.ReadLine();
int count = 0;
int words = 0;
int sent = 0;
List<string> small = new List<string>();
List<string> big = new List<string>();
string small_word = "бебебе";
string big_word = "б";
string small_check = "";
string big_check = "";
int vowel = 0;
int cons = 0;
foreach (char let in text.ToLower())
{
    if (let == ' ')
    {
        words++;
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
        words--;
    }
    else if (let == '.' || let == '!' || let == '?')
    {
        sent++;

    }
    else if (let == 'у' || let == 'е' || let == 'э' || let == 'о' || let == 'а' || let == 'ы' || let == 'я' || let == 'и' || let == 'ю' || let == 'ё')
    {
        vowel ++;
        small_check += let;
        big_check += let;
    }
    else if (let == '"' || let == ',' || let == ':')
    {
        continue;
    }
    else
    {
        cons++;
        small_check += let;
        big_check += let;
    }
    //Console.WriteLine(small_word);
    //Console.WriteLine(big_word);
    count++;
    
}
words++;
if (count > 100) {
    Console.WriteLine(words);
    Console.WriteLine(sent);
    Console.WriteLine(vowel);
    Console.WriteLine(cons);
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

}
else
{
    Console.WriteLine("В тексте меньше ста символов!");
}

