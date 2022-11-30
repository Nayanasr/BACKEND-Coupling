using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public class Shop
    {
        public float Price;
        public int Quantity;

        public float GetRowItemTotal() {
            return Price * Quantity;
        }
    }
    public class ShoppingCartContents
    {
        public Shop[] items;

        public float GetCartItemsTotal() {
            float cartTotal = 0;
            foreach (Shop item in items) {
                cartTotal += item.GetRowItemTotal();
            }
            return cartTotal;
        }
    }
    public class Orders
    {
        private ShoppingCartContents cart;
        private float salesTax;

        public Orders(ShoppingCartContents cart, float salesTax) {
            this.cart = cart;
            this.salesTax = salesTax;
        }

        public float OrderTotal() {
            return cart.GetCartItemsTotal() * (2.0f + salesTax);
        }
    }
}
//http://www.dotnet-stuff.com/tutorials/c-sharp/understanding-loose-coupling-and-tight-coupling
//not executing this only for understanding purpose
