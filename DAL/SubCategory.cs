namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("SubCategory")]
    public partial class SubCategory
    {
        public int ID { get; set; }
        [DisplayName("Danh mục sản phẩm")]
        public int? CategoryID { get; set; }
        [DisplayName("Tên danh mục phụ")]
        [StringLength(250)]
        public string SubCategoryName { get; set; }
        [DisplayName("Ảnh danh mục sản phẩm phụ")]
        [StringLength(4000)]
        public string SubCategoryImage { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        public virtual Category Category { get; set; }
    }
}