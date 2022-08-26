using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi
{
    public class GetItem
    {
        private ItemRepository itemRepository;

        public GetItem(ItemRepository itemRepository){
            this.itemRepository = itemRepository;
        }

        public List<OutputItem> execute(){
            var items = this.itemRepository.getList();
            List<OutputItem> outputItems = new List<OutputItem>();
            foreach (var item in items)
            {
                outputItems.Add(new OutputItem(item.getIdItem(),item.getDescription(),item.getIdPrice()));
            }

            return outputItems;
        }
    }
}