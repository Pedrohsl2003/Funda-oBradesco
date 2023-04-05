using System;

namespace Formatação_Flot__Real__Porcentagem
{
    class Program

    {
        static void Main()
        {
            double x = 20.232;
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("P"));
        }
    }
}


