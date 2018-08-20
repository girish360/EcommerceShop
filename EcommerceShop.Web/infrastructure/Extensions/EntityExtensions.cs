using EcommerceShop.Model.Models;
using EcommerceShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceShop.Web.infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateOrder(this Order order, OrderViewModel orderVm) {
            order.CustomerName = orderVm.CustomerName;
            order.CustomerAddress = orderVm.CustomerName;
            order.CustomerEmail = orderVm.CustomerName;
            order.CustomerPhone = orderVm.CustomerName;
            order.CustomerMessage = orderVm.CustomerName;
            order.PaymentMethod = orderVm.CustomerName;
            order.CreatedDate = DateTime.Now;
            order.CreatedBy = orderVm.CreatedBy;
            order.Status = orderVm.Status;
            order.ID = orderVm.ID;
        }
    }
}