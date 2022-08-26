using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi
{
    public interface ItemRepository
    {
        public Item getItemById(int id);
        public void save(Item item);
        public List<Item> getList();
    }
}