
namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FashionProductDe
    {
        public int ID { get; set; }
        [DisplayName("ID sản phẩm")]
        public int? ProductID { get; set; }
        [DisplayName("Thông tin chất vải")]
        [StringLength(50)]
        public string Fabric { get; set; }
        [DisplayName("Thông tin họa tiết")]
        [StringLength(50)]
        public string Pattern { get; set; }
        [DisplayName("Thông tin chiều dài tay áo")]
        [StringLength(50)]
        public string SleeveLenght { get; set; }
        [DisplayName("Kiểu phong cách")]
        [StringLength(50)]
        public string Style { get; set; }
        [DisplayName("Màu sản phẩm")]
        [StringLength(50)]
        public string Color { get; set; }
        [DisplayName("Kích thước sản phẩm")]
        [StringLength(50)]
        public string Size { get; set; }
        public virtual Product Product { get; set; }
    }
}