using System;

namespace Aula05
{
    class Program
    {
        static void Main()
        {
            // & = AND / E
            // | = OR / OU

            bool res=(5>3)|(10>5);
            bool res2=(5<3)&(10>5);

            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}
