﻿using Web_Minimal_API.Models;

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
    }
}
