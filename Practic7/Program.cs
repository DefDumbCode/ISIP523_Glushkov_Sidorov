using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part Door = new Part
            {
                Name = "Дверь",
                Price = 50
            };

            Core.Context.Part.Add(Door);
            Core.Context.SaveChanges();

            Part Pipe = new Part
            {
                Name = "Выхлопная труба",
                Price = 75
            };

            Core.Context.Part.Add(Pipe);
            Core.Context.SaveChanges();

            Part Glass = new Part
            {
                Name = "Лобовое стекло",
                Price = 100
            };

            Core.Context.Part.Add(Glass);
            Core.Context.SaveChanges();

            Part Engine = new Part
            {
                Name = "Двигатель",
                Price = 150
            };

            Core.Context.Part.Add(Engine);
            Core.Context.SaveChanges();
        }
    }
}
