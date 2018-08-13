using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceShop.Model.Abstract
{
    public interface ISEOable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}
