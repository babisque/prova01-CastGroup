using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinhacao
{
    public class Game
    {
        Random random = new Random();

        public void easy()
        {
            int numberComputer = this.random.Next(25);
            int attemptCounter = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Tente um número de 0 a 25: ");
                int attempt = int.Parse(Console.ReadLine());

                if (attempt == numberComputer)
                {
                    attemptCounter++;
                    Console.Clear();
                    Console.WriteLine($"Você acertou com {attemptCounter} tentativas!");
                    break;
                }
                else if (attempt > numberComputer)
                {
                    Console.WriteLine("EROOOOUUUUU!! Está frio... precisa chutar um número menor");
                }
                else if (attempt < numberComputer)
                {
                    Console.WriteLine("Xiiii... Passou longe... precisa chutar um número maior");
                }

                Console.WriteLine("Gostaria de tentar novamente? (Sim/Nao) ");
                string choose = Console.ReadLine();

                if (choose.ToLower() == "nao")
                {
                    Console.WriteLine($"Você desistiu após {attemptCounter} tentativas");
                    break;
                }

                attemptCounter++;
            }
        }

        public void medium()
        {
            int numberComputer = this.random.Next(25);
            int attemptCounter = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Tente um número de 0 a 25: ");
                int attempt = int.Parse(Console.ReadLine());
                int difference = attempt - numberComputer;

                if (difference < 0)
                {
                    difference = Math.Abs(difference);
                }

                if (attempt == numberComputer)
                {
                    attemptCounter++;
                    Console.Clear();
                    Console.WriteLine($"Você acertou com {attemptCounter} tentativas!");
                    break;
                }
                else if (difference <= 5)
                {
                    Console.WriteLine("Você passou perto, mas ainda não é este o número!");
                }
                else
                {
                    Console.WriteLine("Número incorreto.");
                }

                Console.WriteLine("Gostaria de tentar novamente? (Sim/Nao) ");
                string choose = Console.ReadLine();

                if (choose.ToLower() == "nao")
                {
                    Console.WriteLine($"Você desistiu após {attemptCounter} tentativas");
                    break;
                }

                attemptCounter++;
            }
        }

        public void hard()
        {
            int numberComputer = this.random.Next(51);
            int attemptCounter = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Tente um número de 0 a 50: ");
                int attempt = int.Parse(Console.ReadLine());
                int difference = attempt - numberComputer;

                if (difference < 0)
                {
                    difference = Math.Abs(difference);
                }

                if (attempt == numberComputer)
                {
                    attemptCounter++;
                    Console.Clear();
                    Console.WriteLine($"Você acertou com {attemptCounter} tentativas!");
                    break;
                }
                else if (difference <= 10)
                {
                    Console.WriteLine("Você passou perto, mas ainda não é este o número!");
                }
                else
                {
                    Console.WriteLine("Número incorreto.");
                }

                Console.WriteLine("Gostaria de tentar novamente? (Sim/Nao) ");
                string choose = Console.ReadLine();

                if (choose.ToLower() == "nao")
                {
                    Console.WriteLine($"Você desistiu após {attemptCounter} tentativas");
                    break;
                }

                attemptCounter++;
            }
        }

        public void legend()
        {
            int numberComputer = this.random.Next(51);
            int attemptCounter = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Tente um número de 0 a 50: ");
                int attempt = int.Parse(Console.ReadLine());

                if (attempt == numberComputer)
                {
                    attemptCounter++;
                    Console.Clear();
                    Console.WriteLine($"Cê é o bichão memo, em doido!! Acertou com {attemptCounter} tentativas!");
                    break;
                }

                Console.WriteLine("Gostaria de tentar novamente? (Sim/Nao) ");
                string choose = Console.ReadLine();

                if (choose.ToLower() == "nao")
                {
                    Console.WriteLine($"Você desistiu após {attemptCounter} tentativas");
                    break;
                }

                attemptCounter++;
            }
        }
    }
}
