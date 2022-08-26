using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Microsoft.AspNetCore.Mvc;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetItem")]
        public List<OutputItem> Get()
        {
            GetItem getItem = new GetItem(new ItemRepositoryDatabase(new AppDbContext()));
            return getItem.execute();
        }
    }
}