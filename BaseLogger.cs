namespace VertexLogger
{
    public abstract class BaseLogger
    {
        private string date;
        private string path;
        public string dateNow => date;
        public string pathLog => path;
        public DataLogger(string path, string date)
        {
            this.path = path;
            this.date = date;
        }
    }
}


