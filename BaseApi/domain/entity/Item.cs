using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class Item
    {
        private int idItem;
        private string description;
        private double price;
        private double? weight;
        private Dimension? dimenstion;

        public Item(){
            this.idItem = 0;
            this.description = String.Empty;
            this.price = 0;
            this.weight = 0;
            this.dimenstion = null;
        }
        
        public Item(int idItem, string description, double price, Dimension? dimension, double? weight = null){
            this.idItem = idItem;
            this.description = description;
            this.price = price;
            this.dimenstion = dimension;
            this.weight = weight;
        }

        public int getIdItem(){
            return this.idItem;
        }

        public string getDescription(){
            return this.description;
        }

        public double getIdPrice(){
            return this.price;
        }

        public Dimension? getDimension(){
            return this.dimenstion;
        }

        public double? getDensity(){
            return this.weight/this.dimenstion?.getVolume();
        }

        public bool isItemAbleToCalculateFreigth(){
            if(this.dimenstion != null && this.weight != null)
                return true;
            return false;
        }
    }
}