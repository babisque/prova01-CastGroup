using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes
{
    public class Salesman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public double Selled { get; set; }
        public string[] Sells { get; set; }

        public Salesman(int id, string name, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
        }

        public void commissionTotal(Salesman salesman)
        {
            int sellAmount = salesman.Sells.Count();

            if (sellAmount > 0 && sellAmount <= 5)
            {
                double commission = Selled * 0.004;
                Console.WriteLine($"Total a ser pago de comissão será de R$ {commission}");
            }
            else if (sellAmount >= 6 && sellAmount <= 10)
            {
                double commission = Selled * 0.013;
                Console.WriteLine($"Total a ser pago de comissão será de R$ {commission}");
            }
            else if (sellAmount >= 10 && sellAmount <= 15)
            {
                double commission = Selled * 0.03;
                Console.WriteLine($"Total a ser pago de comissão será de R$ {commission}");
            }
            else
            {
                double commission = Selled * 0.05;
                Console.WriteLine($"Total a ser pago de comissão será de R$ {commission}");
            }
        }
    }
}
