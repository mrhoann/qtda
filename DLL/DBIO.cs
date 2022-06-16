using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DLL
{
    public class DBIO
    {
        myDB db = new myDB();
        public void Add<T>(T myObj)
        {
            db.Set(myObj.GetType()).Add(myObj);
        }


        public void Delete<T>(T myObj)
        {
            db.Set(myObj.GetType()).Remove(myObj);
        }

        public List<Product> getListProduct()
        {
            return db.Products.ToList();
        }

        public Product getProduct(int id)
        {
            return db.Products.Where(c => c.ID == id).FirstOrDefault(); 
        }
        public List<Category> getListCategory()
        {
            return db.Categories.ToList(); 
        }

        public Category getCategory(int id)
        {
            return db.Categories.Where(c => c.ID == id).FirstOrDefault(); 
        }

        public List<SubCategory> getListSubCategory()
        {
            return db.SubCategories.ToList(); 
        }
        public SubCategory getSubCategory(int id)
        {
            return db.SubCategories.Where(c => c.ID == id).FirstOrDefault(); 
        }

      

        public Comment getComment(int id)
        {
            return db.Comments.Where(x => x.ID == id).FirstOrDefault(); 
        }
        public List<Comment> getListComments()
        {
            return db.Comments.ToList(); 
        }
        public List<ImageProductDe> getMyImageDes()
        {
            return db.ImageProductDes.ToList(); 
        }
        public Comment getComments(int id)
        {
            return db.Comments.Where(c => c.ID == id).FirstOrDefault(); 
        }

        public List<SubCategory>getMySubCategory(int id)
        {
            return db.SubCategories.Where(c => c.CategoryID == id).ToList(); 
        }

        public List<ProductSale> getListProductSale()
        {
            return db.ProductSales.ToList();
        }

        public ProductSale getProductSale(int id)
        {
            return db.ProductSales.Where(c => c.ID == id).FirstOrDefault(); 
        }
        public List<ProductSale> getMyListProductSale(int id)
        {
            return db.ProductSales.Where(c => c.CategoryID == id).ToList();
        }
        public List<ProductSale> getMyProductSale(int id)
        {
            return db.ProductSales.Where(c => c.ID == id).ToList();
        }

        public List<ElectroluxProductDe> getListElectroProduct()
        {
            return db.ElectroluxProductDes.ToList();
        }


        public List<FashionProductDe> getListFashionProduct()
        {
            return db.FashionProductDes.ToList(); 
        }

        public List<LaptopProductDe> getListTechProduct()
        {
            return db.LaptopProductDes.ToList(); 
        }

        public LaptopProductDe getProductTechDetails(int id)
        {
            return db.LaptopProductDes.Where(x => x.ID == id).FirstOrDefault(); 
        }
        public FashionProductDe getProductFashionDetails(int id)
        {
            return db.FashionProductDes.Where(x => x.ID == id).FirstOrDefault();
        }
        public ElectroluxProductDe getProductElectroDetails(int id)
        {
            return db.ElectroluxProductDes.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<ImageProductDe> getListImageProductDetails()
        {
            return db.ImageProductDes.ToList(); 
        }
        public List<ImageProductDe> getMyListImageProductDetails(int id)
        {
            return db.ImageProductDes.Where(x => x.ProductID == id).ToList(); 
        }
        public ImageProductDe getMyImageProductDetails(int id)
        {
            return db.ImageProductDes.Where(x => x.ID == id).FirstOrDefault(); 
        }


        public Shop getMyShop(int id)
        {
            return db.Shops.Where(x => x.ID == id).FirstOrDefault(); 
        }

        public List<Shop> getMyListShop()
        {
            return db.Shops.ToList(); 
        }

        public Shop getMyShopByProductID(int id)
        {
            return db.Shops.Where(x => x.ProductID == id).FirstOrDefault(); 
        }

        public User getUser(string email, string password)
        {
            return db.Users.Where(x => x.Email == email  && x.Password == password).FirstOrDefault(); 
        }

        public Customer getCustomer (int id)
        {
            return db.Customers.Where(x => x.UserID == id).FirstOrDefault(); 
        }

        public Customer getMyCustomer (int id)
        {
            return db.Customers.Where(x => x.ID == id).FirstOrDefault(); 
        }
        public List<Customer> getListCustomer()
        {
            return db.Customers.ToList(); 
        }

        public List<Order> getListOrder()
        {
            return db.Orders.ToList(); 
        }

        public List<OrderDetail> getListOrderDetails()
        {
            return db.OrderDetails.ToList(); 
        }

        public OrderDetail getOrderDetail(int id)
        {
            return db.OrderDetails.Where(x => x.ID == id).FirstOrDefault(); 
        }
        public void Save()
        {
            db.SaveChanges(); 
        }
    }
}
