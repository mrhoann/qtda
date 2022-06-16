using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DLL; 
namespace SendoClone.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        DBIO db = new DBIO(); 
        // GET: Admin/Admin



        public ActionResult ListProduct()
        {
            
            if( Convert.ToInt32(Session["RoleUser"]) != 1)
            {
                Response.Redirect("https://localhost:44309/Sendo/Home");
            }
                
            List<Product> myProduct = db.getListProduct();
            ViewBag.test = Session["test"]; 
            return View(myProduct); 
        }

        public ActionResult CreateProduct()
        {
            return View(); 
        }

        [HttpPost]

        public ActionResult CreateProduct(Product product)
        {

            string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
            string extension = Path.GetExtension(product.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            product.ProductImage = "~/Assets/WebPage/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/Image/"), fileName);
            product.ImageFile.SaveAs(fileName);
            db.Add(product);
            db.Save();
            ModelState.Clear();
            return RedirectToAction("ListProduct"); 
        }


        public ActionResult UpdateProduct(int id)
        {
            Product myProduct = db.getProduct(id); 

            return View(myProduct); 
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {

            if (product.ID != null)
            {
                Product myProduct = db.getProduct(product.ID);
                if (product != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                    string extension = Path.GetExtension(product.ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    product.ProductImage = "~/Assets/WebPage/Image/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/Image/"), fileName);
                    product.ImageFile.SaveAs(fileName);
                    ModelState.Clear();
                    myProduct.ProductImage = product.ProductImage;
                    myProduct.ProductName = product.ProductName;
                    myProduct.ProductDescription = product.ProductDescription;
                    myProduct.ProductPriceNew = product.ProductPriceNew;
                    myProduct.ProductPriceOld = product.ProductPriceOld;
                    myProduct.CategoryID = product.CategoryID;
                    myProduct.IsFreeShip = product.IsFreeShip;
                    myProduct.IsInstallment = product.IsInstallment;
                    myProduct.Type = product.Type;
                    myProduct.Status = product.Status;

                }
                db.Save();
            }
     
            return RedirectToAction("ListProduct");
         
        }

        public ActionResult DeleteProduct(int id)
        {
            Product myProduct = db.getProduct(id);
            db.Delete(myProduct);
            db.Save(); 
            return RedirectToAction("ListProduct");  
        }


        public ActionResult ListCategory()
        {
            List<Category> myCategory = db.getListCategory(); 
            return View(myCategory); 
        }
        public ActionResult CreateCategory()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            db.Add(category);
            db.Save(); 
            return RedirectToAction("ListCategory"); 
        }

        public ActionResult UpdateCategory(int id)
        {
            Category myCategory = db.getCategory(id); 

            return View(myCategory); 
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            Category myCategory = db.getCategory(category.ID);
            myCategory.CategoryName = category.CategoryName;
            db.Save(); 
            return RedirectToAction("ListCategory");
        }

        public ActionResult DeleteCategory(int id)
        {
            Category myCategory = db.getCategory(id);
            db.Delete(myCategory);
            db.Save();
            return RedirectToAction("ListCategory"); 
        }

        public ActionResult ListSubCategory()
        {
            List<SubCategory> mySubCategory = db.getListSubCategory(); 

            return View(mySubCategory); 
        }
        public ActionResult CreateSubCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSubCategory(SubCategory subCategory)
        {
            string fileName = Path.GetFileNameWithoutExtension(subCategory.ImageFile.FileName);
            string extension = Path.GetExtension(subCategory.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            subCategory.SubCategoryImage = "~/Assets/WebPage/ImageSubCate/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/ImageSubCate/"), fileName);
            subCategory.ImageFile.SaveAs(fileName);
            db.Add(subCategory);
            db.Save();
            ModelState.Clear();
            return RedirectToAction("ListSubCategory");
        }

        public ActionResult UpdateSubCategory(int id)
        {
            SubCategory mySubCategory = db.getSubCategory(id); 
            return View(mySubCategory); 
        }

        [HttpPost]
        public ActionResult UpdateSubCategory(SubCategory subCategory)
        {
            if (subCategory.ID != null)
            {

                SubCategory mySubCategory = db.getSubCategory(subCategory.ID); 
                if (mySubCategory != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(subCategory.ImageFile.FileName);
                    string extension = Path.GetExtension(subCategory.ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    subCategory.SubCategoryImage = "~/Assets/WebPage/Image/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/Image/"), fileName);
                    subCategory.ImageFile.SaveAs(fileName);
                    ModelState.Clear();
                    mySubCategory.SubCategoryName = subCategory.SubCategoryName; 
                    mySubCategory.CategoryID = subCategory.CategoryID;
                    mySubCategory.SubCategoryImage = subCategory.SubCategoryImage; 
                }
                db.Save();
            }

            return RedirectToAction("ListSubCategory");
         
        }

        public ActionResult DeleteSubCategory(int id)
        {
            SubCategory mySubCategory = db.getSubCategory(id);
            db.Delete(mySubCategory);
            db.Save();
            return RedirectToAction("ListSubCategory");
        }

        public ActionResult ListComment()
        {
            List<Comment> myComments = db.getListComments(); 
            return View(myComments); 
        }

        public ActionResult DeleteComment(int id)
        {
            Comment myComment = db.getComments(id);
            db.Delete(myComment);
            db.Save(); 
            return RedirectToAction("ListComment"); 
        }


        public ActionResult ListProductSale()
        {
            List<ProductSale> myProductSale = db.getListProductSale();
            return View(myProductSale); 
        }
        public ActionResult CreateProductSale()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult CreateProductSale(ProductSale productSale)
        {
            string fileName = Path.GetFileNameWithoutExtension(productSale.myImageFile.FileName);
            string extension = Path.GetExtension(productSale.myImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            productSale.ProductImage = "~/Assets/WebPage/ImageSale/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/ImageSale/"), fileName);
            productSale.myImageFile.SaveAs(fileName);
            db.Add(productSale);
            db.Save();
            ModelState.Clear();
      
            return RedirectToAction("ListProductSale");
        }

        public ActionResult UpdateProductSale(int id)
        {
            ProductSale myProductSale = db.getProductSale(id); 

            return View(myProductSale); 
        }

        [HttpPost]
        public ActionResult UpdateProductSale(ProductSale myProductSale)
        {

     
                ProductSale myProduct = db.getProductSale(myProductSale.ID);
                if (myProduct != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(myProductSale.myImageFile.FileName);
                    string extension = Path.GetExtension(myProductSale.myImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    myProductSale.ProductImage = "~/Assets/WebPage/Image/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/Image/"), fileName);
                    myProductSale.myImageFile.SaveAs(fileName);
                    ModelState.Clear();
                    myProduct.ProductImage = myProductSale.ProductImage;
                    myProduct.ProductName = myProductSale.ProductName;
                    myProduct.ProductDescription = myProductSale.ProductDescription;
                    myProduct.ProductPriceNew = myProductSale.ProductPriceNew;
                    myProduct.ProductPriceOld = myProductSale.ProductPriceOld;
                    myProduct.CategoryID = myProductSale.CategoryID;
                
                    myProduct.Type = myProductSale.Type;
                    myProduct.Status = myProductSale.Status;

                }
                db.Save();
            
            return RedirectToAction("ListProductSale");
        }

        public ActionResult DeleteProductSale(int id)
        {
            ProductSale myProductSale = db.getProductSale(id);
            db.Delete(myProductSale);
            db.Save(); 
            return RedirectToAction("ListProductSale"); 
        }



        public ActionResult ListProductTechDetails()
        {
            List<LaptopProductDe> myProductTech = db.getListTechProduct(); 

            return View(myProductTech); 
        }

        public ActionResult ListProductElectroDetails()
        {
            List<ElectroluxProductDe> myProductElex = db.getListElectroProduct(); 

            return View(myProductElex);
        }

        public ActionResult ListProductFashionDetails()
        {
            List<FashionProductDe> myProductFashion = db.getListFashionProduct(); 

            return View(myProductFashion);
        }

        public ActionResult CreateProductTechDetails()
        {
            return View(); 
        }

        public ActionResult CreateProductFashionDetails()
        {

            return View();
        }
        public ActionResult CreateProductElectroDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProductTechDetails(LaptopProductDe productTech)
        {
            db.Add(productTech);
            db.Save(); 
            return RedirectToAction("ListProductTechDetails");
        }

        [HttpPost]
        public ActionResult CreateProductFashionDetails(FashionProductDe productFashion)
        {
            db.Add(productFashion);
            db.Save(); 
            return RedirectToAction("ListProductFashionDetails");
        }

        [HttpPost]
        public ActionResult CreateProductElectroDetails(ElectroluxProductDe producElectro)
        {
            db.Add(producElectro);
            db.Save();           
            return RedirectToAction("ListProductElectroDetails");
        }


        public ActionResult UpdateProductTechDetails(int id)
        {
            LaptopProductDe myTech = db.getProductTechDetails(id); 
            return View(myTech);
        }
        public ActionResult UpdateProductFashionDetails(int id)
        {
            FashionProductDe myFashion = db.getProductFashionDetails(id); 
            return View(myFashion);
        }
        public ActionResult UpdateProductElectroDetails(int id)
        {
            ElectroluxProductDe myElectro = db.getProductElectroDetails(id); 
            return View(myElectro);
        }
      
        [HttpPost]
        public ActionResult UpdateProductTechDetails(LaptopProductDe productTech)
        {
            LaptopProductDe myProductTech = db.getProductTechDetails(productTech.ID);
            if(myProductTech != null)
                {
                myProductTech.ProductID = productTech.ProductID;
                myProductTech.HardDrive = productTech.HardDrive;
                myProductTech.Size = productTech.Size;
                myProductTech.Insurance = productTech.Insurance;
                myProductTech.CPU = productTech.CPU;
                myProductTech.Graphics = productTech.Graphics;
                myProductTech.CPUSpeed = productTech.CPUSpeed;
                myProductTech.TypeCPU = productTech.TypeCPU;
                myProductTech.Caching = productTech.Caching;
                myProductTech.MemoryRead = productTech.MemoryRead;
                myProductTech.TechScreen = productTech.TechScreen;
                myProductTech.Ram = productTech.Ram;
            }

            db.Save(); 
            return RedirectToAction("ProductListTech");
        }
        [HttpPost]
        public ActionResult UpdateProductFashionDetails(FashionProductDe productFashion)
        {
            FashionProductDe myProductFashion = db.getProductFashionDetails(productFashion.ID); 
            if(myProductFashion != null)
            {
                myProductFashion.ProductID = productFashion.ProductID;
                myProductFashion.SleeveLenght = productFashion.SleeveLenght;
                myProductFashion.Pattern = productFashion.Pattern;
                myProductFashion.Style = productFashion.Style; 
              
            }
            db.Save(); 
            return RedirectToAction("ProductListFashion");
        }
        [HttpPost]
        public ActionResult UpdateProductElectroDetails(ElectroluxProductDe productElectro)
        {

            ElectroluxProductDe myElectro = db.getProductElectroDetails(productElectro.ID);
            if(myElectro != null)
            {
                myElectro.ProductID = productElectro.ProductID;
                myElectro.Insurance = productElectro.Insurance;
                myElectro.Manufacturer = productElectro.Manufacturer;
                myElectro.Material = productElectro.Material;
                myElectro.Made = productElectro.Made;
                myElectro.Type = productElectro.Type;
                myElectro.Capacity = productElectro.Capacity;
                myElectro.WarrantyMethod = productElectro.WarrantyMethod; 
            }
            db.Save(); 
            return RedirectToAction("ProductListElectro");
        }

        public ActionResult DeleteProductTechDetails(int id)
        {
            LaptopProductDe myTech = db.getProductTechDetails(id);
            db.Delete(myTech);
            db.Save(); 
            return RedirectToAction("ListProductTech");
        }
        public ActionResult DeleteProductFashionDetails(int id)
        {
            FashionProductDe myFashion = db.getProductFashionDetails(id);
            db.Delete(myFashion);
            db.Save(); 
            return  RedirectToAction("ListProductFashion");
        }
        public ActionResult DeleteProductElectroDetails(int id)
        {
            ElectroluxProductDe myElectro = db.getProductElectroDetails(id);
            db.Delete(myElectro);
            db.Save(); 
            return RedirectToAction("ListProductElectro");
        }



        public ActionResult ListImageProductDetails()
        {
            List<ImageProductDe> myImage = db.getListImageProductDetails(); 
            return View(myImage); 
        }
        public ActionResult CreateImageProductDetails()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult CreateImageProductDetails(ImageProductDe imageProduct)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageProduct.ImageFile.FileName);
            string extension = Path.GetExtension(imageProduct.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            imageProduct.ProductImage = "~/Assets/WebPage/ImageDetails/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/ImageDetails/"), fileName);
            imageProduct.ImageFile.SaveAs(fileName);
            db.Add(imageProduct);
            db.Save();
            ModelState.Clear();


            //  return RedirectToAction("ListImageProductDetails");
            return View();
        }


        public ActionResult UpdateImageProductDetails(int id)
        {
            ImageProductDe myImage = db.getMyImageProductDetails(id); 

            return View(myImage); 
        }


        [HttpPost]
        public ActionResult UpdateImageProductDetails(ImageProductDe myImage)
        {
            ImageProductDe myImageProduct = db.getMyImageProductDetails(myImage.ID);
            if(myImageProduct != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(myImage.ImageFile.FileName);
                string extension = Path.GetExtension(myImage.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                myImage.ProductImage = "~/Assets/WebPage/ImageSale/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Assets/WebPage/ImageDetails/"), fileName);
                myImage.ImageFile.SaveAs(fileName);
                ModelState.Clear();
                myImageProduct.ProductImage = myImage.ProductImage; 
            }
            db.Save();
            return RedirectToAction("ListImageProductDetails");
        }


        public ActionResult DeleteImageProductDetails(int id)
        {
            ImageProductDe myImageProduct = db.getMyImageProductDetails(id);
            db.Delete(myImageProduct);
            db.Save();

            return RedirectToAction("ListImageProductDetails");

        }

        public ActionResult ListShop()
        {
            List<Shop> myListShop = db.getMyListShop(); 
            return View(myListShop); 
        }

        public ActionResult CreateShop()
        {
            return View(); 
        }

        [HttpPost]

        public ActionResult CreateShop(Shop myShop)
        {
            db.Add(myShop);
            db.Save(); 
            return RedirectToAction("ListShop");
        }

        public ActionResult UpdateShop(int id)
        {
            Shop myShop = db.getMyShop(id); 
            
            return View(myShop); 
        }

        [HttpPost]
        public ActionResult UpdateShop(Shop shop)
        {
            Shop myShop = db.getMyShop(shop.ID); 

            if(myShop != null)
            {
                myShop.ProductID = shop.ProductID;
                myShop.ShopName = shop.ShopName;
                myShop.ShopAddress = shop.ShopAddress;
                myShop.Status = shop.Status; 
            }
            db.Save();
            return RedirectToAction("ListShop");
        }

        public ActionResult Order()
        {
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Customer> myListCustomer = db.getListCustomer();
            List<Product> myListProduct = db.getListProduct();
            ViewBag.myListProduct = myListProduct; 
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListCustomer = myListCustomer; 

            return View(); 
        }

        public ActionResult CommentList()
        {
            List<Comment> myListComment = db.getListComments();
            ViewBag.myListComment = myListComment;
            List<Customer> myListCustomer = db.getListCustomer();
            ViewBag.myListCustomer = myListCustomer; 
            return View(); 
        }

        public ActionResult DeleteComments(int id)
        {
            Comment comment = db.getComment(id);
            db.Delete(comment);
            db.Save(); 
            return RedirectToAction("CommentList"); 
        }

    

        public ActionResult ListCustomer()
        {
            List<Customer> myListCustomer = db.getListCustomer();
            ViewBag.myListCustomer = myListCustomer; 
            return View(); 
        }
        public ActionResult XoaKhachHang(int id)
        {
            Customer customer = db.getMyCustomer(id);
            db.Delete(customer);
            db.Save();
            return RedirectToAction("ListCustomer");
        }

        public ActionResult ConfirmOrder()
        {
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Customer> myListCustomer = db.getListCustomer();
            List<Product> myListProduct = db.getListProduct();
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListCustomer = myListCustomer;
            return View(); 
        }

        public ActionResult ShipingOrder()
        {
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Customer> myListCustomer = db.getListCustomer();
            List<Product> myListProduct = db.getListProduct();
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListCustomer = myListCustomer;
            return View();
        }
        public ActionResult ShipFinishOrder()
        {
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Customer> myListCustomer = db.getListCustomer();
            List<Product> myListProduct = db.getListProduct();
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListCustomer = myListCustomer;
            return View();
        }
        public ActionResult Shiping(int id)
        {
            OrderDetail myOrderDetails = db.getOrderDetail(id);
            myOrderDetails.Status = "3";
            db.Save();
            return RedirectToAction("ConfirmOrder");
        }
        public ActionResult ShipFinish(int id)
        {
            OrderDetail myOrderDetails = db.getOrderDetail(id);
            myOrderDetails.Status = "4";          
            db.Save();
            return RedirectToAction("ShipingOrder");
        }


        public ActionResult UpdateOrderConfirm(int id)
        {
            OrderDetail myOrderDetails = db.getOrderDetail(id);
            myOrderDetails.Status = "2";
            db.Save(); 
            return RedirectToAction("Order"); 
        }

        public ActionResult CancleOrder(int id)
        {
            OrderDetail myOrderDetails = db.getOrderDetail(id);
            myOrderDetails.Status = "0";
            db.Save();
            return RedirectToAction("Order"); 
        }
        public ActionResult myCancleOrder()
        {
            List<Order> myListOrder = db.getListOrder();
            List<OrderDetail> myListOrderDetails = db.getListOrderDetails();
            List<Customer> myListCustomer = db.getListCustomer();
            List<Product> myListProduct = db.getListProduct();
            ViewBag.myListProduct = myListProduct;
            ViewBag.myListOrder = myListOrder;
            ViewBag.myListOrderDetails = myListOrderDetails;
            ViewBag.myListCustomer = myListCustomer;
            return View();
        }

        public ActionResult Charts()
        {
            int dhmoi = 0;
            int dhdangxuli = 0;
            int dhhoanthanh = 0;
            int dhhuy = 0;
            int slg = 0;
            List<Order> myListOrder = db.getListOrder(); 
            List<Product> myListProduct = db.getListProduct(); 
            foreach(var item in myListProduct)
            {
                slg++;
            }
            ViewBag.slg = slg;
            List<OrderDetail> myOrderDetails = db.getListOrderDetails(); 
            foreach(var item in myOrderDetails)
            {
                if(item.Status == "1")
                {
                    dhmoi++; 
                }

                if(item.Status == "2")
                {
                    dhdangxuli++;
                }
                if(item.Status == "4")
                {
                    dhhoanthanh++;
                }

                if(item.Status == "0")
                {
                    dhhuy++;
                }
            }
            DateTime mDate = DateTime.Now;
            var mMonth = mDate.Month;
            ViewBag.myDTT = 0; 
            double tongDTT = 0;
            double tongDTN = 0; 
            foreach(var item in myOrderDetails)
            {
                foreach(var mItem in myListOrder)
                {
                    if(item.OrderID == mItem.ID && item.Status =="4")
                    {
                        
                        var date = (DateTime)mItem.OrderDate;
                        if(date.Month == mMonth)
                        {
                            string mPrice = item.Total.Replace(".", "");
                            tongDTT += Convert.ToDouble(mPrice);
                            ViewBag.DTT = tongDTT;
                        }
                       
                    }
                }
            }

            foreach (var item in myOrderDetails)
            {
                foreach (var mItem in myListOrder)
                {
                    if (item.OrderID == mItem.ID && item.Status == "4")
                    {

                        
                            string mPrice = item.Total.Replace(".", "");
                            tongDTN += Convert.ToDouble(mPrice);
                            ViewBag.DTN = tongDTN;
                       
                    }
                }
            }


            ViewBag.dhmoi = dhmoi;
            ViewBag.dhdangxuli = dhdangxuli;
            ViewBag.dhhoanthanh = dhhoanthanh;
            ViewBag.dhhuy = dhhuy;
            return View(); 
        }
    }
}