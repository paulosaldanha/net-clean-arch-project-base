using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;

namespace BaseApi.Tests
{
    public class FreightTest
    {
        [Fact(DisplayName="Deve Calcular frete")]
        public void deveCalcularFrete()
        {
            Freight freight = new Freight();
            freight.addItem(new Item(1,"celular",2500,new Dimension(15,5,2),0.400),1);
            freight.addItem(new Item(2,"cabo",10, new Dimension(1,1,1),0.05),1);
            freight.addItem(new Item(3,"carregador",50, new Dimension(6,3,3),0.080),1);
           
            Assert.Equal(5.64579,freight.getTotal());
        }

        [Fact(DisplayName="Deve Calcular frete com preco minimo")]
        public void deveCalcularFretePrecoMinimo()
        {
            Freight freight = new Freight();
            freight.addItem(new Item(1,"celular",2500,new Dimension(15,5,2),0.400),1);
            freight.addItem(new Item(2,"cabo",10, new Dimension(1,1,1),0.05),1);
            freight.addItem(new Item(3,"carregador",50, new Dimension(6,3,3),0.080),1);
           
            Assert.Equal(5.64579,freight.getTotal());
        }
    }
}