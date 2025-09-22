// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Product
{
    public static int Id = 1;
    public string Name;
    public int Price;
    public int Quant;

    public Product(string Name, int Price, int Quant)
    {
        Id++;
        this.Name = Name;
        this.Price = Price;
        this.Quant = Quant;
    }
}