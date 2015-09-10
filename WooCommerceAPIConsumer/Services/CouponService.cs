namespace SharpCommerce.Services
{
    using System;
    using System.Collections.Generic;

    using SharpCommerce.Data.Coupons;
    using SharpCommerce.Web;

    public class CouponService : Service
    {
        public CouponService(WoocommerceApiDriver apiDriver)
            : base(apiDriver) { }

        // Create A Coupon
        public Coupon Create(Coupon orderData)
        {
            return Post(apiEndpoint: "coupons", toSerialize: new CouponBundle { Content = orderData }).Content;
        }

        // View A Coupon by id
        public Coupon Get(int couponId)
        {
            return this.Get<CouponBundle>(apiEndpoint: String.Format("coupons/{0}", couponId)).Content;
        }

        // View A Coupon by Code
        public Coupon Get(string code)
        {
            return this.Get<CouponBundle>(apiEndpoint: String.Format("coupons/code/{0}", code)).Content;
        }

        // View List Of Coupons
        public IEnumerable<Coupon> Get(Dictionary<string, string> parameters = null)
        {
            return Get<CouponsBundle>(apiEndpoint: "coupons", parameters: parameters).Content;
        }

        // Update A Coupon
        public Coupon Update(int couponId, Coupon newData)
        {
            return Put(apiEndpoint: String.Format("coupons/{0}", couponId), toSerialize: new CouponBundle { Content = newData }).Content;
        }

        // Create/Update Multiple Coupons
        public IEnumerable<Coupon> CreateUpdateMany(IEnumerable<Coupon> ordersData)
        {
            return Put(apiEndpoint: "coupons/bulk", toSerialize: new CouponsBundle { Content = ordersData }).Content;
        }

        // Delete A Coupon
        public string MoveToTrash(int id)
        {
            return Delete(id);
        }

        // Delete a Coupon Permanently
        public string DeletePermanently(int id)
        {
            return Delete(id, force: true);
        }

        private string Delete(int id, bool force = false)
        {
            var apiEndpoint = String.Format("coupons/{0}", id);
            var parameters = new Dictionary<string, string> { { "force", force.ToString().ToLower() } };
            return Delete<dynamic>(apiEndpoint, parameters).message;
        }

        // View Coupons Count
        public int Count(Dictionary<string, string> parameters = null)
        {
            return Get<dynamic>(apiEndpoint: "coupons/count", parameters: parameters).count;
        }
    }
}





