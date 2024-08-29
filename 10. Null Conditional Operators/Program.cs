//1 0.Null - şərti Operatorlar(Null Conditional Operators)
// ?. : Null - şərti üzvə daxil olma (Null-conditional member access)
// ?[] : Null - şərti indeksə daxil olma (Null-conditional index access)
// ?() : Null - şərti dəvət(Null - conditional delegate call)




using System;

class Program
{
    // `Person` sinfi
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    // `Address` sinfi
    class Address
    {
        public string City { get; set; }
    }

    // `MyDelegate` delege tipi
    delegate void MyDelegate(string message);

    static void Main()
    {
        // 10. Null-şərti Operatorlar (Null Conditional Operators)

        // ?. : Null-şərti üzvə daxil olma (Null-Conditional Member Access)
        Person person = new Person { Name = "Elçin" };
        // `Address` null olduğu üçün `City` üzərinə daxil olma əməliyyatı həyata keçirilməyəcək
        string cityName = person.Address?.City;  // `Address` null olduğu üçün `cityName` də null olacaq
        Console.WriteLine("City Name: " + cityName);  // Çıxış: City Name: 

        // Null-şərti üzvə daxil olma operatorunun digər nümunəsi
        Person personWithAddress = new Person { Name = "Rəşad", Address = new Address { City = "Bakı" } };
        string cityNameWithAddress = personWithAddress.Address?.City;  // `Address` null deyil, buna görə `City` qaytarılır
        Console.WriteLine("City Name: " + cityNameWithAddress);  // Çıxış: City Name: Bakı

        // ?[] : Null-şərti indeksə daxil olma (Null-Conditional Index Access)
        string[] names = null;
        // `names` null olduğu üçün indeksə daxil olma əməliyyatı həyata keçirilməyəcək
        string firstName = names?[0];  // `names` null olduğu üçün `firstName` də null olacaq
        Console.WriteLine("First Name: " + (firstName ?? "null"));  // Çıxış: First Name: null

        // ?() : Null-şərti dəvət (Null-Conditional Delegate Call)
        MyDelegate myDelegate = null;
        // `myDelegate` null olduğu üçün metod çağırışı həyata keçirilməyəcək
        myDelegate?.Invoke("Hello, world!");  // `myDelegate` null olduğuna görə heç bir şey çıxmayacaq

        // Null-şərti dəvət operatorunun digər nümunəsi
        MyDelegate anotherDelegate = message => Console.WriteLine(message);
        anotherDelegate?.Invoke("Hello, world!");  // `anotherDelegate` null deyil, ona görə metod çağırışı həyata keçirilir
    }
}
