using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;

namespace BaseApi.Tests.unit
{
    public class OrderCodeTest
    {
        [Fact(DisplayName="Deve gerar o codigo do pedido")]
        public void geraCodigoPedido()
        {
            OrderCode orderCode = new OrderCode(new DateTime(2022,8,25),1);
            Assert.Equal("202200000001",orderCode.getCode());
        }
    }
}