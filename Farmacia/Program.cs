using System;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allDrugs = { "Amoxicilina", "Cimegripe", "Glifage", "Leverctin", "Torsilax", "Avamys", "Glyxambi" };

            while (true)
            {
                Console.WriteLine("Bem vindo ao sistema da Fármacia Cast!");
                Console.WriteLine("\t1. Buscar um remédio.");
                Console.WriteLine("\t2. Buscar nome pelo sufixo");
                Console.WriteLine("\t3. Ver todos os remédios.");
                Console.WriteLine("\t4. Sair");
                Console.Write("\n\nDigite sua opção: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 4) break;                

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o nome do remédio desejado: ");
                        string drugToSearch = Console.ReadLine();
                        
                        foreach (string drug in allDrugs)
                        {
                            if (drug.ToLower() == drugToSearch.ToLower())
                            {
                                Console.WriteLine($"{drug} encontrado, posição no estoque {Array.IndexOf(allDrugs, drug)}!");
                            }                            
                        }

                        Console.Write("\n\nTecle ENTER para sair...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Digite o sufixo do remédio: ");
                        string sufixToSearch = Console.ReadLine();

                        foreach (string drug in allDrugs)
                        {
                            if (drug.EndsWith(sufixToSearch))
                            {
                                Console.WriteLine($"{drug} encontrado.");
                            }
                        }

                        Console.Write("\n\nTecle ENTER para sair...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Array.Sort(allDrugs);
                        Console.WriteLine($"Total de remédios: {(allDrugs.Length) + 1}");
                        foreach (string drug in allDrugs)
                        {
                            Console.WriteLine($"\t-{drug}");
                        }

                        Console.Write("\n\nTecle enter para voltar para o menu...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Clear();
            }
        }
    }
}
