using System;

namespace Aula19
{
    class Program
    {
        static void Main()
        {
           int[] num=new int[10];

           int i=0;
           while (i<10){
            num[i]=0;
            Console.WriteLine(num[i]);
            i++;
           }
           Console.WriteLine("Fim da execução");
        }
    }
}
