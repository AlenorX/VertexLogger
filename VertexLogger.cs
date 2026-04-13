namespace VertexLogger
{
    public class Logger : DataLogger, ILogger
    {
        private string timeNow = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} - {DateTime.Now.Hour}:{DateTime.Now.Minute}";
        public Logger(string path): base(path, timeNow) {}
        public void INFO(string text)
        {
            string result = $"{base.dateNow} | [INFO] - {text}\n";
            File.AppendAllText(base.pathLog, result);
        }
        public void WARN(string text)
        {
            string result = $"{base.dateNow} | [WARN] - {text}\n";
            File.AppendAllText(base.pathLog, result);
        }
        public void ERROR(string text)
        {
            string result = $"{base.dateNow} | [ERROR] - {text}\n";
            File.AppendAllText(base.pathLog, result);
        }
    }
    
}

