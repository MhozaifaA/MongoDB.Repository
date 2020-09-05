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

        public async Task<object> GetSimplesAsync()
        {
            //will throw eception until pass true or   MongoDBRepository<SimpleModel,Foo> , Foo should inherent BaeEntity
            //var data = await Context<Foo>(true).AsQueryable().ToListAsync();

            // create and use fine  , out of  MongoDBRepository<SimpleModel>
            var data = await Context<Foo>(true).AsQueryable().ToListAsync();

            await Seed();

            // two way to use
            // await Context<SimpleModel>().Find(s => true).ToListAsync();
            return await Context1.Find(s => true).ToListAsync();
        }

        // add 10-DATA every reqest 
        private async Task Seed()
        {
            List<SimpleModel> list = new List<SimpleModel>();
            for (int i = 0; i < 10; i++)
                list.Add(new SimpleModel() { Simple = i.ToString()+"$"+Guid.NewGuid() });
            await Context1.InsertManyAsync(list);
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
