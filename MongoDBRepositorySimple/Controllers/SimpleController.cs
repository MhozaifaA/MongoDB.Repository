using Microsoft.AspNetCore.Mvc;
using MongoDBRepositorySimple.Model;
using MongoDBRepositorySimple.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDBRepositorySimple.Controllers
{
    public class SimpleController : Controller
    {
        private readonly ISimpleRepository _SimpleRepository;

        public SimpleController(ISimpleRepository SimpleRepository)
        {
            _SimpleRepository = SimpleRepository;
        }

        public async Task<ActionResult<object>> Get() =>
          await _SimpleRepository.GetSimplesAsync();
    }
}
