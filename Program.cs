Console.WriteLine("wright a number");
long num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    double powerOfTwo = Math.Pow(2, i);
    Console.WriteLine("powerOfTwo : " + powerOfTwo);
}