//  15.Digər Operatorlar(Other Operators)
//  sizeof : Bir məlumat növünün yaddaş ölçüsünü qaytarır (Returns the memory size of a data type)
//  typeof : Tip məlumatını qaytarır (Returns the type information)
//  checked : Rəqəmsal dəyərlərdə aşım yoxlaması (Overflow checking in numeric values)
//  unchecked : Rəqəmsal dəyərlərdə aşım yoxlaması olmadan əməliyyatlar aparır (Performs operations without overflow checking in numeric values)
//  default : Default dəyəri qaytarır (Returns the default value)
//  nameof : Bir üzvün adını sətir kimi qaytarır (Returns the name of a member as a string)
//  . : Nöqtə operatoru(Dot operator)
//  [] : İndeks operatoru(Index operator)
//  () : Tip çevirmə operatoru (Type cast operator)



// 1. sizeof : Bir məlumat növünün yaddaş ölçüsünü qaytarır
int sizeOfInt = sizeof(int);  // `int` tipinin yaddaş ölçüsünü qaytarır: 4 bayt
Console.WriteLine($"int tipinin ölçüsü: {sizeOfInt} bayt");

// 2. typeof : Tip məlumatını qaytarır
Type typeOfString = typeof(string);  // `string` tipinin məlumatını qaytarır
Console.WriteLine($"string tipi: {typeOfString}");

// 3. checked : Rəqəmsal dəyərlərdə aşım yoxlaması
try
{
    int maxValue = int.MaxValue;
    int result = checked(maxValue + 1);  // Aşım baş verir
    Console.WriteLine($"Checked nəticə: {result}");
}
catch (OverflowException)
{
    Console.WriteLine("Aşım baş verdi!");
}

// 4. unchecked : Rəqəmsal dəyərlərdə aşım yoxlaması olmadan əməliyyatlar aparır
int uncheckedResult = unchecked(int.MaxValue + 1);  // Aşım yoxlanılmır
Console.WriteLine($"Unchecked nəticə: {uncheckedResult}");

// 5. default : Default dəyəri qaytarır
int defaultInt = default;  // `int` tipinin default dəyəri: 0
Console.WriteLine($"int default dəyəri: {defaultInt}");

string defaultString = default;  // `string` tipinin default dəyəri: null
Console.WriteLine($"string default dəyəri: {defaultString}");

// 6. nameof : Bir üzvün adını sətir kimi qaytarır
string variableName = nameof(defaultInt);  // "defaultInt" dəyişənin adını qaytarır
Console.WriteLine($"Dəyişənin adı: {variableName}");

// 7. . : Nöqtə operatoru (Dot operator)
string hello = "Salam";
int length = hello.Length;  // `.Length` metodu ilə `hello` sətirinin uzunluğunu alırıq
Console.WriteLine($"'Salam' sözünün uzunluğu: {length}");

// 8. [] : İndeks operatoru (Index operator)
char firstLetter = hello[0];  // İlk simvolu əldə edirik
Console.WriteLine($"'Salam' sözünün ilk hərfi: {firstLetter}");

// 9. () : Tip çevirmə operatoru (Type cast operator)
object numberObject = 42;  // `object` tipində bir dəyər təyin edirik
int number = (int)numberObject;  // `object` tipini `int` tipinə çeviririk
Console.WriteLine($"Tip çevirmə nəticəsi: {number}");