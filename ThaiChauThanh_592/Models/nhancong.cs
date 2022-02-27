namespace ThaiChauThanh_592.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhancong")]
    public partial class nhancong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhancong()
        {
            chitietbangluongs = new HashSet<chitietbangluong>();
        }

        [Key]
        [StringLength(50)]
        public string manc { get; set; }

        [StringLength(50)]
        public string tennc { get; set; }

        public bool? phai { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string maloai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietbangluong> chitietbangluongs { get; set; }

        public virtual loainhancong loainhancong { get; set; }
    }
}
