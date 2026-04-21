namespace FonlaBeni.Persistence.Options
{
    public class DbOptions
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        override public string ToString()
        {
            return $"Host={Host};Database={Database};Port={Port};Username={Username};Password={Password}";
        }
    }
}
