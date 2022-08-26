using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class Dimension
    {
        private double width;
        private double height;
        private double length;

        public Dimension(double width, double height, double length){
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public double getWidth(){
            return this.width;
        }

        public double getHeight(){
            return this.height;
        }

        public double getLength(){
            return this.length;
        }

        public double getVolume(){
            return (this.width/100) * (this.height/100) * (this.length/100);
        }

    }
}