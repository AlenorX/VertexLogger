public abstract class BaseLogger
{
    protected string time;
    protected string pathFile;

    public DataLogger(string pathFile, string nowDate)
    {
        this.pathFile = pathFile;
        this.time = nowDate;
    }
}

