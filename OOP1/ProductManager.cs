using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	internal class ProductManager
	{
		//Encapsulation
		public void Add(Product product)
		{
            Console.WriteLine(product.ProductName + " eklendi.");
        }
		public void Update(Product product)
		{
			Console.WriteLine(product.ProductName + " güncellendi.");
		}
		public int Topla(int n1, int n2)
		{
			return n1 + n2;
		}
		public void Topla2(int n1, int n2)
		{
            Console.WriteLine(n1 + n2);
        }

	}
}
