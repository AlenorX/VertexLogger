namespace Vertex
{
    public class VertexLogger
    {
        public class Data
        {
            public string[] LEVEL = { "[DEBUG]", "[WARN]", "[ERROR]" };
            public string pathLog;
        }
        DateTime dateTime = DateTime.Now;
        Data dataLogger = new Data();

        public string BasicSetting(string pathFile)
        {
            using (FileStream file = new FileStream(pathFile, FileMode.Create))
            {
                file.Close();
            }
            return pathFile;
        }
        public void WriteText(string text, string pathFile)
        {
            File.AppendAllText(pathFile, text + "\n");
        }
        public void Debug(string text, string pathFile)
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            string fullText = $"{text} {dataLogger.LEVEL[0]} | {nowDay}";
            WriteText(fullText, pathFile);
        }

        public void Warn(string text, string pathFile)
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            string fullText = $"{text} {dataLogger.LEVEL[0]} | {nowDay}";
            WriteText(fullText, pathFile);
        }

        public void Error(string text, string pathFile)
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            string fullText = $"{text} {dataLogger.LEVEL[0]} | {nowDay}";
            WriteText(fullText, pathFile);
        }
    }
}