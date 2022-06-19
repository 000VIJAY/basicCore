Console.WriteLine("Write two number");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("num1 : " + num1);
Console.WriteLine("num2 : " + num2);
int num3 = num1;
num1 = num2;
num2 = num3;
Console.WriteLine("after swapping num1 : " + num1);
Console.WriteLine("after swapping num2 : " + num2);
