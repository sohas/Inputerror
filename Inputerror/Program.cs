using System;
using System.Text;

namespace Inputerror
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("введите текст и нажмите enter");
                Console.WriteLine();
                var text = Console.ReadLine();
                Console.WriteLine();
                foreach (var ch in text)
                    Console.Write(EngToRuss.GetChar(ch));
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
