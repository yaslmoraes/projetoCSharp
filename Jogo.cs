using System;
using System.Collections.Generic;
using System.Text;

namespace projetoCSharp
{
    internal class Jogo
    {
        public Jogo()
        {
            Random aleatorio = new Random();

            int numeroAleatorio = aleatorio.Next(1, 101);

            Console.Write("Qual o numero aleatorio? ");
            int chute = int.Parse(Console.ReadLine()!);

            do
            {
                if (numeroAleatorio > chute)
                {
                    Console.WriteLine($"O numero aleatorio e maior que {chute}");
                    chute = int.Parse(Console.ReadLine()!);
                }
                else if (numeroAleatorio < chute)
                {
                    Console.WriteLine($"O numero aleatorio e menor que {chute}");
                    chute = int.Parse(Console.ReadLine()!);
                }
            }
            while (chute != numeroAleatorio);
            Console.WriteLine($"Correto! O numero aleatorio e: {numeroAleatorio}");
        }
    }
}
