// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите свой текст: ");
string text = Console.ReadLine();
int count = 0;
int words = 0;
int sent = 0;
string small_word = "";
string big_word = "";
int vowel = 0;
int cons = 0;
foreach (char let in text)
{
    if (let == ' ')
    {
        words++;
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
    }
    else if (let == '"' || let == ',' || let == ':')
    {
        continue;
    }
    else
    {
        cons++;
    }

    count++;
    
}
words++;
if (count > 100) {
    Console.WriteLine(words);
    Console.WriteLine(sent);
    Console.WriteLine(vowel);
    Console.WriteLine(cons);
}
else
{
    Console.WriteLine("В тексте меньше ста символов!");
}

