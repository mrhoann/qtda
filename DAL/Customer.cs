namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string Wards { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? TypeAdress { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        public virtual User User { get; set; }
    }
}
