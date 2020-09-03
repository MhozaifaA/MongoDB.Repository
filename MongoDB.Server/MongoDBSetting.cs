
namespace MongoDB.Server
{
    /// <summary>
    /// Configuration appsettings ,
    /// <para> collection name get Models to Plural Model </para>
    /// </summary>
    public class MongoDBSetting : IMongoDBSetting
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string[] CollectionsNames { get; set; }
    }

    /// <summary>
    /// default Configuration appsettings <see cref="MongoDBSetting"/>
    /// </summary>
    public interface IMongoDBSetting
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string[] CollectionsNames { get; set; }

    }

}
