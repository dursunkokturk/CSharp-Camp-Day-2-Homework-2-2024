
// Interface

// Interface ler Kullanilarak
// new Anahtar Kelimesi Ile Object Olusturulamaz
//IPersonManager personManager = new IPersonManager();
//personManager.Add();
//personManager.Update();

// IPersonManager interface i Uzerinden Referans Kullanilarak
// CustomerManager Class ina Ulasip Object Olusturuyoruz
IPersonManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

// IPersonManager interface i Uzerinden Referans Kullanilarak
// EmployeeManager Class ina Ulasip Object Olusturuyoruz
IPersonManager employeeManager = new EmployeeManager();
employeeManager.Add();
employeeManager.Update();

// Class in Referansini Tutan Interface Uzerinden
// Islemleri Yapiyoruz
ProjectManager projectManager = new ProjectManager();
projectManager.AddCustomer(new CustomerManager());

// Interface Dosyalarinda
// Yapilacak Islemlerin Ve Kullanilacak Fonksiyonlarin
// Genel Olarak Neler Oldugunu Tanimliyoruz
interface IPersonManager
{
    void Add();
    void Update();
}

// Interface Dosyalarinda Yer Alan Ve Genel Hali Belirtilmis 
// Islemlerin Yada Fonksiyonlarin
// Kullanildigi class a Gore
// Hangi Islemi Nasil Yapacagini Duzenliyoruz
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }
}

// Interface Dosyalarinda Yer Alan Ve Genel Hali Belirtilmis 
// Islemlerin Yada Fonksiyonlarin
// Kullanildigi class a Gore
// Hangi Islemi Nasil Yapacagini Duzenliyoruz
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Employee Added");
    }

    public void Update()
    {
        Console.WriteLine("Employee Updated");
    }
}

// Tek Merkezden Yonetme Isleminde
// Interface Uzerinden Yonetim Yapilacagi Icin
// Parametre Olarak Hangisi Gonderilir Ise Islem Ona Gore Yapilacak
class ProjectManager
{
    public void AddCustomer(IPersonManager customerManager1)
    {
        customerManager1.Add();
    }
}