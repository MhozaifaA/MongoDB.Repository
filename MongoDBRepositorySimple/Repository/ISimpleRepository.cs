using MongoDBRepositorySimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBRepositorySimple.Repository
{
    public interface ISimpleRepository
    {
        Task<List<SimpleModel>> GetSimplesAsync();
    }
}
