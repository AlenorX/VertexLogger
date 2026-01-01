namespace Vertex
{
    public class VertexLogger
    {

        private DateTime dateTime = DateTime.Now;
        private string[] LEVEL = { "DEBUG", "WARN", "ERROR" };

        private string TimeNow()
        {
            string nowDay = $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}";
            return nowDay;
        }

        private void WriteText(string text, string pathFile)
        {
            File.AppendAllText(pathFile, text + "\n");
        }
        public void Debug(string text, string pathFile)
        {

            string fullText = $"[{LEVEL[0]}] - {text}  | {TimeNow()}";
            WriteText(fullText, pathFile);
        }

        public void Warn(string text, string pathFile)
        {

            string fullText = $"[{LEVEL[1]}] - {text}  | {TimeNow()}";
            WriteText(fullText, pathFile);
        }

        public void Error(string text, string pathFile)
        {
            string fullText = $"[{LEVEL[2]}] - {text}  | {TimeNow()}";
            WriteText(fullText, pathFile);
        }
    }
}