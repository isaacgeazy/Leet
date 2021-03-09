using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string diga;

            Console.Write("DIGA ALGO: ");
            diga = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{diga.Replace("a","4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("t","7").Replace("s","5")}");
            
        }
    }
}
