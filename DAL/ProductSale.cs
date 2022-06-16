namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("ProductSale")]
    public partial class ProductSale
    {
        public int ID { get; set; }
        [DisplayName("Danh mục sản phẩm")]
        public int? CategoryID { get; set; }

        [StringLength(250)]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }

        [StringLength(2500)]
        [DisplayName("Mô tả sản phẩm")]
        public string ProductDescription { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        [StringLength(4000)]
        public string ProductImage { get; set; }
        [NotMapped]
        public HttpPostedFileBase myImageFile { get; set; }
        [DisplayName("Loại sản phẩm")]
        [StringLength(50)]
        public string Type { get; set; }
        [DisplayName("Trạng thái sản phẩm")]

        [StringLength(50)]
        public string Status { get; set; }
        [DisplayName("Giá mới sản phẩm")]
        public double? ProductPriceNew { get; set; }
        [DisplayName("Giá cũ sản phẩm")]
        public double? ProductPriceOld { get; set; }

        public virtual Product Product { get; set; }
    }
}
