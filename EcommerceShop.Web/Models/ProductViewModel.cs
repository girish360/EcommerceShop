using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int CategoryID { get; set; }

        public string Image { get; set; }

        public string MoreImages { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public int? Warranty { set; get; }

        //các property của Auditable
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        //ISEOable
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        //ISwitchable
        public bool Status { get; set; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public virtual ProductCategoryViewModel ProductCategory { get; set; }

    }
}