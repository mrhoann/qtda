namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ElectroluxProductDe
    {
        public int ID { get; set; }
        [DisplayName("ID sản phẩm")]
        public int? ProductID { get; set; }
        [DisplayName("Loại sản phẩm")]
        [StringLength(50)]
        public string Type { get; set; }
        [DisplayName("Chất liệu sản phẩm")]
        [StringLength(50)]
        public string Material { get; set; }
        [DisplayName("Dung tích sản phẩm")]
        [StringLength(50)]
        public string Capacity { get; set; }
        [DisplayName("Hãng sản xuất sản phẩm")]
        [StringLength(50)]
        public string Manufacturer { get; set; }
        [DisplayName("Thông tin bảo hành")]
        [StringLength(50)]
        public string Insurance { get; set; }
        [DisplayName("Phương thức bảo hành")]
        [StringLength(50)]
        public string WarrantyMethod { get; set; }
        [DisplayName("Xuất xứ sản phẩm")]
        [StringLength(50)]
        public string Made { get; set; }
        [DisplayName("Màu sản phẩm")]
        [StringLength(50)]
        public string Color { get; set; }
        [DisplayName("Kích thước sản phẩm")]
        [StringLength(50)]
        public string Size { get; set; }
    }
}