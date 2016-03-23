using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAD302CA.Models
{
    public class Coord
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public int Heading { get; set; }
        [Required]
        public int Pitch { get; set; }
        public int LocationID { get; set; }

    }

    public class Location
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class CoordsContext:DbContext
    {
        public DbSet<Coord> Coords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public CoordsContext() : base("CoordsConnection")
        { }
    }
}