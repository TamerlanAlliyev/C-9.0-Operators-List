//  6.Bit Səviyyəsində Operatorlar(Bitwise Operators)
//  & : VƏ(AND)
//  | : VƏ YA(OR)
//  ^ : XOR
//  ~ : NOT
//  << : Sol bitlərə keçid (Shift left)
//  >> : Sağ bitlərə keçid (Shift right)




// & : VƏ (AND)
int a = 12;  // Binary: 1100
int b = 7;   // Binary: 0111
int andResult = a & b;  // Bitwise VƏ əməliyyatı
                        // Binary: 1100 (12)
                        // Binary: 0111 (7)
                        // ----------------
                        // Bitwise VƏ əməliyyatı:
                        // 1 & 0 = 0
                        // 1 & 1 = 1
                        // 0 & 1 = 0
                        // 0 & 1 = 0
                        // ----------------
                        // Result: 0100 (4)
Console.WriteLine("Bitwise VƏ: " + andResult);  // Çıxış: 4




// | : VƏ YA (OR)
int orResult = a | b;  // Bitwise VƏ YA əməliyyatı
                       // Binary: 1100 (12)
                       // Binary: 0111 (7)
                       // ----------------
                       // Bitwise VƏ YA əməliyyatı:
                       // 1 | 0 = 1
                       // 1 | 1 = 1
                       // 0 | 1 = 1
                       // 0 | 1 = 1
                       // ----------------
                       // Result: 1111 (15)
Console.WriteLine("Bitwise VƏ YA: " + orResult);  // Çıxış: 15




// ^ : XOR
int xorResult = a ^ b;  // Bitwise XOR əməliyyatı
                        // Binary: 1100 (12)
                        // Binary: 0111 (7)
                        // ----------------
                        // Bitwise XOR əməliyyatı:
                        // 1 ^ 0 = 1
                        // 1 ^ 1 = 0
                        // 0 ^ 1 = 1
                        // 0 ^ 1 = 1
                        // ----------------
                        // Result: 1011 (11)
Console.WriteLine("Bitwise XOR: " + xorResult);  // Çıxış: 11




// ~ : NOT
int notResult = ~a;  // Bitwise NOT əməliyyatı
                     // Binary: 1100 (12)
                     // Bitwise NOT əməliyyatı:
                     // ~1100 = 0011
                     // C#-da iki ədədli tamamlamadan dolayı nəticə: -13
                     // Əslində: 1111 1111 1111 1111 1111 1111 1111 0011 (-13)
Console.WriteLine("Bitwise NOT: " + notResult);  // Çıxış: -13




// << : Sol bitlərə keçid (Shift left)
int shiftLeftResult = a << 2;  // Bitwise sol keçid əməliyyatı (2 bit sola)
                               // Binary: 1100 (12)
                               // Sol 2 bitə keçid:
                               // 1100 << 2 = 110000
                               // Result: 48
Console.WriteLine("Sol bitlərə keçid: " + shiftLeftResult);  // Çıxış: 48




// >> : Sağ bitlərə keçid (Shift right)
int shiftRightResult = a >> 2;  // Bitwise sağ keçid əməliyyatı (2 bit sağa)
                                // Binary: 1100 (12)
                                // Sağ 2 bitə keçid:
                                // 1100 >> 2 = 0011
                                // Result: 3
Console.WriteLine("Sağ bitlərə keçid: " + shiftRightResult);  // Çıxış: 3