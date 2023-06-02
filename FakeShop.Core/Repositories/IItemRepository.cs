using FakeShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeShop.Core.Repositories
{
    public interface IItemRepository
    {
        Item? GetItemWithId(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item, Guid Id);
        void DeleteItem(Guid id);
    }
}
