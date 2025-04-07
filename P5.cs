using System;
class OperatorsExample
{static void Main()
{int a = 10, b = 5;
// Arithmetic Operators
Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Subtraction: " + (a - b));
Console.WriteLine("Multiplication: " + (a * b));
Console.WriteLine("Division: " + (a / b));
Console.WriteLine("Modulus: " + (a % b));
// Unary OperatorsConsole.WriteLine("Increment: " + (++a));
Console.WriteLine("Decrement: " + (--b));
// Logical Operatorsbool x = true, y = false;
Console.WriteLine("AND Operator: " + (x && y));
Console.WriteLine("OR Operator: " + (x || y));
Console.WriteLine("NOT Operator: " + (!x));
// Bitwise Operatorsint bitA = 5, bitB = 3;
 // 5 = 101, 3 = 011
Console.WriteLine("Bitwise AND: " + (bitA & bitB));
Console.WriteLine("Bitwise OR: " + (bitA | bitB));
Console.WriteLine("Bitwise XOR: " + (bitA ^ bitB));
// Assignment Operatorsint num = 10;num += 5;
Console.WriteLine("Assignment += : " + num);
// Conditional (Ternary) Operator
int min = (a < b) ? a : b;
Console.WriteLine("Minimum Value: " + min);
}
}