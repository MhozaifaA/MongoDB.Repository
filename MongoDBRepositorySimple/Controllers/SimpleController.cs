﻿using Microsoft.AspNetCore.Mvc;
using MongoDBRepositorySimple.Model;
using MongoDBRepositorySimple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<ActionResult<List<SimpleModel>>> Get() =>
          await _SimpleRepository.GetSimplesAsync();
    }
}
