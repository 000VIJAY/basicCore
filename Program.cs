Console.WriteLine("write year : should be of four digit");
int year = Convert.ToInt32(Console.ReadLine());
int forLeapYear = year % 4;
int forLeapCentury = year % 400;
if (forLeapYear == 0)
{
    Console.WriteLine("year is leap year");
}
else if (forLeapCentury == 0)
{
    Console.WriteLine("year is leap year");
}
else
{
    Console.WriteLine("year is not a leap year");
}