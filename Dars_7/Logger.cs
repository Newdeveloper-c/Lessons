
namespace Dars_7;

internal class Logger
{
    private static Logger instance;
        
    private Logger() { }
    public static Logger Instance
    { 
        get
        { 
            return instance ??= new Logger();
        } 
    }
}

