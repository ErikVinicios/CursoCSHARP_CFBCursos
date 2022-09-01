using System;

namespace Aula19
{
    class Program
    {
        static void Main()
        {
           int[] num = new int[10];

           for (int i=0;i<num.Length;i++){
            num[i]=i;
           }
           
           for (int i=0;i<num.Length;i++){
            Console.WriteLine($"Valor de num na posição {i}: {num[i]}");
           }
        }
    }
}
