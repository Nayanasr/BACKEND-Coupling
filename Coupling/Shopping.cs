using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public class Shopping
    {
        public float price { get; set; }
        public int quantity { get; set; }
    }
    public class ShoppingCart
    {
        public Shopping[] items;
    }

    public class Order
    {
        private ShoppingCart cart;
        private float salesTax;

        public Order(ShoppingCart cart, float salesTax) {
            this.cart = cart;
            this.salesTax = salesTax;
        }

        public float OrderTotal() {
            float CartTotal = 0;
            for(int i=0;i< cart.items.Length; i++) {
             CartTotal += cart.items[i].price * cart.items[i].quantity;
            }
            CartTotal += CartTotal * salesTax;
            return CartTotal;

        }
    }
}
//http://www.dotnet-stuff.com/tutorials/c-sharp/understanding-loose-coupling-and-tight-coupling
//not executing this only for understanding purpose
