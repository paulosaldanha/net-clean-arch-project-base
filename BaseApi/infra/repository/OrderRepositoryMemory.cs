using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi
{
    public class OrderRepositoryMemory : OrderRepository
    {
        private List<Order> orders;

        public OrderRepositoryMemory(){
            this.orders = new List<Order>();
        }

        public int getLastIndex()
        {
            return 1;
        }

        public void save(Order order)
        {
            this.orders.Add(order);
        }
    }
}