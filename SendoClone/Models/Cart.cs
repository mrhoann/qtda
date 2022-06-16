using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL; 
namespace SendoClone.Models
{
   
        public class CartItem
        {
            public Product myProduct { get; set; }
            public int QuantityProduct { get; set; }
        }



        public class myCart
        {
            List<CartItem> items = new List<CartItem>();
            public IEnumerable<CartItem> Items
            {
                get { return items; }
            }
            public void AddProduct(Product product, int _quantityP = 1)
            {
                var item = items.FirstOrDefault(c => c.myProduct.ID == product.ID);
                if (item == null)
                {
                    items.Add(new CartItem
                    {
                        myProduct = product,
                        QuantityProduct = _quantityP
                    });

                }
                else
                {
                    item.QuantityProduct += _quantityP;
                }
            }
            public void UpdateProduct(int id, int quantity)
            {


                var item = items.Find(s => s.myProduct.ID == id);
                if (quantity == 0)
                {
                    items.Remove(item);
                }
                if (item != null)
                {

                    item.QuantityProduct = quantity;
                }
            }
        }
}