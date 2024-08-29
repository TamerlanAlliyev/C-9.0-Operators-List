//  9.Null Birləşim Operatorları(Null Coalescing Operators)
//  ?? : Null birləşdirmə operatoru (Null coalescing operator)
//  ??= : Null birləşdirmə təyini operatoru (Null coalescing assignment operator)


// ?? : Null birləşdirmə operatoru (Null Coalescing Operator)
string name = null;
string defaultName = "Default Name";
string result = name ?? defaultName;  // `name` null olduğu üçün `defaultName` istifadə olunur
                                      // `name` null olduğuna görə nəticə: "Default Name"
Console.WriteLine("Null birləşdirmə operatoru (??): " + result);  // Çıxış: Default Name




// ?? operatorunun digər nümunəsi
string anotherName = "Actual Name";
string result2 = anotherName ?? "Another Default Name";  // `anotherName` null olmadığı üçün onun dəyəri istifadə olunur
                                                         // `anotherName` null deyil, buna görə nəticə: "Actual Name"
Console.WriteLine("Null birləşdirmə operatoru (??): " + result2);  // Çıxış: Actual Name




// ??= : Null birləşdirmə təyini operatoru (Null Coalescing Assignment Operator)
string someName = null;
someName ??= "Assigned Default Name";  // `someName` null olduğu üçün ona "Assigned Default Name" təyin edilir
                                       // `someName` null olduğuna görə ona dəyər təyin olunur
Console.WriteLine("Null birləşdirmə təyini operatoru (??=): " + someName);  // Çıxış: Assigned Default Name




// ??= operatorunun digər nümunəsi
string existingName = "Existing Name";
existingName ??= "New Assigned Name";  // `existingName` null olmadığı üçün heç bir şey təyin edilmir
                                       // `existingName` null deyil, ona görə dəyəri dəyişmir
Console.WriteLine("Null birləşdirmə təyini operatoru (??=): " + existingName);  // Çıxış: Existing Name