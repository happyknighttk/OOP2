﻿//4. Gün

using OOP1;

Product product1 = new Product { Id = 1, CategoryId = 2, ProductName = "Masa",
	UnitPrice = 500, UnitsInStock = 3 };

Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5,
	ProductName = "Kalem", UnitPrice = 35 };

//PascalCase   //camelCase
//case sensitive
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);

productManager.Topla2(3, 6);

int toplamaSonucu = productManager.Topla(3, 6);

Console.WriteLine(toplamaSonucu*2);

//int double bool değer tip
//diziler class abstract class interface referans tip
//ref out