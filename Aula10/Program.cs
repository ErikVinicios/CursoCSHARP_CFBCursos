using System;

namespace Aula09
{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    class Program
    {
        static void Main()
        {
            DiasSemana ds = DiasSemana.Sexta;
            Console.WriteLine(ds);

            DiasSemana ds2 = (DiasSemana)3;
            Console.WriteLine(ds2);     

            int ds3 = (int)DiasSemana.Sexta;
            Console.WriteLine(ds3);       
        }
    }
}
