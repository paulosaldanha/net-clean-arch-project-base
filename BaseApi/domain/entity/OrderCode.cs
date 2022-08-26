using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class OrderCode
    {
        private string code;

        public OrderCode(DateTime date, int sequence){
            this.code = this.generateCode(date,sequence);
        }

        private string generateCode(DateTime date, int sequence){
            int year = date.Year;
            return String.Concat(year.ToString() + sequence.ToString().PadLeft(9,'0'));
        }

        public string getCode(){
            return this.code;
        }
    }
}