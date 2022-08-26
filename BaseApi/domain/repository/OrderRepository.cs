using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;

namespace BaseApi
{
    public interface OrderRepository
    {
        public void save(Order order);
        public int getLastIndex();
    }
}