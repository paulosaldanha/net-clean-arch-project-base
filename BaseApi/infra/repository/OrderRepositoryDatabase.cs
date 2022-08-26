using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi.infra.repository
{
    public class OrderRepositoryDatabase : OrderRepository
    {
         private AppDbContext appDbContext;

        public OrderRepositoryDatabase(AppDbContext appDbContext){
            this.appDbContext = new AppDbContext();
        }

        public int getLastIndex()
        {
            return this.appDbContext.OrderDBs.Last().idOrder;
        }

        public void save(Order order)
        {
            throw new NotImplementedException();
        }
    }
}