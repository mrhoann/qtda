namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shop")]
    public partial class Shop
    {
        public int ID { get; set; }
        [DisplayName("ID sản phẩm")]
        public int? ProductID { get; set; }
        [DisplayName("Tên shop")]
        [StringLength(250)]
        public string ShopName { get; set; }
        [DisplayName("Địa chỉ shop")]
        [StringLength(1150)]
        public string ShopAddress { get; set; }
        [DisplayName("Trạng thái shop")]
        [StringLength(50)]
        public string Status { get; set; }

        public virtual Product Product { get; set; }
    }
}