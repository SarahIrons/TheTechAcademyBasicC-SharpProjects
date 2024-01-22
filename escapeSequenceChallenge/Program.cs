using System;
using System.Diagnostics;

namespace escapeSequenceChallenge
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi,\n");
            Console.WriteLine("\n do you like apples?");
            Console.Write(Console.ReadLine());
            Console.Write(Console.ReadLine());
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
