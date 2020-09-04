# MongoDB.Repository
easy  injection MonggDB.Driver  with Repository Pattern
## How to use

**appsettings.json**
<br/>
```JSON

  "MongoDBSetting": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "SimpleDB",
     // unnecessary CollectionsNames
    "CollectionsNames": [ "SimpleModel", "Blogs" ]
     //Plural and singular name of Entities .. each singular --> Plural  , Plural --> Plural
  },
```


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
using MongoDB.Repository;
```C#
 public class SimpleModel :BaseEntity
    {
        //..
    }
```

**Repository**
<br/>
```C#
using MongoDB.Repository;
 public class SimpleRepository : MongoDBRepository<SimpleModel>
 {
  public SimpleRepository(MongoDBService context) : base(context) { }
  
  //..
 
```

<br/>

### Extension 
can use more context of collection like-->
```C#
MongoDBRepository<T1, T2,....,T5>  Contex1....Contex15
```
<br/>

no need to **using MongoDB.Driver** if using **Context.AsQueryable()** to linq 

