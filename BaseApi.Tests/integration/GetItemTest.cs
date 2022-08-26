using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;

namespace BaseApi.Tests
{
    public class GetItemTest
    {
        [Fact(DisplayName="Deve buscar os itens")]
        public void buscarItens()
        {
            ItemRepository itemRepository = new ItemRepositoryMemory();
            itemRepository.save(new Item(1,"celular",2500,new Dimension(15,5,2),0.400));
            itemRepository.save(new Item(2,"cabo",10, new Dimension(1,1,1),0.05));
            itemRepository.save(new Item(3,"carregador",50, new Dimension(6,3,3),0.080));

            GetItem getItem = new GetItem(itemRepository);
            List<OutputItem> output = getItem.execute();
            Assert.Equal(3,output.Count);
        }
    }
}