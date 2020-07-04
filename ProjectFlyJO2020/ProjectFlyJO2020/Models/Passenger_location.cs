namespace ProjectFlyJO2020.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Passenger_location
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string From { get; set; }

        [Required]
        [StringLength(200)]
        public string To { get; set; }

        [Required]
        [StringLength(50)]
        public string Depart { get; set; }

        [Required]
        [StringLength(50)]
        public string Return { get; set; }
    }
}
