using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class Freight
    {
        const int DISTANCE = 1000;
        const int FACTOR = 100;
        const double MIN_FREIGHT = 10;
        private double? total = 0;

        public Freight(){
            
        }

        public void addItem(Item item, int qtd){
            if(item.isItemAbleToCalculateFreigth()){

                double? volume = item.getDimension()?.getVolume();
                double? density = item.getDensity();
                double? freight = volume * DISTANCE * (density/FACTOR);
                total += freight * qtd;
            }
        }

        public double? getTotal(){
            return (this.total > 0 && this.total < MIN_FREIGHT) ? MIN_FREIGHT : this.total;
        }
    }
}