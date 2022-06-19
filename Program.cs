Console.WriteLine("Write three numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("num1 : " + num1);
Console.WriteLine("num2 : " + num2);
Console.WriteLine("num3 : " + num3);
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Greatest Number : " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Greatest number : " + num2);
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("Greatest Number : " + num3);
}
else
{
    Console.WriteLine("All three numbers are equal");
}