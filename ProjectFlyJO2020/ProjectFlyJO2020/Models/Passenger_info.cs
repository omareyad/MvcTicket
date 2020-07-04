namespace ProjectFlyJO2020.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Passenger_info
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Fname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lname { get; set; }

        public int Kids { get; set; }

        public int Adult { get; set; }

        public int Elders { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
    }
}
