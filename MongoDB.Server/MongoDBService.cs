using MongoDB.Driver;

namespace MongoDB.Repository
{
    /// <summary>
    /// context with mongoDB lifetime 
    /// <para> handel <see cref="IMongoDBSetting"/>  ConnectionString , DatabaseName , CollectionsNames </para>
    /// </summary>
    public class MongoDBService
    {
        public IMongoDatabase MongoService;
        public MongoDBService(IMongoDBSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            MongoService = client.GetDatabase(settings.DatabaseName);
            CreateCollection(settings?.CollectionsNames);
        }

        private void CreateCollection(string[] names)
        {
            if (names is null) return;
            foreach (var name in names)
                MongoService.CreateCollectionAsync(name);
        }
    }
}
