using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi
{
    public class InputPlaceOrderDTO
    {
        public string cpf;
        public List<KeyValuePair<int,int>> orderItems;
        public string? coupon;
        public DateTime? date;
        public InputPlaceOrderDTO(string cpf,List<KeyValuePair<int,int>> orderItems,string? coupon = null, DateTime? date = null){
            this.cpf = cpf;
            this.orderItems = orderItems;
            this.coupon = coupon;
            this.date = date;
        }
    }
}