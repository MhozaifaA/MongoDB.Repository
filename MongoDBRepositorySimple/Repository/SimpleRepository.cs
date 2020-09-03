using MongoDB.Driver;
using MongoDB.Repository;
using MongoDB.Server;
using MongoDBRepositorySimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBRepositorySimple.Repository
{
    public class SimpleRepository : MongoDBRepository<SimpleModel>, ISimpleRepository
    {
        public SimpleRepository(MongoDBService context) : base(context) { }

        public async Task<List<SimpleModel>> GetSimplesAsync()
        {
          return  await Context.Find(s => true).ToListAsync();
        }
    }
}
