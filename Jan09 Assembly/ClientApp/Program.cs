// See https://aka.ms/new-console-template for more information
using Jan09_Assembly;

Console.WriteLine("Hello, World!");
Calculator C = new Calculator();
C.Num1 = 10;
C.Num2 = 20;
Double ans = C.Adding();
Console.WriteLine(" the result of adding 2 numbers " + ans);
