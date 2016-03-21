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
            List<Coord> coords = new List<Coord>()
            {
                new Coord() {Latitude=51.4921374,Longitude=-0.1928784,Heading=290,Pitch=75 },
                new Coord() {Latitude=51.4921451,Longitude=-0.1929781,Heading=279,Pitch=-5 },
                new Coord() {Latitude=51.4921453,Longitude=-0.1929803,Heading=281,Pitch=66 },
                new Coord() {Latitude=51.4921467,Longitude=-0.1929822,Heading=161,Pitch=66 },
                new Coord() {Latitude=51.4921451,Longitude=-0.1929834,Heading=72,Pitch=66 },
                new Coord() {Latitude=51.4921445,Longitude=-0.1929815,Heading=341,Pitch=66 },
                new Coord() {Latitude=51.4921452,Longitude=-0.1929791,Heading=98,Pitch=70 },
                new Coord() {Latitude=51.4921451,Longitude=-0.1929781,Heading=97,Pitch=84 },
                new Coord() {Latitude=51.4921374,Longitude=-0.1928784,Heading=129,Pitch=77 }
            };
            coords.ForEach(co => context.Coords.Add(co));
            context.SaveChanges();
        }
    }
}
