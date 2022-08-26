using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;

namespace BaseApi.Tests
{
    public class PlaceOrderTest
    {
        [Fact(DisplayName="Deve fazer um pedido")]
        public void fazerPedido()
        {
            OrderRepository orderRepository = new OrderRepositoryMemory();
            ItemRepository itemRepository = new ItemRepositoryMemory();
            itemRepository.save(new Item(1,"celular",2500,new Dimension(15,5,2),0.400));
            itemRepository.save(new Item(2,"cabo",10, new Dimension(1,1,1),0.05));
            itemRepository.save(new Item(3,"carregador",50, new Dimension(6,3,3),0.080));

            PlaceOrder placeOrder = new PlaceOrder(itemRepository,orderRepository);
            List<KeyValuePair<int,int>> lista = new List<KeyValuePair<int, int>>();
            lista.Add(new KeyValuePair<int, int>(1,1));
            lista.Add(new KeyValuePair<int, int>(2,1));
            lista.Add(new KeyValuePair<int, int>(3,3));
            InputPlaceOrderDTO input = new InputPlaceOrderDTO("03256878980", lista);
            OutputPlaceOrderDTO output = placeOrder.execute(input);
            Assert.Equal(2560,output.total);
        }

        [Fact(DisplayName="Deve fazer um pedido com codigo")]
        public void fazerPedidoComCodigo()
        {
            OrderRepository orderRepository = new OrderRepositoryMemory();
            ItemRepository itemRepository = new ItemRepositoryMemory();
            itemRepository.save(new Item(1,"celular",2500,new Dimension(15,5,2),0.400));
            itemRepository.save(new Item(2,"cabo",10, new Dimension(1,1,1),0.05));
            itemRepository.save(new Item(3,"carregador",50, new Dimension(6,3,3),0.080));

            PlaceOrder placeOrder = new PlaceOrder(itemRepository,orderRepository);
            List<KeyValuePair<int,int>> lista = new List<KeyValuePair<int, int>>();
            lista.Add(new KeyValuePair<int, int>(1,1));
            lista.Add(new KeyValuePair<int, int>(2,1));
            lista.Add(new KeyValuePair<int, int>(3,3));
            InputPlaceOrderDTO input = new InputPlaceOrderDTO("03256878980", lista, date: DateTime.Now);
            OutputPlaceOrderDTO output = placeOrder.execute(input);
            Assert.Equal("202200000001",output.code);
        }
    }
}