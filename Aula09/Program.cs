using System;

namespace Aula09
{
    class Program
    {
        static void Main()
        {
            int num=10;

            Console.WriteLine(num);
            
            num=num<<1; // Bitwise pra ESQUERDA dobra o valor
            
            Console.WriteLine(num);
            
            num=num>>1; // Bitwise pra DIREITA divide o valor
            
            Console.WriteLine(num);        }
    }
}
