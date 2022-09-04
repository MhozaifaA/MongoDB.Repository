using MongoDB.Driver;
using PluralizeService.Core;
using System.Collections.Generic;

namespace MongoDB.Repository
{
    /// <summary>
    /// context with mongoDB lifetime 
    /// <para> handel <see cref="IMongoDBSetting"/>  ConnectionString , DatabaseName , CollectionsNames </para>
    /// </summary>
    public class MongoDBService
    {
        public IMongoDatabase MongoService;
        private List<string>  CollectionNames = new List<string>(); //singleton
        public MongoDBService(IMongoDBSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            MongoService = client.GetDatabase(settings.DatabaseName);
            CreateCollection(settings?.CollectionsNames);
        }

        public void CreateCollection(params string[] names)
        {
            if (names is null) return;
            foreach (var name in names)
            {
                if (CollectionNames.Contains(name))
                    continue;

                MongoService.CreateCollectionAsync(
                    PluralizationProvider.Pluralize(name));
                CollectionNames.Add(name);
            }
        }
    }
}
