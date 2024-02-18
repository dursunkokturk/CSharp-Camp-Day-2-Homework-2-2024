
// Constructor Structor

// Array Yapisi Icinde Class Icindeki Ozelliklere Deger Atama Islemi
Customer customer1 = new Customer { Id = 1, FirstName = "Dursun", LastName = "Köktürk", City = "Zonguldak" };
Console.WriteLine(customer1.FirstName);

// Method Yapisi Icinde Class Icindeki Ozelliklere Deger Atama Islemi
Customer customer2 = new Customer(2, "Hakan", "Acar", "Karabük");
Console.WriteLine(customer2.FirstName);

// Object Yapisi Icinde Class Icindeki Ozelliklere Deger Atama Islemi
Customer customer3 = new Customer();
customer3.FirstName = "Sefa";
customer3.LastName = "Ak";
customer3.City = "Samsun";
Console.WriteLine(customer3.FirstName);

class Customer
{
    // Uygulama Calistirildiginda
    // Parametresiz Constructor Arka Planda Her Zaman Calisir
    public Customer()
    {

    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}