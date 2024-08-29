//  5.Artırma və Azaltma Operatorları (Increment and Decrement Operators)
//  ++ : Artırma(Increment)
//  -- : Azaltma(Decrement)



// ++ : Artırma (Increment)
int a = 5;

// Pre-artırma: Dəyişəni artırmadan əvvəl qiyməti əldə edirik
Console.WriteLine("Pre-artırma (öncə artırma): " + (++a));  // a əvvəlcə artırılır, sonra 6 çıxarılır

// Artırma (Post-increment): Dəyişəni əvvəlcə istifadə edirik, sonra artırırıq
int b = 5;
Console.WriteLine("Post-artırma (sonra artırma): " + (b++));  // əvvəlcə 5 çıxarılır, sonra b 6 olur
Console.WriteLine("Post-artırmadan sonra: " + b);  // Çıxış: 6

// -- : Azaltma (Decrement)
int c = 10;

// Pre-azaltma: Dəyişəni azaltmadan əvvəl qiyməti əldə edirik
Console.WriteLine("Pre-azaltma (öncə azaltma): " + (--c));  // c əvvəlcə azalır, sonra 9 çıxarılır

// Azaltma (Post-decrement): Dəyişəni əvvəlcə istifadə edirik, sonra azaldırıq
int d = 10;
Console.WriteLine("Post-azaltma (sonra azaltma): " + (d--));  // əvvəlcə 10 çıxarılır, sonra d 9 olur
Console.WriteLine("Post-azaltmadan sonra: " + d);  // Çıxış: 9