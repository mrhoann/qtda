namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class ImageProductDe
    {
        public int ID { get; set; }
        [DisplayName("ID sản phẩm")]
        public int? ProductID { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        [StringLength(4000)]
        public string ProductImage { get; set; }

        [NotMapped]

        public HttpPostedFileBase ImageFile { get; set; }
    }
}
