using MongoDB.Driver;
using PluralizeService.Core;

namespace MongoDB.Repository
{

    /// <summary>
    /// Base DI Generic <see cref="T"/>  get collection with Plural entities  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MongoDBRepository<T> where T : BaseEntity, new()
    {
        protected readonly IMongoCollection<T> Context;

        protected MongoDBRepository(MongoDBService context)
        {
           Context = context.MongoService.GetCollection<T>(PluralizationProvider.Pluralize(typeof(T).Name));
        }
    }


    /// <summary>
    /// Base DI Generics <see cref="T1"/> , <see cref="T2"/>   get collection with Plural entities
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public class MongoDBRepository<T1, T2> where T1 : BaseEntity, new() where T2 : BaseEntity, new()
    {
        protected readonly IMongoCollection<T1> Context1;
        protected readonly IMongoCollection<T2> Context2;
        protected MongoDBRepository(MongoDBService context)
        {
            Context1 = context.MongoService.GetCollection<T1>(PluralizationProvider.Pluralize(typeof(T1).Name));
            Context2 = context.MongoService.GetCollection<T2>(PluralizationProvider.Pluralize(typeof(T2).Name));
        }
    }



    /// <summary>
    /// Base DI Generics <see cref="T1"/> , <see cref="T2"/> , <see cref="T3"/>   get collection with Plural entities  
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public class MongoDBRepository<T1, T2, T3> where T1 : BaseEntity, new() where T2 : BaseEntity, new() where T3 : BaseEntity, new()
    {
        protected readonly IMongoCollection<T1> Context1;
        protected readonly IMongoCollection<T2> Context2;
        protected readonly IMongoCollection<T3> Context3;
        protected MongoDBRepository(MongoDBService context)
        {
            Context1 = context.MongoService.GetCollection<T1>(PluralizationProvider.Pluralize(typeof(T1).Name));
            Context2 = context.MongoService.GetCollection<T2>(PluralizationProvider.Pluralize(typeof(T2).Name));
            Context3 = context.MongoService.GetCollection<T3>(PluralizationProvider.Pluralize(typeof(T3).Name));
        }
    }




    /// <summary>
    /// Base DI Generics <see cref="T1"/> , <see cref="T2"/> , <see cref="T3"/>  , <see cref="T4"/>   get collection with Plural entities  
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public class MongoDBRepository<T1, T2, T3, T4> where T1 : BaseEntity, new() where T2 : BaseEntity, new() where T3 : BaseEntity, new() where T4 : BaseEntity, new()
    {
        protected readonly IMongoCollection<T1> Context1;
        protected readonly IMongoCollection<T2> Context2;
        protected readonly IMongoCollection<T3> Context3;
        protected readonly IMongoCollection<T4> Context4;
        protected MongoDBRepository(MongoDBService context)
        {
            Context1 = context.MongoService.GetCollection<T1>(PluralizationProvider.Pluralize(typeof(T1).Name));
            Context2 = context.MongoService.GetCollection<T2>(PluralizationProvider.Pluralize(typeof(T2).Name));
            Context3 = context.MongoService.GetCollection<T3>(PluralizationProvider.Pluralize(typeof(T3).Name));
            Context4 = context.MongoService.GetCollection<T4>(PluralizationProvider.Pluralize(typeof(T4).Name));
        }
    }



    /// <summary>
    /// Base DI Generics <see cref="T1"/> , <see cref="T2"/> , <see cref="T3"/>  , <see cref="T4"/>  <see cref="T5"/>   get collection with Plural entities  
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public class MongoDBRepository<T1, T2, T3, T4,T5> where T1 : BaseEntity, new() where T2 : BaseEntity, new() where T3 : BaseEntity, new() where T4 : BaseEntity, new() where T5 : BaseEntity, new()
    {
        protected readonly IMongoCollection<T1> Context1;
        protected readonly IMongoCollection<T2> Context2;
        protected readonly IMongoCollection<T3> Context3;
        protected readonly IMongoCollection<T4> Context4;
        protected readonly IMongoCollection<T5> Context5;
        protected MongoDBRepository(MongoDBService context)
        {
            Context1 = context.MongoService.GetCollection<T1>(PluralizationProvider.Pluralize(typeof(T1).Name));
            Context2 = context.MongoService.GetCollection<T2>(PluralizationProvider.Pluralize(typeof(T2).Name));
            Context3 = context.MongoService.GetCollection<T3>(PluralizationProvider.Pluralize(typeof(T3).Name));
            Context4 = context.MongoService.GetCollection<T4>(PluralizationProvider.Pluralize(typeof(T4).Name));
            Context5 = context.MongoService.GetCollection<T5>(PluralizationProvider.Pluralize(typeof(T5).Name));
        }
    }

}
