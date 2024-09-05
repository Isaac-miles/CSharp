using Microsoft.AspNetCore.Mvc;
using Web_Minimal_API.Models;

namespace Web_Minimal_API.Data
{
    public static class CouponStore
    {
        public static List<Coupon> CouponList = new List<Coupon>()
        {
            new Coupon{Id=1, Name="1F00CH",Percent=10, IsActive=true},
            new Coupon{Id=2,Name="200BYT", Percent=30, IsActive=false}
        };

        public static List<Coupon> GetCoupons()
        {
            return CouponList;
        }

        public static Coupon? GetCouponById(int id)
        {
            var coupon = CouponList.FirstOrDefault(x => x.Id == id);
            return coupon;
        }

        public static Coupon CreateCoupon(Coupon coupon)
        {
           var maxId = CouponList.Max(x => x.Id);
           coupon.Id = maxId + 1;
           CouponList.Add(coupon);
           return coupon;
        }

        public static Coupon? CouponExists(Coupon coupon)
        {
            var couponExists = CouponList.FirstOrDefault(x => x.Name.ToLower() == coupon.Name.ToLower());
            return couponExists;
        }
    }
}
