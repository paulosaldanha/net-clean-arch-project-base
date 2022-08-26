using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class OrderItem
    {
        private int idItem;
        private double price;
        private int qtd;

        public OrderItem(int idItem, double price, int qtd){
            this.idItem = idItem;
            this.price = price;
            this.qtd = qtd;
        }

        public double getPrice(){
            return this.price;
        }

        public int getQtd(){
            return this.qtd;
        }

        public double getTotal(){
            return this.price * this.qtd;
        }
    }
}