using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi
{
    public class ItemRepositoryDatabase : ItemRepository
    {
        private AppDbContext appDbContext;

        public ItemRepositoryDatabase(AppDbContext appDbContext){
            this.appDbContext = new AppDbContext();
        }

        public Item getItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> getList()
        {
            List<Item> listaItem = new List<Item>();
            List<ItemDB> listaItemDB = this.appDbContext.itemDBs.ToList();
            foreach (var item in listaItemDB)
            {
                listaItem.Add(new Item(item.idItem,item.description,item.price,null,item.weight));
            }
            return listaItem;
        }

        public void save(Item item)
        {
            throw new NotImplementedException();
        }
    }
}