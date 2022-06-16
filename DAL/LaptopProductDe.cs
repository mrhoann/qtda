
namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LaptopProductDe
    {
        public int ID { get; set; }
        [DisplayName("ID sản phẩm")]
        public int? ProductID { get; set; }
        [DisplayName("Thông tin kích thước màn hình")]
        [StringLength(50)]
        public string Size { get; set; }
        [DisplayName("Thông tin ổ cứng")]
        [StringLength(50)]
        public string HardDrive { get; set; }
        [DisplayName("Thông tin bảo hành")]
        [StringLength(50)]
        public string Insurance { get; set; }
        [DisplayName("Thông tin CPU")]
        [StringLength(50)]
        public string CPU { get; set; }
        [DisplayName("Thông tin đồ họa")]
        [StringLength(50)]
        public string Graphics { get; set; }
        [DisplayName("Thông tin loại CPU")]
        [StringLength(50)]
        public string TypeCPU { get; set; }
        [DisplayName("Thông tin bộ nhớ đệm")]
        [StringLength(50)]
        public string Caching { get; set; }
        [DisplayName("Thông tin tốc độ CPU")]
        [StringLength(50)]
        public string CPUSpeed { get; set; }
        [DisplayName("Thông tin khe đọc thẻ nhớ")]
        [StringLength(50)]
        public string MemoryRead { get; set; }
        [DisplayName("Thông tin công nghệ màn hình")]
        [StringLength(50)]
        public string TechScreen { get; set; }
        [DisplayName("Thông tin RAM")]
        [StringLength(50)]
        public string Ram { get; set; }
        [DisplayName("Màu sản phẩm")]
        [StringLength(50)]
        public string Color { get; set; }
        [DisplayName("Kích thước sản phẩm")]
        [StringLength(50)]
        public string Sizes { get; set; }
        public virtual Product Product { get; set; }
    }
}