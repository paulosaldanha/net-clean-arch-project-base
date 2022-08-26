using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi
{
    public class PlaceOrder
    {
        private ItemRepository itemRepository;
        private OrderRepository orderRepository;
        public PlaceOrder(ItemRepository itemRepository, OrderRepository orderRepository){
            this.itemRepository = itemRepository;
            this.orderRepository = orderRepository;
        }

        public OutputPlaceOrderDTO execute(InputPlaceOrderDTO input){
            int sequence = this.orderRepository.getLastIndex() +1;
            Order order = new Order(input.cpf, input.date, sequence);
            foreach (var iten in input.orderItems)
            {
                Item item = this.itemRepository.getItemById(iten.Key);
                order.addItem(item,iten.Value);
            }
            this.orderRepository.save(order);
            return new OutputPlaceOrderDTO(order.getTotal(),order.getSequence());
        }
    }
}