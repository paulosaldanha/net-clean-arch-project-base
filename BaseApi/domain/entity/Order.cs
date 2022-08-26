using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.domain.entity
{
    public class Order
    {
       private Cpf cpf;
       private List<OrderItem> orderItems;
       private Coupon? coupon;
       private Freight freight;
       private OrderCode orderCode;
       private DateTime? date;
       private int? sequence;

       public Order(string cpf, DateTime? date = null, int? sequence = null)
       {
            this.cpf = new Cpf(cpf);
            this.orderItems = new List<OrderItem>();
            this.freight = new Freight();
            this.date = date;
            this.sequence = sequence;
            this.orderCode = new OrderCode(this.date?? DateTime.Now,this.sequence??0);
       }

       public Cpf getCpf() {
         return this.cpf;
       }

       public void addItem(Item item, int qtd){
            this.freight.addItem(item,qtd);
            this.orderItems.Add(new OrderItem(item.getIdItem(), item.getIdPrice(), qtd));
       }

       public void addCoupon(Coupon coupon){
            if(!coupon.isExpired()){
                this.coupon = coupon;
            }
       }

       public double? getFreightValue(){
        return this.freight.getTotal();
       }
       
       public double getTotal(){
          double total = 0;
          foreach (var item in orderItems)
          {
            total += item.getTotal();
          }
          if(this.coupon != null){
            total -= this.coupon.calculateDiscountValue(total) ?? 0;
          }
          total += this.freight.getTotal() ?? 0;
          return total;
       }

       public string getSequence(){
         return this.orderCode.getCode();
       }
    }
}