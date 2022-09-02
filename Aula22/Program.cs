using System;

namespace Aula22
{
    class Program
    {
        static void Main()
        {
           int[] num=new int[5];

           for (int i=0;i<num.Length;i++){
            num[i]=i;
           }

           foreach(int i in num){
            Console.WriteLine(i);
           }
        }
    }
}
