using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;


namespace BaseApi.Tests
{
    public class CouponTest
    {
        [Fact(DisplayName="Deve criar um cupom")]
        public void criarCoupon()
        {
            var coupon = new Coupon("VALE20",20);
            var desconto = coupon.calculateDiscountValue(1000);
            Assert.Equal(200,desconto);
        }

        [Fact(DisplayName="Deve criar um cupom expirado")]
        public void criarCouponExpirado()
        {
            var coupon = new Coupon("VALE20",20, new DateTime(2022,1,20));
            Assert.True(coupon.isExpired());
        }

    }
}