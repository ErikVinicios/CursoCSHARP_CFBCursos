using System;

namespace Aula18
{
    class Program
    {
        static void Main()
        {
           int[,] n= new int[2,2];
           int[,] num= new int[2,2]{{1,2},{3,4}};

           n[0,0]=2;
           n[0,1]=4;
           n[1,0]=6;
           n[1,1]=8;

           for(int i=0;i<2;i++){
            for(int j=0;j<2;j++){
                Console.Write($"|{n[i,j]}|");
            }
            Console.WriteLine("");
           }
        }
    }
}
