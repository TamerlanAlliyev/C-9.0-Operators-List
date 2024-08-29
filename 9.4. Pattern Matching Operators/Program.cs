//  12.Pattern Matching Operatorları(Pattern Matching Operators)
//  is : Tip yoxlama və pattern matching (Type checking and pattern matching)
//  switch : Switch ifadəsi ilə pattern matching    (Pattern matching with switch expression)



        // Bir obyekti təyin edirik
        object obj = 42;

        // Switch ifadəsi ilə pattern matching
        switch (obj)
        {
            case int intVal when intVal > 50:
                Console.WriteLine("The integer is greater than 50: " + intVal);
                break;
            case int intVal:
                Console.WriteLine("The integer is: " + intVal);
                break;
            case string str:
                Console.WriteLine("The string is: " + str);
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }

        // Yeni bir obyekti təyin edirik
        object anotherObj = 123;

        // `is` operatoru ilə pattern matching
        if (anotherObj is int val && val > 100)
        {
            // `anotherObj` dəyişəni `int` tipindədir və dəyəri 100-dən böyükdür
            Console.WriteLine("The number is greater than 100: " + val);  // Çıxış: The number is greater than 100: 123
        }
        else if (anotherObj is int anotherVal)
        {
            // `anotherObj` dəyişəni `int` tipindədir, amma 100-dən kiçikdir
            Console.WriteLine("The number is less than or equal to 100: " + anotherVal);  // Çıxış: The number is less than or equal to 100: 123
        }
        else
        {
            Console.WriteLine("The object is not an integer.");
        }
