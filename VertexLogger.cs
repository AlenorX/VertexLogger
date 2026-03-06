public class VertexLogger : DataLogger
{

    private static string timeNow = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} - {DateTime.Now.Hour}:{DateTime.Now.Minute}";

    public VertexLogger(string path): base(path, timeNow)
    {

    }
    

    public void Debug(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[0]}] - {base.text}\n";
        File.AppendAllText(base.pathFile, result);
    }
    public void Warn(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[1]}] - {base.text}\n";
        File.AppendAllText(base.pathFile, result);
    }
    public void Error(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[2]}] - {base.text}\n";
        File.AppendAllText(base.pathFile, result);
    }
}

