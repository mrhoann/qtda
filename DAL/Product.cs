namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            FashionProductDes = new HashSet<FashionProductDe>();
            LaptopProductDes = new HashSet<LaptopProductDe>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductSales = new HashSet<ProductSale>();
            Shops = new HashSet<Shop>();
        }

        public int ID { get; set; }
        [DisplayName("Danh mục sản phẩm")]
        public int? CategoryID { get; set; }
        [DisplayName("Tên sản phẩm")]
        [StringLength(250)]
        public string ProductName { get; set; }
        [DisplayName("Mô tả sản phẩm")]
        [StringLength(2050)]
        public string ProductDescription { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        [StringLength(4000)]
        public string ProductImage { get; set; }
        [DisplayName("Số lượng sản phẩm đã bán")]
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        public int? ProductSold { get; set; }
        [DisplayName("Địa chỉ sản phẩm")]
        [StringLength(250)]
        public string ProductAddress { get; set; }
        [DisplayName("Loại sản phẩm")]
        [StringLength(50)]
        public string Type { get; set; }
        [DisplayName("Trạng thái sản phẩm")]
        [StringLength(50)]
        public string Status { get; set; }
        [DisplayName("Miễn phí giao hàng ?")]
        public int? IsFreeShip { get; set; }
        [DisplayName("Trả góp sản phẩm ?")]
        public int? IsInstallment { get; set; }
        [DisplayName("Giá mới sản phẩm")]
        public double? ProductPriceNew { get; set; }
        [DisplayName("Giá cũ sản phẩm")]
        public double? ProductPriceOld { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FashionProductDe> FashionProductDes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LaptopProductDe> LaptopProductDes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
