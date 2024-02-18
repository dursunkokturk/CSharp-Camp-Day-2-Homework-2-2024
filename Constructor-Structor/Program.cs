
// Referance Tipler Ornek Calismalari

int number1 = 10;
int number2 = 20;

number1 = number2;
number2 = 100;

Console.WriteLine("Number 1 : " + number1);

int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };

numbers1 = numbers2;
numbers2[0] = 1000;

Console.WriteLine(numbers1[0]);

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Dursun";
person2 = person1;
person1.FirstName = "Hakan";
Console.WriteLine(person2.FirstName);

// Customer Object Ayni Zamanda Bir Person Class tir
Customer customer = new Customer();
customer.FirstName = "Sefa";

// Employee Object Ayni Zamanda Bir Person Class tir    
Employee employee = new Employee();

// Customer Object Ve Person Object
// Ayni Zamanda Bir Person Class Oldugundan
// Person Class Refansi Uzerinden Birbiri Ile Baglantilidir 
Person person3 = customer;
Console.WriteLine(person3.FirstName);

class Person
{
    public int id;
    public string FirstName;
    public string LastName;
}

class Customer : Person
{
    public string CreditNumber;
}

class Employee : Person
{
    public int EmployeeNumber;
}