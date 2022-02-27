namespace ThaiChauThanh_592.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loainhancong")]
    public partial class loainhancong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loainhancong()
        {
            nhancongs = new HashSet<nhancong>();
        }

        [Key]
        [StringLength(50)]
        public string maloai { get; set; }

        [StringLength(50)]
        public string tenloai { get; set; }

        public double? dongia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhancong> nhancongs { get; set; }
    }
}
