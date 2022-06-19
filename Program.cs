Console.WriteLine("Write Number whose Harmonic value wants to know");
int num = Convert.ToInt32(Console.ReadLine());
double numOne = 1;
for (int i = 2; i <= num; i++)
{
    numOne = numOne + 1.0 / i;
}
Console.WriteLine("Harmonic value : " + numOne);

