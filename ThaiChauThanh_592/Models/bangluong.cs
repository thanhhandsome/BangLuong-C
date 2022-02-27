namespace ThaiChauThanh_592.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bangluong")]
    public partial class bangluong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bangluong()
        {
            chitietbangluongs = new HashSet<chitietbangluong>();
        }

        [Key]
        [StringLength(50)]
        public string luongky { get; set; }

        public DateTime? tungay { get; set; }

        public DateTime? denngay { get; set; }

        [StringLength(50)]
        public string nguoilap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietbangluong> chitietbangluongs { get; set; }
    }
}
