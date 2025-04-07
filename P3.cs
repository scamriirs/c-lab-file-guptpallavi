using System;
class ControlStatements
{static void Main()
{int number = 10;
// If-Else statement
if (number % 2 == 0)
Console.WriteLine("Even Number");
else
Console.WriteLine("Odd Number");
// For Loopfor (int i = 1; i <= 5; i++)
Console.WriteLine("For Loop Iteration: " + i);
// While Loopint count = 0;
while (count < 3)
{Console.WriteLine("While Loop Iteration: " + count);
count++;}
// Switch Caseint day = 3;switch (day)
{
case 1:
Console.WriteLine("Monday");
break;
case 2:
Console.WriteLine("Tuesday");
break;
case 3:
Console.WriteLine("Wednesday");
break;
default:
Console.WriteLine("Invalid Day");
break;
}
}
}