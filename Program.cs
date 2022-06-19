Console.WriteLine("Write the dividend number");
int dividendNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the divisor number");
int divisorNum = Convert.ToInt32(Console.ReadLine());

int quotient = dividendNum / divisorNum;
Console.WriteLine("quotient : " + quotient);
int remainder = dividendNum % divisorNum;
Console.WriteLine("remainder : " + remainder);
