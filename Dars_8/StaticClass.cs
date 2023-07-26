namespace Dars_8;


public class StaticClass
{
    const int a = 4;
    const int son = a;
    const string s = "afsf";
    public static readonly int number ;
    public  const int aas = 4;
    public static int staticCount { get; private set; }
    public int nonStaticCount = 0;
    static StaticClass() { number = 200; }
}
