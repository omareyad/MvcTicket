namespace ProjectFlyJO2020.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FlyModel : DbContext
    {
        public FlyModel()
            : base("name=FlyModel")
        {
        }

        public virtual DbSet<Passenger_info> Passenger_info { get; set; }
        public virtual DbSet<Passenger_location> Passenger_location { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger_info>()
                .Property(e => e.Fname)
                .IsFixedLength();

            modelBuilder.Entity<Passenger_info>()
                .Property(e => e.Lname)
                .IsFixedLength();

            modelBuilder.Entity<Passenger_info>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Passenger_location>()
                .Property(e => e.From)
                .IsFixedLength();

            modelBuilder.Entity<Passenger_location>()
                .Property(e => e.To)
                .IsFixedLength();

            modelBuilder.Entity<Passenger_location>()
                .Property(e => e.Depart)
                .IsFixedLength();

            modelBuilder.Entity<Passenger_location>()
                .Property(e => e.Return)
                .IsFixedLength();
        }

        public System.Data.Entity.DbSet<ProjectFlyJO2020.Models.Admin_t> Admin_t { get; set; }
    }
}
