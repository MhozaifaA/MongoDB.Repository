using MongoDB.Driver;
using MongoDB.Repository;
using MongoDBRepositorySimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBRepositorySimple.Repository
{
    public class SimpleRepository : MongoDBRepository<SimpleModel>, ISimpleRepository ,IDisposable
    {
        public SimpleRepository(MongoDBService context) : base(context) { }

        public async Task<List<SimpleModel>> GetSimplesAsync()
        {
          return  await Context.Find(s => true).ToListAsync();
        }



        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                // singletone 
                //  Context.Dispose();
                // clear and destroy 
                // void clear() { }
                { }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
