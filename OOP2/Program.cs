//5. Gün

using OOP2;

GercekMusteri customer1 = new GercekMusteri();
customer1.CustomerNo = "12345";
customer1.FirstName = "Engin";
customer1.LastName = "Demiroğ";
customer1.TcNo = "12345678910";

TuzelMusteri customer2 = new TuzelMusteri();
customer2.Id = 2;
customer2.CustomerNo = "53123";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNo = "1234567876";

//Gerçek Müşteri - Tüzel Müşteri
//SOLID

Customer customer3 = new GercekMusteri();
Customer customer4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);

