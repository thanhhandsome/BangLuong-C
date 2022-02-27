namespace ThaiChauThanh_592.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chitietbangluong")]
    public partial class chitietbangluong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string luongky { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string manc { get; set; }

        public double? dongia { get; set; }

        public int? songaycong { get; set; }

        public virtual bangluong bangluong { get; set; }

        public virtual nhancong nhancong { get; set; }
    }
}
