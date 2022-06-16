namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(250)]
        public string CommentContent { get; set; }

        public DateTime? CommentDate { get; set; }

        public int? ProductID { get; set; }

        public virtual User User { get; set; }
    }
}
