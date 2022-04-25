using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes
{
    public class SalesmanRepository
    {
        public static Salesman[] InitializeSalesman()
        {
            return new Salesman[]
            {
                new Salesman(1, "Rodrigo", "123456"),
                new Salesman(24, "Juan", "654321")
            };
        }

        public static bool Login(Salesman[] salesmen, int id, string pwd)
        {
            foreach (Salesman salesman in salesmen)
            {
                if (salesman.Id == id && salesman.Password == pwd)
                    return true;
            }

            return false;
        }

        public static Salesman findById(Salesman[] salesmen, int id)
        {
            foreach(Salesman salesman in salesmen)
            {
                if (salesman.Id == id)
                    return salesman;
            }

            return null;
        }
    }
}
