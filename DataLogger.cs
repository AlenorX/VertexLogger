public class DataLogger
{
    protected string[] level = ["DEBUG", "WARN", "ERROR"];
    protected string text;
    protected string time;
    protected string pathFile;

    public DataLogger(string pathFile, string time)
    {
        this.pathFile = pathFile;
        this.time = time;
    }

}

