using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DLL;
using SendoClone.Models;

namespace SendoClone.Controllers
{
    public class SendoController : Controller
    {
        // GET: Senco
        DBIO db = new DBIO();

        public ActionResult Home()
        {

            List<Category> myListCategory = db.getListCategory();
            List<Product> myProduct = db.getListProduct();
            List<SubCategory> mySubListCategory = db.getMySubCategory(1);
            List<ProductSale> myProductSale = db.getMyListProductSale(1);
            ViewBag.myProductSale = myProductSale;
            ViewBag.myListCategory = myListCategory;
            ViewBag.mySubListCategory = mySubListCategory;
            ViewBag.myProduct = myProduct;
            ViewBag.UserName = Session["UserName"];
            ViewBag.Test = Session["test"];
            int dem = 0;
            myCart cart = Session["Cart"] as myCart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }

            foreach (var item in cart.Items)
            {


                dem++;

            }
            ViewBag.quantityCart = dem;

            return View();
        }
        public ActionResult HomeOptions(int id)
        {
            ViewBag.UserName = Session["UserName"];
            List<Category> myListCategory = db.getListCategory();
            List<Product> myProduct = db.getListProduct();
            List<SubCategory> mySubListCategory = db.getMySubCategory(id);
            List<ProductSale> myProductSale = db.getMyListProductSale(1);
            List<ProductSale> myProductSaleFollowPath = db.getMyListProductSale(id);
            ViewBag.myProductSaleFollowPath = myProductSaleFollowPath;
            ViewBag.myListCategory = myListCategory;
            ViewBag.myProductSale = myProductSale;
            ViewBag.mySubListCategory = mySubListCategory;
            ViewBag.myProduct = myProduct;
            ViewBag.pathID = id;

            int dem = 0;
            myCart cart = Session["Cart"] as myCart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }

            foreach (var item in cart.Items)
            {


                dem++;

            }
            ViewBag.quantityCart = dem;
            return View();
        }


        public ActionResult Details(int id)
        {
            Product myProduct = db.getProduct(id);
            ViewBag.UserName = Session["UserName"];
            List<ImageProductDe> myListImageDes = db.getMyImageDes();
            List<Comment> myListComment = db.getListComments();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            List<LaptopProductDe> myProductTechDetails = db.getListTechProduct();
            List<FashionProductDe> myProductFashionDetails = db.getListFashionProduct();
            List<ElectroluxProductDe> myProductElectroDetails = db.getListElectroProduct();
            List<Shop> myListShop = db.getMyListShop();
            List<Customer> myListCustomer = db.getListCustomer();
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myListShop = myListShop;
            ViewBag.myProductTechDetails = myProductTechDetails;
            ViewBag.myProductFashionDetails = myProductFashionDetails;
            ViewBag.myProductElectroDetails = myProductElectroDetails;
            ViewBag.myProduct = myProduct;
            ViewBag.myListImageDes = myListImageDes;
            ViewBag.myListComment = myListComment;
            string priceNew = Convert.ToString(myProduct.ProductPriceNew);
            string priceOld = Convert.ToString(myProduct.ProductPriceOld);
            string myPriceNew = priceNew + ".000";
            string myPriceOld = priceOld + ".000";
            ViewBag.myPriceNew = myPriceNew;
            ViewBag.myPriceOld = myPriceOld;
            ViewBag.myListProduct = myListProduct;

            ViewBag.myListCategory = myListCategory;

            int dem = 0;
            myCart cart = Session["Cart"] as myCart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }

            foreach (var item in cart.Items)
            {


                dem++;

            }
            ViewBag.quantityCart = dem;

            return View();
        }


        public ActionResult DetailsSale(int id)
        {
            ProductSale myProduct = db.getProductSale(id);
            ViewBag.UserName = Session["UserName"];
            List<ImageProductDe> myListImageDes = db.getMyImageDes();
            List<Comment> myListComment = db.getListComments();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            List<LaptopProductDe> myProductTechDetails = db.getListTechProduct();
            List<FashionProductDe> myProductFashionDetails = db.getListFashionProduct();
            List<ElectroluxProductDe> myProductElectroDetails = db.getListElectroProduct();
            List<Shop> myListShop = db.getMyListShop();
            List<Customer> myListCustomer = db.getListCustomer();
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myListShop = myListShop;
            ViewBag.myProductTechDetails = myProductTechDetails;
            ViewBag.myProductFashionDetails = myProductFashionDetails;
            ViewBag.myProductElectroDetails = myProductElectroDetails;
            ViewBag.myProduct = myProduct;
            ViewBag.myListImageDes = myListImageDes;
            ViewBag.myListComment = myListComment;
            string priceNew = Convert.ToString(myProduct.ProductPriceNew);
            string priceOld = Convert.ToString(myProduct.ProductPriceOld);
            string myPriceNew = priceNew + ".000";
            string myPriceOld = priceOld + ".000";
            ViewBag.myPriceNew = myPriceNew;
            ViewBag.myPriceOld = myPriceOld;
            ViewBag.myListProduct = myListProduct;

            ViewBag.myListCategory = myListCategory;

            int dem = 0;
            myCart cart = Session["Cart"] as myCart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }

            foreach (var item in cart.Items)
            {


                dem++;

            }
            ViewBag.quantityCart = dem;

            return View();
        }
        public ActionResult myListCart()
        {
            ViewBag.UserName = Session["UserName"];
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            List<Shop> myListShop = db.getMyListShop();
            ViewBag.myListShop = myListShop;
            myCart cart = Session["Cart"] as myCart;

            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }


            int dem = 0;

            double myTotal = 0;
            foreach (var item in cart.Items)
            {
                string priceNew = Convert.ToString(item.myProduct.ProductPriceNew);
                string myPriceNew = priceNew.Replace(".", "");
                double total = Convert.ToDouble(Convert.ToDouble(myPriceNew) * item.QuantityProduct);
                dem++;
                myTotal += total;
            }
            ViewBag.quantityCart = dem;

            double thousand = 0;
            int remain = 0;
            double million = 0;
            int check = 0;
            if (myTotal > 1000)
            {
                thousand = myTotal % 1000;
                check = 1;
            }


            remain = (int)myTotal / 1000;

            if (remain > 1000)
            {
                million = remain % 1000;
            }
            else
            {
                million = remain;
            }


            string myThousand = Convert.ToString(thousand);
            string myMillion = Convert.ToString(million);

            string totalMonney = myMillion + '.' + myThousand + ".000";

            string strTotal = Convert.ToString(myTotal);

            string mainTotal = strTotal + ".000";

            ViewBag.mainTotal = mainTotal;
            ViewBag.totalMoney = totalMonney;
            ViewBag.check = check;


            return View(cart);
        }

        public myCart getCart()
        {
            myCart cart = Session["Cart"] as myCart;

            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();

                Session["Cart"] = cart;
            }


            return cart;
        }


        public ActionResult addToCart(int id)
        {
            Product myProduct = db.getProduct(id);

            if (myProduct != null)
            {
                getCart().AddProduct(myProduct);
            }


            return RedirectToAction("myListCart");

        }


        public ActionResult updateMyCart(int id, int quantity, int d)
        {
            getCart().UpdateProduct(id, quantity);

            return RedirectToAction("myListCart");
        }

        public ActionResult myAddToCart(int id, int quantity)
        {
            var myProduct = db.getProduct(id);
            if (myProduct != null)
            {
                getCart().AddProduct(myProduct, quantity);
            }

            return RedirectToAction("myListCart");
        }



        public ActionResult Payment()
        {
            ViewBag.UserName = Session["UserName"];
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            Customer myCustomer = db.getCustomer(Convert.ToInt32(Session["UserID"]));
            ViewBag.myCustomer = myCustomer;
            myCart cart = Session["Cart"] as myCart;

            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }


            int dem = 0;

            double myTotal = 0;
            foreach (var item in cart.Items)
            {
                string priceNew = Convert.ToString(item.myProduct.ProductPriceNew);
                string myPriceNew = priceNew.Replace(".", "");
                double total = Convert.ToDouble(Convert.ToDouble(myPriceNew) * item.QuantityProduct);
                dem++;
                myTotal += total;
            }
            ViewBag.quantityCart = dem;

            double thousand = 0;
            int remain = 0;
            double million = 0;
            int check = 0;
            if (myTotal > 1000)
            {
                check = 1;
                thousand = myTotal % 1000;
            }

            remain = (int)myTotal / 1000;

            if (remain > 1000)
            {
                million = remain % 1000;
            }
            else
            {
                million = remain;
            }

            string myThousand = Convert.ToString(thousand);
            string myMillion = Convert.ToString(million);

            string totalMonney = myMillion + '.' + myThousand + ".000";
            ViewBag.totalMoney = totalMonney;
            string strTotal = Convert.ToString(myTotal);

            string mainTotal = strTotal + ".000";

            ViewBag.mainTotal = mainTotal;

            ViewBag.check = check;


            return View(cart);

        }

        [HttpGet]
        public ActionResult Login()
        {
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            return View();
        }

        [HttpPost]
        public ActionResult Login(User myUser)
        {
            User user = db.getUser(myUser.Email, myUser.Password);
            if (user != null)
            {
                Session["RoleUser"] = user.Role;
                Session["UserName"] = user.UserName;
                Session["UserID"] = user.ID;
                Session.Timeout = 10;
                if (user.Role == 1)
                {
                    Response.Redirect("https://localhost:44309/Admin/Admin/ListProduct");
                }
                else
                {
                    return RedirectToAction("Home");
                }
            }
            else
            {
                return RedirectToAction("ValidLogin");
            }
            return RedirectToAction("Login");
        }

        public ActionResult ClearSession()
        {
            Session.Clear();
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {

            Customer myCustomer = db.getCustomer(Convert.ToInt32(customer.UserID));
            int myTypeAdress = Convert.ToInt32(customer.TypeAdress);
            if (myCustomer != null)
            {

                myCustomer.CustomerName = customer.CustomerName;
                myCustomer.Phone = customer.Phone;
                myCustomer.Email = customer.Email;
                myCustomer.Adress = customer.Adress;
                myCustomer.TypeAdress = customer.TypeAdress;
                myCustomer.Wards = customer.Wards;
                myCustomer.City = customer.City;
                db.Save();

            }
            else
            {
                customer.TypeAdress = myTypeAdress;
                db.Add(customer);
                db.Save();
            }


            return RedirectToAction("Payment");
        }
        public ActionResult Address()
        {
            ViewBag.UserName = Session["UserName"];
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login");
            }
            myCart cart = Session["Cart"] as myCart;

            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }

            int dem = 0;

            double myTotal = 0;
            foreach (var item in cart.Items)
            {

                dem++;

            }
            ViewBag.quantityCart = dem;
            ViewBag.UserID = Session["UserID"];
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            return View();
        }



        public ActionResult ProcessPayment()
        {
            Order order = new Order();
            DateTime date = DateTime.Now;
            order.OrderDate = date;
            order.UserID = (int)Session["UserID"];
            db.Add(order);
            db.Save();

            myCart cart = Session["Cart"] as myCart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new myCart();
                Session["Cart"] = cart;
            }


            cart = Session["Cart"] as myCart;

            double myTotal = 0;
            foreach (var item in cart.Items)
            {
                OrderDetail orderDetail = new OrderDetail();

                string priceNew = Convert.ToString(item.myProduct.ProductPriceNew);
                string myPriceNew = priceNew.Replace(".", "");
                double total = Convert.ToDouble(Convert.ToDouble(myPriceNew) * item.QuantityProduct);

                myTotal += total;
                double thousand = 0;
                int remain = 0;
                double million = 0;
                int check = 0;
                if (myTotal > 1000)
                {
                    check = 1;
                    thousand = myTotal % 1000;
                }

                remain = (int)myTotal / 1000;

                if (remain > 1000)
                {
                    million = remain % 1000;
                }
                else
                {
                    million = remain;
                }

                string myThousand = Convert.ToString(thousand);
                string myMillion = Convert.ToString(million);

                string totalMonney = myMillion + '.' + myThousand + ".000";
                ViewBag.totalMoney = totalMonney;

                string myTT = Convert.ToString(total);

                string sumOrder = myTT + ".000";


                orderDetail.OrderID = order.ID;
                orderDetail.ProductID = item.myProduct.ID;
                orderDetail.Quantity = item.QuantityProduct;
                if (check == 1)
                {
                    orderDetail.Total = totalMonney;
                }
                else
                {
                    orderDetail.Total = sumOrder;
                }
                orderDetail.Status = "1";
                db.Add(orderDetail);
                db.Save();
            }
            Session.Remove("Cart");
            ViewBag.quantityCart = 0;
            return RedirectToAction("OrderSuccess");
        }

        public ActionResult OrderSuccess()
        {
            ViewBag.UserName = Session["UserName"];
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            return View();
        }

        public ActionResult Comment(Comment comment)
        {

            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login");
            }

            DateTime date = DateTime.Now;
            comment.CommentDate = date;
            comment.UserID = (int)Session["UserID"];
            db.Add(comment);
            db.Save();
            return RedirectToAction("Details" + "/" + comment.ProductID);
        }

        public ActionResult ManagerOrderUser()
        {
            ViewBag.UserName = Session["UserName"];
            int check = 0;
            List<Customer> myListCustomer = db.getListCustomer();
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myUserID = Convert.ToInt32(Session["UserID"]);
            ViewBag.check = check;

            Customer myCustomer = db.getCustomer(Convert.ToInt32(Session["UserID"]));
            ViewBag.myCustomer = myCustomer;
            return View();
        }

        public ActionResult StatusOrderConfirm()
        {
            ViewBag.UserName = Session["UserName"];
            int check = 0;
            List<Customer> myListCustomer = db.getListCustomer();
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myUserID = Convert.ToInt32(Session["UserID"]);
            ViewBag.check = check;
            Customer myCustomer = db.getCustomer(Convert.ToInt32(Session["UserID"]));
            ViewBag.myCustomer = myCustomer;
            return View();
        }
        public ActionResult StatusOrderShiping()
        {
            ViewBag.UserName = Session["UserName"];
            int check = 0;
            List<Customer> myListCustomer = db.getListCustomer();
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myUserID = Convert.ToInt32(Session["UserID"]);
            ViewBag.check = check;
            Customer myCustomer = db.getCustomer(Convert.ToInt32(Session["UserID"]));
            ViewBag.myCustomer = myCustomer;
            return View();
        }

        public ActionResult StatusOrderShiped()
        {
            ViewBag.UserName = Session["UserName"];
            int check = 0;
            List<Customer> myListCustomer = db.getListCustomer();
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myUserID = Convert.ToInt32(Session["UserID"]);
            ViewBag.check = check;
            Customer myCustomer = db.getCustomer(Convert.ToInt32(Session["UserID"]));
            ViewBag.myCustomer = myCustomer;
            return View();
        }

        public ActionResult StatusOrderCancle()
        {
            ViewBag.UserName = Session["UserName"];
            int check = 0;
            List<Customer> myListCustomer = db.getListCustomer();
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Product> myListProduct = db.getListProduct();
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListCustomer = myListCustomer;
            ViewBag.myUserID = Convert.ToInt32(Session["UserID"]);
            ViewBag.check = check;
            Customer myCustomer = db.getCustomer(Convert.ToInt32(Session["UserID"]));
            ViewBag.myCustomer = myCustomer;
            return View();
        }

        public ActionResult ValidLogin()
        {
            List<Category> myListCategory = db.getListCategory();
            ViewBag.myListCategory = myListCategory;
            return View();
        }
    }
}

      
