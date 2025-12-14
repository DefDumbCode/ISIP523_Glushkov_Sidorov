using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Action
{
    public class Random
    {
        public static readonly System.Random rng = new System.Random();

        public static int Next(int max) => rng.Next(max);
        public static int Next(int min, int max) => rng.Next(min, max);
        public static double NextDouble() => rng.NextDouble();
    }
}
