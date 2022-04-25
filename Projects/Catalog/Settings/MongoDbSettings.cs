namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string ConnectString { 
            get
            {
                return $"mongodb://{Host}:{Port}";
            }
        }   
    }
}