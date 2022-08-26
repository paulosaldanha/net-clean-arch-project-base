using Xunit;
using BaseApi.domain.entity;

namespace BaseApi.Tests;

public class OrderItemTest
{
    [Fact(DisplayName = "Deve criar um item de pedido")]
    public void criaItemDePedido()
    {
        OrderItem  orderItem = new OrderItem(1,250,1);
        Assert.Equal(250,orderItem.getTotal());
    }
}