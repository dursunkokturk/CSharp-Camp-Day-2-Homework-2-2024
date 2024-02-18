
// Linq

List<Category> categories = new List<Category>
{
    new Category{CategoryId=1,CategoryName="Bilgisayar"},
    new Category{CategoryId=2,CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantiyPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantiyPerUnit="16 GB Ram",UnitPrice=8000,UnitsInStock=5},
    new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantiyPerUnit="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
    new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantiyPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
    new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantiyPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=0},
};


Console.WriteLine("Algoritmik Kod Yapisi Kullanilarak Yapilan Islem Sonucu");
// List Icindeki Array Tipinde Bulunan Data lari Listeliyoruz
foreach (var product in products)
{
    // Listelenecek Data lar Icin Sartlar Belirtiyoruz
    if (product.UnitPrice>5000 && product.UnitsInStock>3)
    {
        Console.WriteLine(product.ProductName);
    }
}

Console.WriteLine("Linq Kod Yapisi Kullanilarak Yapilan Islem Sonucu");
// Linq Icindeki Array Tipinde Bulunan Data lari Listeliyoruz
var results = products.Where(products=>products.UnitPrice>5000 && products.UnitsInStock>3);

foreach (var result in results)
{
    // Listelenecek Data lar Icin Sartlar Belirtiyoruz
    Console.WriteLine(result.ProductName);
}


static List<Product> GetProducts(List<Product>products)
{
    // Kullanicinin Tercihlerinden Olusan Listeden Yeni Bir Array Olusturuyoruz
    List<Product> filteredProducts = new List<Product>();

    foreach (var product in products)
    {
        // Listelenecek Data lar Icin Sartlar Belirtiyoruz
        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
        {
            // Kullanici Tercihlerinden Olusan Listeyi Array Yapisi Icine Aliyoruz
            filteredProducts.Add(product);
        }
    }

    return filteredProducts;
}

static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(products => products.UnitPrice > 5000 && products.UnitsInStock > 3).ToList();
}



class Product
{
    public int ProductId { get; set; }

    // Urun Kategori Bilgisini Degistirmek Gerektiginde
    // Bu Islemi Urun Bilgileri Icinde
    // Category Id Bilgisini Kullanarak Yapiyoruz
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantiyPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}