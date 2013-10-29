using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array de Clientes
            var customers = new Customer[]
	{
	    new Customer{ID = 5, Name = "Sam"},
	    new Customer{ID = 6, Name = "Dave"},
	    new Customer{ID = 7, Name = "Julia"},
	    new Customer{ID = 8, Name = "Sue"}
	};

            // Array de ordenes
            var orders = new Order[]
	{
	    new Order{ID = 2, Product = "Libro"},
	    new Order{ID = 6, Product = "Juego"},
	    new Order{ID = 7, Product = "Computadora"},
	    new Order{ID = 8, Product = "Camiseta"}
	};

            // query de Join
            var query = from c in customers
                        join o in orders on c.ID equals o.ID
                        select new { c.Name, o.Product };

                  

            //Imprimir el grupo unido
            foreach (var group in query)
            {
                Console.WriteLine("{0} Compro {1}", group.Name, group.Product);
            }
            Console.ReadLine();
        }
    }
}
