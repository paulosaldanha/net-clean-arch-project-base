using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;

namespace BaseApi.Tests
{
    public class OrderTest
    {
        [Fact(DisplayName = "Nao deve criar pedido com CPF invalido")]
        public void pedidoCpfInvalido()
        {
            var order = new Order("111.111.111-11");
            Assert.False(order.getCpf().getIsValid());
        }

        [Fact(DisplayName = "Deve criar um pedido com 3 itens cada item deve ter descricao, preco, qtd")]
        public void pedidoCriarCom3Itens()
        {
            var order = new Order("577.337.430-79");
           order.addItem(new Item(1,"celular",2500,new Dimension(15,5,2),0.400),1);
            order.addItem(new Item(2,"cabo",10, new Dimension(1,1,1),0.05),1);
            order.addItem(new Item(3,"carregador",50, new Dimension(6,3,3),0.080),1);
            Assert.Equal(2560,order.getTotal());
        }

        [Fact(DisplayName = "Deve aplicar um cupom de desconto")]
        public void pedidoComCupom()
        {
            var order = new Order("577.337.430-79");
           order.addItem(new Item(1,"celular",2500,new Dimension(15,5,2),0.400),1);
            order.addItem(new Item(2,"cabo",10, new Dimension(1,1,1),0.05),1);
            order.addItem(new Item(3,"carregador",50, new Dimension(6,3,3),0.080),1);
            order.addCoupon(new Coupon("VALE20",20));
            Assert.Equal(2048,order.getTotal());
        }

        [Fact(DisplayName = "Deve criar um pedido com cupom expirado")]
        public void pedidoComCupomExpirado()
        {
            var order = new Order("577.337.430-79");
           order.addItem(new Item(1,"celular",2500,new Dimension(15,5,2),0.400),1);
            order.addItem(new Item(2,"cabo",10, new Dimension(1,1,1),0.05),1);
            order.addItem(new Item(3,"carregador",50, new Dimension(6,3,3),0.080),1);
            order.addCoupon(new Coupon("VALE20",20,new DateTime(2022,5,20)));
            Assert.Equal(2560,order.getTotal());
        }

        [Fact(DisplayName = "Deve criar um pedido e calcular o frete")]
        public void criarPedidoCalcularFrete()
        {
            var order = new Order("577.337.430-79");
            order.addItem(new Item(1,"celular",2500,new Dimension(15,5,2),0.400),1);
            order.addItem(new Item(2,"cabo",10, new Dimension(1,1,1),0.05),1);
            order.addItem(new Item(3,"carregador",50, new Dimension(6,3,3),0.080),1);
            // produto 1 volume = 15/100 * 5/100 * 2/100 = 0,00015
            // density = 0.400/0.00015 = 2.66
            // freight = 0.00015 * 1000 * (2.66/100) = 5,64
            // produto 2 volume = 1/100 * 1/100 * 1/100 = 0,000001
            // density = 0.05/0,000001 = 50
            // freight = 0,000001 * 1000 * (50/100) = 0.0005
            // produto 3 volume = 6/100 * 3/100 * 3/100 = 0.000054
            // density = 0.080/0.000054 = 1.48
            // freight = 0.000054 * 1000 * (1.48/100) = 0.00079
            Assert.Equal(5.64579,order.getFreightValue());
        }

        [Fact(DisplayName = "Deve criar um pedido e retornar o codigo")]
        public void criarPedidoRetornaCodigo()
        {
            var order = new Order("577.337.430-79",DateTime.Now,1);
            
            Assert.Equal("202200000001",order.getSequence());
        }
    }
}