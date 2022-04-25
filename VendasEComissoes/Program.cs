using System;

namespace VendasEComissoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] allProducts = ProductRepository.InitializeProduct();
            Salesman[] allSalesmen = SalesmanRepository.InitializeSalesman();

            Console.WriteLine("Página de login");
            Console.Write("\nId: ");
            int idLogin = int.Parse(Console.ReadLine());

            Console.Write("Senha: ");
            string pwdLogin = Console.ReadLine();

            if (!(SalesmanRepository.Login(allSalesmen, idLogin, pwdLogin)))
            {
                Console.WriteLine("Vendedor não encontrado");
                return;
            }

            Salesman salesman = SalesmanRepository.findById(allSalesmen, idLogin);

            Console.Clear();

            while (true)
            {
                Console.WriteLine($"Seja bem vindo, {salesman.Name}");
                Console.Write("Produto sendo vendido: ");
                string productName = Console.ReadLine();

                Product product = ProductRepository.findByName(allProducts, productName);

                if (product == null || product.Amount < 1)
                {
                    Console.WriteLine("Não há quantidade no estoque suficiente.");
                    break;
                }

                Console.WriteLine(ProductRepository.productVerify(product));

                product.Amount -= 1;
                salesman.Selled += product.Price;
                salesman.Sells = new string[] { product.Name };
                Console.WriteLine($"\nVenda feita com sucesso, agora temos {product.Amount} unidades em estoque.");

                Console.Write("\nDeseja fazer outra venda? (s/n) ");
                string option = Console.ReadLine();

                if (option == "n")
                    break;

                Console.Clear();
            }

            salesman.commissionTotal(salesman);
        }        
    }
}
