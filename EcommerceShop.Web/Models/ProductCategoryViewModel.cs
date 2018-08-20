using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }

    }
}