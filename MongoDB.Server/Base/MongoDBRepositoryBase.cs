using MongoDB.Driver;
using System;

namespace MongoDB.Repository.Base
{
    public abstract class MongoDBRepositoryBase
    {
        /// <summary>
        /// get collection of type <see cref="{T}"/> , default exist in in constans generic <see cref="MongoDBRepository"/>
        /// <para> IsExtendEntity : default false throw exxeption if not exist in types ,
        /// <para>when true will create collection in DB if notexist or extend this collection to repo </para> </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="IsExtendEntity"> default false throw exxeption if not exist in types ,
        /// <para>when true will create collection in DB if notexist or extend this collection to repo </para> </param> 
        /// <returns> collection of <see cref="IMongoCollection{T}"/> </returns>
        abstract protected IMongoCollection<T> Context<T>(bool IsExtendEntity = false);
        protected Exception GetException(Type T)=> new Exception($"type of {T} is not definition like generic context." +
                    $" try to add to MongoDBRepository or active IsExtendEntity");
    }
}
