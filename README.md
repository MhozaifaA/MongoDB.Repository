# MongoDB.Repository
easy  injection MonggDB.Driver  with Repository Pattern
## How to use

**appsettings.json**
<br/>
```JSON

  "MongoDBSetting": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "SimpleDB",
    "CollectionsNames": [ "SimpleModel", "Blogs" ]
  },
```
  // unnecessary CollectionsNames
 //Plural and singular name of Entities .. each singular --> Plural  , Plural --> Plural

**Startup.cs**
<br/>

```C#
using MongoDB.Repository;
using MongoDB.Repository.Configure;
using Microsoft.Extensions.Configuration;


public void ConfigureServices(IServiceCollection services)
{
   //...

    services.AddMongoDBRepository(
        Configuration.GetSection(nameof(MongoDBSetting)));
        
        
  //inject singleton Repositories  
    services.AddSingleton<ISimpleRepository, SimpleRepository>();
    //services.AddSingleton<//other>()....
    
  //..
}
```
**Model**
<br/>
```C#
using MongoDB.Repository;
 public class SimpleModel :BaseEntity
  {
      //..
  }
```

**Repository**
<br/>
```C#
using MongoDB.Repository;
 public class SimpleRepository : MongoDBRepository<SimpleModel> ,ISimpleRepository
 {
  public SimpleRepository(MongoDBService context) : base(context) { }
  
  //..
 
```

**How use in repo**
<br/>
```C#
// same type passed to MongoDBRepository<> 
Context1..  or Context<yourEntity>()..
``` 

***otherwise use ``Context<EntityOutOFgeneric>(true)`` to create if not exist or used out of repo and flexible handle in runtime***


<br/>

### Extension 
can use more context of collection like-->
```C#
MongoDBRepository<T1, T2,....,T5>  Contex1....Contex15
```
<br/>

no need to **using MongoDB.Driver** if using **Context.AsQueryable()** to linq 

### Simple
check simple 
https://github.com/MhozaifaA/MongoDB.Repository/blob/master/MongoDBRepositorySimple/Repository/SimpleRepository.cs
<br/>
<h1>     😊 enjoy ..<h1>
