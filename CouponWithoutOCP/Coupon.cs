using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithoutOCP
{
    class Coupon
    {
        public double discNominal = 0;
        public double disPercentage = 0;
        public double disCashback = 0;
        public double priceNett(double originPrice)
        {
            double net = 0;
            if (discNominal == 0 && disPercentage > 0)
            {
                net = (100 - disPercentage) * originPrice / 100;
            }
            else if(discNominal > 0 && disPercentage == 0)
            {
                net = originPrice - discNominal;
            }
            else if(discNominal > 0 && disPercentage > 0)
            {
                net = originPrice - discNominal;
            }
            return net;
        }
    }
}
