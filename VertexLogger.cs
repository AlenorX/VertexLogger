public class VertexLogger : DataLogger, ILogger
{
    private string timeNow = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} - {DateTime.Now.Hour}:{DateTime.Now.Minute}";
    public VertexLogger(string path): base(path, timeNow)
    {

    }
    public void INFO(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[0]}] - {base.text}\n";
        File.AppendAllText(base.pathFile, result);
    }
    public void WARN(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[1]}] - {base.text}\n";
        File.AppendAllText(base.pathFile, result);
    }
    public void ERROR(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[2]}] - {base.text}\n";
        File.AppendAllText(base.pathFile, result);
    }
}

