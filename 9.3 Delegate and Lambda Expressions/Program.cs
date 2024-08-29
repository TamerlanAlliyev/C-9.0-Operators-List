//  11.Delege və Lambda İfadələri (Delegate and Lambda Expressions)
//  => : Lambda operatoru(Lambda operator)


class Program
{
    // Delegate declaration
    delegate void PrintMessage(string message);

    static void Main()
    {
        // 11. Delege və Lambda İfadələri (Delegate and Lambda Expressions)

        // Lambda ifadəsi istifadə edərək delege təyini
        PrintMessage print = message => Console.WriteLine(message);

        // Lambda ifadəsi ilə metod çağırışı
        print("Hello, Lambda!");  // Çıxış: Hello, Lambda!

        // Lambda ifadəsi ilə digər nümunə
        PrintMessage anotherPrint = msg =>
        {
            string formattedMessage = $"Message: {msg}";
            Console.WriteLine(formattedMessage);
        };

        anotherPrint("This is a formatted message.");  // Çıxış: Message: This is a formatted message.
    }
}