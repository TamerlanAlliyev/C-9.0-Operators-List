//  7.Şərtli Operator(Conditional Operator)
//  ?: : Şərti operator (Ternary operator)



// Nümunə dəyişənlər
int a = 10;
int b = 20;

// Şərtli operator istifadəsi
string result = (a > b) ? "a böyüktür b-dən" : "a kiçikdir və ya b ilə bərabərdir";

// Şərti operator necə işləyir:
// Şərt: a > b (10 > 20) => Yanlış (False)
// Yanlış nəticə: "a kiçikdir və ya b ilə bərabərdir" 
// Çünki şərt doğru deyil
Console.WriteLine(result);  // Çıxış: "a kiçikdir və ya b ilə bərabərdir"





// İkinci nümunə
int x = 30;
int y = 25;

// Şərtli operator istifadəsi
string comparisonResult = (x >= y) ? "x böyüktür və ya bərabərdir y-ə" : "x kiçikdir y-dən";

// Şərti operator necə işləyir:
// Şərt: x >= y (30 >= 25) => Doğru (True)
// Doğru nəticə: "x böyüktür və ya bərabərdir y-ə"
// Çünki şərt doğru
Console.WriteLine(comparisonResult);  // Çıxış: "x böyüktür və ya bərabərdir y-ə"