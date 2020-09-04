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
          await Seed();
          return  await Context.Find(s => true).ToListAsync();
        }

        // add 10-DATA every reqest 
        private async Task Seed()
        {
            List<SimpleModel> list = new List<SimpleModel>();
            for (int i = 0; i < 10; i++)
                list.Add(new SimpleModel() { Simple = i.ToString()+"$"+Guid.NewGuid() });
            await Context.InsertManyAsync(list);
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
