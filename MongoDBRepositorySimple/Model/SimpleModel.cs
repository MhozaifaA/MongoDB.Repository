using MongoDB.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBRepositorySimple.Model
{
    public class SimpleModel :BaseEntity
    {
        public string Simple { get; set; }
    }
}
