
void Print(int[] arr)
{
    foreach(var item in arr)
        Console.WriteLine(item);
}

string isMusbat(int a)
{
    return (a >= 0) ? "Musbat" : "Manfiy";
}

string ans = isMusbat(-1);
Console.WriteLine(ans);

///////------------------ switch --------------
int age = 18;
switch(age)
{
    case 18: case 19: case 20:
        Console.WriteLine("Go University!");
        break;
    case 22: case 23: case 24:
        Console.WriteLine("Get Masters degree!");
        break;
    case 25: case 26: case 27:
    case 28: case 29: case 30:
        Console.WriteLine("Go to work with $100K for a year!");
        break;
    default: Console.WriteLine("No recommendations for this age");
        break;
}

int month = 9;
string season = month switch
{
    12 or 1 or 2 => "Winter",
    3 or 4 or 5 => "Spring",
    6 or 7 or 8 => "Summer",
    9 or 10 or 11 => "Autumn",
    _ => "Invalid month"
};
Console.WriteLine(season);

///----------------- array -------------------------

//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//for(int i = 0; i < n; i++)
//    arr[i] = int.Parse(Console.ReadLine());

//arr[^1] = 22; ;
//Console.WriteLine(arr[^1]);
//int[] arr2 = arr[..^1];
//foreach(int i in arr2)
//    Console.WriteLine(i);

int[] arr3 = { 1, 1, -3, 9 };//, 0, -90, 700, 40, 0, 0 };
Array.Sort(arr3);
Print(arr3);
Console.WriteLine();
Array.Reverse(arr3);
Print(arr3);

arr3.SetValue(3, 3);
Print(arr3);

//Array.Fill(arr3, 0);
//Print(arr3);

Console.WriteLine();
int[] arr4 = new int[5];
//Array.Copy(arr3, arr4, Math.Min(arr3.Length, arr4.Length));
//Print(arr4);

//arr3.CopyTo(arr4, 2);
//Print(arr4);

////------------------- matrix -------------------

int[,] matr = new int[3, 4]
{
    {1, 2, 3, 4},
    {2, 3, 4, 5},
    {3, 4, 5, 6}
};

int cnt = 0;
foreach (int i in matr)
{
    if(cnt % 4 == 0)
        Console.WriteLine();
    Console.Write(" " + i);
    cnt++;
}
Console.WriteLine();

var ss = Console.ReadLine()?.Split(' ', ',');
foreach(var i in ss)
    Console.WriteLine(i);

Console.WriteLine(ss);