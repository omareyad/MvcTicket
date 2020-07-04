namespace ProjectFlyJO2020.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_t
    {
        public int Id { get; set; }

        
        [StringLength(50)]
        public string username { get; set; }

        
        [StringLength(50)]
        public string password { get; set; }
    }
}
