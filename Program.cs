Console.WriteLine("Welcome to flip coin");
Console.WriteLine("Write Number of time wants to flip coin ");
int head = 0;
int numOfTimeCoinIstail = 0;
int numOfTimeCoinIsHead = 0;
int num = Convert.ToInt32(Console.ReadLine());
int[] coin = new int[num];
for (int i = 0; i < coin.Length; i++)
{
    Random rnd = new Random();
    int flipCoin = rnd.Next(2);
    Console.WriteLine("flipCoin : " + flipCoin);

    if (flipCoin <= head)
    {
        Console.WriteLine("coin is head");
        numOfTimeCoinIsHead = numOfTimeCoinIsHead + 1;
        Console.WriteLine("numOfTimeCoinIsHead : " + numOfTimeCoinIsHead);
    }
    else
    {
        Console.WriteLine("coin is tail");
        numOfTimeCoinIstail = numOfTimeCoinIstail + 1;
        Console.WriteLine("numOfTimeCoinIstail : " + numOfTimeCoinIstail);
    }

}
Console.WriteLine(numOfTimeCoinIsHead);
Console.WriteLine(numOfTimeCoinIstail);
int percentageOfHead = (numOfTimeCoinIsHead * 100 / num);
Console.WriteLine("percentageOfHead : " + percentageOfHead);
int percentageOfTail = (numOfTimeCoinIstail * 100 / num);
Console.WriteLine("percentageOfTail : " + percentageOfTail);
Console.Read();
