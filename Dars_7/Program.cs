
using Dars_7;
using System.Numerics;

var logs = Logger.Instance;

Bank bank = new Bank();
bank.SetBalance = 5;
Console.WriteLine(bank.SetBalance = 9);

var logs2 =  Logger.Instance;

int t;
int a = 7;
Console.WriteLine(t = 7);
double ff = 3.3;

int[] arr = { 2, 3, 4 };
BigInteger aa = 5;
Console.WriteLine($"{BigInteger.Max}");

try
{
    ///Console.WriteLine(arr[10]);
}
finally
{

}

string s1 = "C#", s2 = "C";
Console.WriteLine(object.ReferenceEquals(s1, s2));

Bank bank2 = new Bank();
Console.WriteLine(object.ReferenceEquals(bank, bank2));