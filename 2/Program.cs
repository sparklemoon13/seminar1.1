﻿Console.WriteLine("Input your first number");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your third number");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int max = firstNum;
 if (secondNum > max) max = secondNum;
  if (thirdNum > max) max = thirdNum;
   if (firstNum > max) max = firstNum;
Console.WriteLine(+max+" is the biggest number");
