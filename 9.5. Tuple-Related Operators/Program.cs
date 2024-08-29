//  13.Tuple ilə əlaqəli Operatorlar (Tuple-Related Operators)
//  = : Tuple dəyəri təyini (Tuple value assignment)
//  == : Tuple müqayisəsi(Tuple comparison)
//  != : Tuple müqayisəsi(Tuple comparison)

// `=` operatoru ilə Tuple dəyəri təyini
(int, string, bool) person1 = (25, "Tamerlan", true);  // Burada bir Tuple yaratdıq: (25, "Tamerlan", true)
var person2 = (30, "Elçin", false);  // `var` açar sözü ilə Tuple yaradılır: (30, "Elçin", false)

Console.WriteLine($"Person 1: Age = {person1.Item1}, Name = {person1.Item2}, IsActive = {person1.Item3}");
Console.WriteLine($"Person 2: Age = {person2.Item1}, Name = {person2.Item2}, IsActive = {person2.Item3}");

// `==` operatoru ilə Tuple müqayisəsi
var tuple1 = (5, 10);
var tuple2 = (5, 10);
var tuple3 = (10, 20);

if (tuple1 == tuple2)
{
    Console.WriteLine("tuple1 və tuple2 eynidir.");  // Çıxış: tuple1 və tuple2 eynidir.
}

// `!=` operatoru ilə Tuple müqayisəsi
if (tuple1 != tuple3)
{
    Console.WriteLine("tuple1 və tuple3 fərqlidir.");  // Çıxış: tuple1 və tuple3 fərqlidir.
}