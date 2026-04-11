public abstract class BaseLogger
{
    protected string text;
    protected string time;
    protected string pathFile;

    public DataLogger(string pathFile, string time)
    {
        this.pathFile = pathFile;
        this.time = time;
    }
}

