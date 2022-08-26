using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class Coupon
    {
        private string code;
        private int percentage;
        private DateTime? expireDate;

        public Coupon(string code, int percentage, DateTime? expireDate = null){
            this.code = code;
            this.percentage = percentage;
            this.expireDate = expireDate;
        }

        public double? calculateDiscountValue(double? total){
            return (total * this.percentage) / 100;
        }
        public int getPercentage(){
            return this.percentage;
        }

        public bool isExpired(){
            int result = DateTime.Compare(this.expireDate?? DateTime.Now, DateTime.Now);
            if(result <= 0) return true;
            return false;
        }

    }
}