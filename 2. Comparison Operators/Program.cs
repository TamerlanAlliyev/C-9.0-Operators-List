//  2.Müqayisə Operatorları(Comparison Operators)
//  == : Bərabərdir(Equal to)
//  != : Bərabər deyil(Not equal to)
//  > : Böyüktür(Greater than)
//  < : Kiçikdir(Less than)
//  >= : Böyüktür və ya bərabərdir (Greater than or equal to)
//  <= : Kiçikdir və ya bərabərdir (Less than or equal to)



// == : Bərabərdir (Equal to)
int a = 10;
int b = 20;
bool isEqual = (a == b);  // Bərabərlik müqayisəsi
Console.WriteLine("Bərabərdir: " + isEqual);  // Çıxış: False

// != : Bərabər deyil (Not equal to)
bool isNotEqual = (a != b);  // Bərabərlik deyil müqayisəsi
Console.WriteLine("Bərabər deyil: " + isNotEqual);  // Çıxış: True

// > : Böyüktür (Greater than)
bool isGreater = (a > b);  // Böyüklük müqayisəsi
Console.WriteLine("Böyüktür: " + isGreater);  // Çıxış: False

// < : Kiçikdir (Less than)
bool isLess = (a < b);  // Kiçiklik müqayisəsi
Console.WriteLine("Kiçikdir: " + isLess);  // Çıxış: True

// >= : Böyüktür və ya bərabərdir (Greater than or equal to)
bool isGreaterOrEqual = (a >= b);  // Böyüklük və ya bərabərlik müqayisəsi
Console.WriteLine("Böyüktür və ya bərabərdir: " + isGreaterOrEqual);  // Çıxış: False

// <= : Kiçikdir və ya bərabərdir (Less than or equal to)
bool isLessOrEqual = (a <= b);  // Kiçiklik və ya bərabərlik müqayisəsi
Console.WriteLine("Kiçikdir və ya bərabərdir: " + isLessOrEqual);  // Çıxış: True