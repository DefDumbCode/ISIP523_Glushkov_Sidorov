// See https://aka.ms/new-console-template for more information

double count = 0;
int words = 0;
int sent = 0;
List<string> small = new List<string>();
List<string> big = new List<string>();
Dictionary <char, double> dictionary = new Dictionary<char, double>();
string small_word = "бебебе";
string big_word = "б";
string small_check = "";
string big_check = "";
int vowel = 0;
int cons = 0;

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

                Console.WriteLine("Введите свой текст: ");
                string text = Console.ReadLine();
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
                        vowel++;
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
                    else
                    {
                        cons++;
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
                    count++;

                }
                words++;
                if (count > 100)
                {
                    Console.WriteLine($"Знаков = {count}");
                    Console.WriteLine($"Слов = {words}");
                    Console.WriteLine($"Предложений = {sent}");
                    Console.WriteLine($"Гласных = {vowel}");
                    Console.WriteLine($"Согласных = {cons}");
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
                        double percentage = (ba.Value / count) * 100;
                        Console.WriteLine($"Буква = {ba.Key}; Кол-во = {ba.Value}; Процент от {count} = {percentage:f3};");
                    }

                }
                else
                {
                    Console.WriteLine("В тексте меньше ста символов!");
                }

                break;
            }
        case 2:
            {
                break;
            }
        case 0:
            {
                return;
            }
    }
}



