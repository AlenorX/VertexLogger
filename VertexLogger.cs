public class VertexLogger : DataLogger
{

    private static string timeNow = $"{DateTime.Now.Date} - {DateTime.Now.Hour}:{DateTime.Now.Minute}";

    public VertexLogger(string path)
    {
        base.pathFile = path;
        base.time = timeNow;
    }

    public void Debug(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[0]}] - {base.text}";
        File.AppendAllText(base.pathFile, result);
    }
    public void Warn(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[1]}] - {base.text}";
        File.AppendAllText(base.pathFile, result);
    }
    public void Error(string text)
    {
        base.text = text;
        string result = $"{base.time} | [{base.level[2]}] - {base.text}";
        File.AppendAllText(base.pathFile, result);
    }
}

