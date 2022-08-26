using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi
{
    public class OutputPlaceOrderDTO
    {
        public double total;
        public string code;
        public OutputPlaceOrderDTO(double total,string code){
            this.total = total;
            this.code = code;
        }
    }
}