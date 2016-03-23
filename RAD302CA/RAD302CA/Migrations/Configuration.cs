namespace RAD302CA.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD302CA.Models.CoordsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RAD302CA.Models.CoordsContext context)
        {
            //List<Coord> coords = new List<Coord>()
            //{
            //    new Coord() {Latitude=51.4921374,Longitude=-0.1928784,Heading=290,Pitch=75,LocationID=1 },
            //    new Coord() {Latitude=51.4921451,Longitude=-0.1929781,Heading=279,Pitch=-5,LocationID=1 },
            //    new Coord() {Latitude=51.4921453,Longitude=-0.1929803,Heading=281,Pitch=66,LocationID=1 },
            //    new Coord() {Latitude=51.4921467,Longitude=-0.1929822,Heading=161,Pitch=66,LocationID=1 },
            //    new Coord() {Latitude=51.4921451,Longitude=-0.1929834,Heading=72,Pitch=66,LocationID=1 },
            //    new Coord() {Latitude=51.4921445,Longitude=-0.1929815,Heading=341,Pitch=66,LocationID=1 },
            //    new Coord() {Latitude=51.4921452,Longitude=-0.1929791,Heading=98,Pitch=70,LocationID=1 },
            //    new Coord() {Latitude=51.4921451,Longitude=-0.1929781,Heading=97,Pitch=84,LocationID=1 },
            //    new Coord() {Latitude=51.4921374,Longitude=-0.1928784,Heading=129,Pitch=77,LocationID=1 }
            //};
            //coords.ForEach(co => context.Coords.Add(co));
            //context.SaveChanges();

            //List<Coord> coords = new List<Coord>()
            //{
            //    new Coord() {Latitude=48.8866319,Longitude=2.3411492,Heading=246,Pitch=74,LocationID=2 },
            //    new Coord() {Latitude=48.8865259,Longitude=2.3410135,Heading=242,Pitch=74,LocationID=2 },
            //    new Coord() {Latitude=48.8863800,Longitude=2.3407577,Heading=322,Pitch=78,LocationID=2 },
            //    new Coord() {Latitude=48.8864053,Longitude=2.3405982,Heading=9,Pitch=83,LocationID=2 },
            //    new Coord() {Latitude=48.8865051,Longitude=2.3406075,Heading=29,Pitch=80,LocationID=2 },
            //    new Coord() {Latitude=48.8866622,Longitude=2.3406665,Heading=46,Pitch=79,LocationID=2 },
            //    new Coord() {Latitude=48.8867122,Longitude=2.3406994,Heading=108,Pitch=79,LocationID=2 },
            //    new Coord() {Latitude=48.8866901,Longitude=2.3408178,Heading=108,Pitch=81,LocationID=2 },
            //    new Coord() {Latitude=48.8866319,Longitude=2.3411492,Heading=74,Pitch=100,LocationID=2 }
            //};
            //coords.ForEach(co => context.Coords.Add(co));
            //context.SaveChanges();

            //List<Location> locs = new List<Location>()
            //{
            //    new Location() {Name="Tardis" },
            //    new Location() {Name="Place du Tertre" }
            //};

            //locs.ForEach(l => context.Locations.Add(l));
            //context.SaveChanges();
        }
    }
}
