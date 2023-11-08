//3. Gün C# Temelleri 2
//Don't repeat yourself - DRY - Clean Code - Best Practice

using Methods;

Product product1 = new Product { Name = "Elma", Price = 15, Description = "Amasya elması" };
Product product2 = new Product { Name = "Karpuz", Price = 80, Description = "Diyarbakır karpuzu" };

Product[] products = new Product[] { product1, product2 };

//Type-Safe
foreach (Product product in products)
{
    Console.WriteLine("Ürün: "+product.Name);
    Console.WriteLine("Açıklama: " + product.Description);
    Console.WriteLine("Fiyat: " + product.Price);
    Console.WriteLine("---------------------------------");
}

Console.WriteLine("------------------Metotlar------------------");

//Instance - Örnek
SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);

sepetManager.Add2("Armut", "Yeşil armut", 12, 10);
sepetManager.Add2("Elma", "Yeşil elma", 12, 2);
sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 3);

