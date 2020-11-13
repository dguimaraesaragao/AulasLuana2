using System;
using System.Net.Http;

namespace Aula01.Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Double m;
            Double n1 = 6.5;
            Double n2 = 7.8;
            Double n3 = 8.0;
            Double n4 = 7.1;
            Double p1=2;
            Double p2=2;
            Double p3=3;
            Double p4=3;

            m = ((n1 * p1) + (n2 * p2) + (n3 * p3) + (n4 * p4))/ (p1 + p2 + p3 + p4);
            
           // Console.WriteLine("A Media ponderada de Notas de Gabriel e " + m );
            //com texto mas nao consigo colocar apenas duas casas decimais


            Console.WriteLine("A Media ponderada de Notas de Gabriel e {0:0.00}", m); 
            //forma decimal com dois digitos mas sem texto
        }
    }
}
