using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi
{
    public class ItemRepositoryMemory : ItemRepository
    {
        private List<Item> items;

        public ItemRepositoryMemory(){
            this.items = new List<Item>();
        }

        public Item getItemById(int id)
        {
            //Item item = this.items.FirstOrDefault(x => x.getIdItem() == id);
            Item? item = this.items.Where(x => x.getIdItem() == id)
                            .DefaultIfEmpty(null)
                            .FirstOrDefault();
            return item??new Item();
        }

        public List<Item> getList()
        {
            return this.items;
        }

        public void save(Item item)
        {
            this.items.Add(item);
        }
    }
}