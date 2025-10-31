namespace Vertex
{
    public class VertexLogger
    {
        public class Data
        {
            public string[] LEVEL = { "[DEBUG]", "[WARN]", "[ERROR]" };
        }
        DateTime dateTime = DateTime.Now;
        Data dataLogger = new Data();

        public void WriteText(string text, string pathFile)
        {
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
            }
            else
            {
                File.AppendAllText(pathFile, text + "\n");
            }

        }
        public string Debug(string text, string pathFile)
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            string fullText = $"{dataLogger.LEVEL[0]} - {nowDay} | {text}";
            WriteText(fullText, pathFile);
            return fullText;
        }

        public string Warn(string text, string pathFile)
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            string fullText = $"{dataLogger.LEVEL[1]} - {nowDay} | {text}";
            WriteText(fullText, pathFile);
            return fullText;
        }

        public string Error(string text, string pathFile)
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            string fullText = $"{dataLogger.LEVEL[2]} - {nowDay} | {text}";
            WriteText(fullText, pathFile);
            return fullText;
        }
    }
}