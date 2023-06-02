using FakeShop.Core.Entities;
using FakeShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeShop.Infra.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public void CreateItem(Item item)
        {
            using (FakeShopDbContext _dbContext = new FakeShopDbContext())
            {
                _dbContext.Items.Add(item);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteItem(Guid id)
        {
            using (FakeShopDbContext _dbContext = new FakeShopDbContext())
            {
                Item? item = _dbContext.Items.FirstOrDefault(x => x.Id == id);
                if (item != null)
                {
                    _dbContext.Items.Remove(item);
                    _dbContext.SaveChanges();
                }
            }
        }

        public IEnumerable<Item> GetItems()
        {
            using (FakeShopDbContext _dbContext = new FakeShopDbContext())
            {
                return _dbContext.Items.ToList();
            }
        }

        public Item? GetItemWithId(Guid id)
        {
            using (FakeShopDbContext _dbContext = new FakeShopDbContext())
            {
                return _dbContext.Items.FirstOrDefault(x=>x.Id == id);
            }
        }

        public void UpdateItem(Item input, Guid Id)
        {
            using (FakeShopDbContext _dbContext = new FakeShopDbContext())
            {
                Item? item = _dbContext.Items.FirstOrDefault(x => x.Id == Id);
                if (item != null)
                {
                    item.Price = input.Price;
                    item.Description = input.Description;
                    item.Name = input.Name;
                    _dbContext.Update(item);
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
