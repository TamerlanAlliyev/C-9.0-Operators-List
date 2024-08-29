//  14.Yeni C# Operatorları (New C# Operators)
//  ^ : İndeks operatoru(C# 8.0) (Index operator)
//  .. : Aralıq operatoru(C# 8.0) (Range operator)
//  => : Lambda operatoru switch ifadəsində (C# 8.0) (Lambda operator in switch expression)
//  ??= : Null birləşdirmə təyini operatoru (C# 8.0) (Null coalescing assignment operator)
//  with : Record tiplərinin səth nüsxələnməsi və dəyişdirilməsi (C# 9.0) (Record types shallow copy and modification)
//  init : Yalnız ilkinləşdirmə zamanı təyin edilə bilər (C# 9.0) (Can only be assigned during initialization)
//  record : Dəyişməzlik və pattern matching üçün istifadə olunur (C# 9.0) (Used for immutability and pattern matching)
//  .. : Listlərdə və massivlərdə aralıq istifadə (C# 9.0) (Range usage in lists and arrays)




public record Person(string Name, int Age);  // Record tipi nümunəsi
public class Student  // Init xüsusiyyəti nümunəsi
{
    public string Name { get; init; }
    public int Age { get; init; }
}

class Program
{
    static void Main()
    {
        // 1. İndeks operatoru (Index Operator)
        int[] numbers = { 1, 2, 3, 4, 5 };
        int lastNumber = numbers[^1];  // Son elementi götürür: 5
        Console.WriteLine($"Son element: {lastNumber}");

        // 2. Aralıq operatoru (Range Operator)
        int[] subArray = numbers[1..4];  // 1-ci elementdən 3-cü elementə qədər götürür: { 2, 3, 4 }
        Console.WriteLine($"SubArray: {string.Join(", ", subArray)}");

        // 3. Lambda operatoru switch ifadəsində (Lambda Operator in Switch Expression)
        int day = 3;
        string dayName = day switch
        {
            1 => "Bazar ertəsi",
            2 => "Çərşənbə axşamı",
            3 => "Çərşənbə",
            _ => "Naməlum gün"
        };
        Console.WriteLine($"Gün: {dayName}");

        // 4. Null birləşdirmə təyini operatoru (Null Coalescing Assignment Operator)
        string? name = null;
        name ??= "Elçin";  // Əgər `name` null-dursa, ona "Elçin" təyin et
        Console.WriteLine($"Ad: {name}");  // Çıxış: Ad: Elçin

        // 5. Record tiplərinin səth nüsxələnməsi və dəyişdirilməsi (Record Types Shallow Copy and Modification)
        Person originalPerson = new("Aysel", 25);
        Person copiedPerson = originalPerson with { Age = 30 };  // Yalnız yaş dəyəri dəyişdirilir
        Console.WriteLine($"Original: {originalPerson.Name}, {originalPerson.Age} - Copied: {copiedPerson.Name}, {copiedPerson.Age}");

        // 6. Init xüsusiyyəti nümunəsi (Can Only Be Assigned During Initialization)
        Student student = new() { Name = "Kamran", Age = 22 };
        Console.WriteLine($"Tələbə: {student.Name}, Yaş: {student.Age}");

        // 7. Record tipi nümunəsi (Used for Immutability and Pattern Matching)
        var animal = new { Species = "Dog", Name = "Max" };  // Record ad kimi də istifadə olunur.
        Console.WriteLine($"Heyvan: {animal.Species}, Adı: {animal.Name}");

        // 8. Range operator listlərdə və massivlərdə aralıq istifadə
        int[] subRange = numbers[2..^1];  // İkinci elementdən sona qədər, amma son element daxil deyil: { 3, 4, 5 }
        Console.WriteLine($"SubRange: {string.Join(", ", subRange)}");
    }
}
