Console.WriteLine("Input your first number");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number");
int secondNum = Convert.ToInt32(Console.ReadLine());
 if (firstNum > secondNum) 
 Console.WriteLine(+firstNum+ "  is the biggest number and the " +secondNum+ " is the smallest");
  else if (firstNum == secondNum) Console.WriteLine("Your numbers are equal");
 else  Console.WriteLine(+secondNum+ " is the biggest number and the " +firstNum+ " is the smallest");