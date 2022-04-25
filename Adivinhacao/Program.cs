using System;

namespace Adivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao jogo de adivinhação! Selecione o nível de dificuldade: ");
            Console.WriteLine("\n\t1. Fácil: Número de 0 a 25, com muitas dicas para encontrar o número");
            Console.WriteLine("\n\t2. Médio: Número de 0 a 25, com poucas dicas para encontrar o núemro");
            Console.WriteLine("\n\t3. Difícil: Número de 0 a 50, com poucas dicas para encontrar o núemro");
            Console.WriteLine("\n\t4. Lendário: Número de 0 a 50 sem dicas!");
            Console.Write("\n\nDigite sua opção: ");
            int option = int.Parse(Console.ReadLine());

            Game game = new Game();

            switch (option)
            {
                case 1:
                    game.easy();
                    break;

                case 2:
                    game.medium();
                    break;

                case 3:
                    game.hard();
                    break;

                case 4:
                    game.legend();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            
        }
    }
}
