//  8.Tip Dönüşüm Operatorları(Type Conversion Operators)
//  (type) : Açıq dönüşüm(Explicit conversion)
//  is : Tip yoxlama(Type checking)
//  as : Tip dönüşümü(Type conversion)




// (type) : Açıq dönüşüm (Explicit conversion)
double doubleValue = 9.78;
int intValue = (int)doubleValue;  // Açıq dönüşüm, double tipini int tipinə çevirir
                                  // doubleValue: 9.78
                                  // intValue: 9 (decimal hissəsi itir)
Console.WriteLine("Açıq dönüşüm: " + intValue);  // Çıxış: 9




// is : Tip yoxlama (Type checking)
object obj = "Bu bir stringdir";
bool isString = obj is string;  // `obj` dəyişəni `string` tipindədirmi?
                                // `obj` tipi `string` olduğuna görə nəticə: true
Console.WriteLine("Tip yoxlama (is): " + isString);  // Çıxış: True




// as : Tip dönüşümü (Type conversion)
object obj2 = "Bu da bir stringdir";
string str = obj2 as string;  // `obj2` dəyişənini `string` tipinə çevirmək
                              // `obj2` tipi `string` olduğuna görə dönüşüm uğurludur və nəticə: "Bu da bir stringdir"
Console.WriteLine("Tip dönüşümü (as): " + str);  // Çıxış: Bu da bir stringdir




// as operatorunun uğursuz istifadə nümunəsi
object obj3 = 123;
string str2 = obj3 as string;  // `obj3` tipi `string` olmadığı üçün dönüşüm uğursuz olur
                               // `str2` dəyişəni `null` olacaq
Console.WriteLine("Uğursuz tip dönüşümü (as): " + (str2 ?? "null"));  // Çıxış: null