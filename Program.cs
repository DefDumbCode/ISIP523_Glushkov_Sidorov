// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите свой текст: ");
string text = Console.ReadLine();
int count = 0;
int words = 0;
int sent = 0;
string small_word = "";
string big_word = "";
foreach(char let in text)
{
    if(let == ' ')
    {
        words++;
    }
    if (let == '-')
    {
        words--;
    }
    if(let == '.' || let == '!' || let == '?')
    {
        sent++;
    }
    count++;
    
}
words++;
if (count > 100) {
    Console.WriteLine(words);
    Console.WriteLine(sent);
}
else
{
    Console.WriteLine("В тексте меньше ста символов!");
}

