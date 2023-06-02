using FakeShop.Core.Entities;
using FakeShop.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FakeShop.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemRepository itemRepository;

        public ItemsController(ItemRepository _itemRepository)
        {
            this.itemRepository = _itemRepository;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return itemRepository.GetItems();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Item Get(Guid id)
        {
            return itemRepository.GetItemWithId(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void Post([FromBody] Item value)
        {
            itemRepository.CreateItem(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Item value)
        {
            itemRepository.UpdateItem(value, id);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            itemRepository.DeleteItem(id);
        }
    }
}
