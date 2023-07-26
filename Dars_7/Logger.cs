
namespace Dars_7;

internal class Logger
{
    //private static Logger instance;
        
    private Logger() { }
    public static Logger Instance { get; } = new ();


}

class Bank
{
    private decimal _balance;
    public decimal SetBalance
    {
        private get { return _balance; }
        set { _balance = value; }
    }
    
}

struct a
{
    int ac;
}
