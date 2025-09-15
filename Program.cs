// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//
int a = 0;
Console.WriteLine("Сколько операций у вас за сегодня было? (2-40)");
a = Convert.ToInt32(Console.ReadLine());
string[] Operations = new string[a];
int[] Prices = new int[a];
string request = "";
string[] words = new string[2];
for (int i = 0; i < a; i++)
{
    request = Console.ReadLine();
    words = request.Split(new char[] { ';' },
    StringSplitOptions.RemoveEmptyEntries);
    words[1] = words[1].Trim(); 
    Operations[i] = words[0];
    Prices[i] = Convert.ToInt32(words[1]);

    
}
