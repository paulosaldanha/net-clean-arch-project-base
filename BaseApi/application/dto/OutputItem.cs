using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi
{
    public class OutputItem
    {
        private int idItem;
        private string description;
        private double price;

        public OutputItem(){
            this.idItem = 0;
            this.description = String.Empty;
            this.price = 0;
        }

        public OutputItem(int idItem, string description, double price){
            this.idItem = idItem;
            this.description = description;
            this.price = price;
        }
    }
}