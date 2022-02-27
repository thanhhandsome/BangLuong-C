using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThaiChauThanh_592.Models
{
    public partial class ModelBangluong : DbContext
    {
        public ModelBangluong()
            : base("name=ModelBangluong")
        {
        }

        public virtual DbSet<bangluong> bangluongs { get; set; }
        public virtual DbSet<chitietbangluong> chitietbangluongs { get; set; }
        public virtual DbSet<loainhancong> loainhancongs { get; set; }
        public virtual DbSet<nhancong> nhancongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bangluong>()
                .HasMany(e => e.chitietbangluongs)
                .WithRequired(e => e.bangluong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhancong>()
                .HasMany(e => e.chitietbangluongs)
                .WithRequired(e => e.nhancong)
                .WillCascadeOnDelete(false);
        }
    }
}
