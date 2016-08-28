using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore.Models;

namespace OnlineStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItem { get; set; }
        public decimal CartTotal { get; set; }
    }
}