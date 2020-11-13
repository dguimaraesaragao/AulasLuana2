using System;

namespace Aula01.exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 15km em 50min e 30seg
               Considerando que um corredor de maratona corre 15 km em 50 minutos e 30 segundos.
               Escreva um programa que exiba a velocidade média por hora do corredor em milhas.
               Obs: 1 milha = 1.6 km
            */


            double velk;

                    double velm;
            double temph = 50.5;
            double temps = temph / 60;
            double dist = 15;

            
         


            velk = dist/temps;
            velm = velk / 1.6;

            Console.WriteLine("Velocidade Media em Kilometros/h e: {0:0.00} ", velk);
            Console.WriteLine("Velocidade Media em Milhas/h e: {0:0.00} ", velm );

            

        }
    }
}
