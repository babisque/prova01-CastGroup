using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes
{
    public class ProductRepository
    {
        public static Product[] InitializeProduct()
        {
            return new Product[]
            {
                new Product("Camisa Polo", 15.90, 15),
                new Product("Bermuda Jeans", 10, 16),
                new Product("Camisa", 10.50, 12),
                new Product("Tenis Adidas", 300, 14),
                new Product("Calça Moletom", 99.99, 16)
            };
        }

        public static Product findByName(Product[] products, string name)
        {
            foreach (Product product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                    return product;
            }

            return null;
        }

        public static string productVerify(Product product)
        {
            int productAmount = product.Amount;

            if (productAmount <= 5)
            {
                return $"Você deve contatar ao gerente para que adquira mais {product.Name} para repor o estoque.";
            }
            else if (productAmount >= 100)
            {
                return $"O estoque de {product.Name} está cheio.";
            }

            return null;
        }
    }
}
