namespace ProjectFlyJO2020.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Admins : DbContext
    {
        public Admins()
            : base("name=Admins")
        {
        }

        public virtual DbSet<Admin_t> Admin_t { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin_t>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Admin_t>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
