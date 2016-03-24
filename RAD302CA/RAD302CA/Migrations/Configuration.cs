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

            List<Coord> coordsT = new List<Coord>()
            {
                new Coord() {PanoramaID="c9UMhWP_MWm9U0L48xEjYw",Heading=290,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="9SNlG6n9D5kAAAQIt-IsBw",Heading=279,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="fOcISmnqyyEAAAQIt-ILgA",Heading=281,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="HqJR5XkQXDwAAAQIt-JP4Q",Heading=161,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="2udcx9piYRgAAAQIt-IsEg",Heading=100,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="58A3ZqZ9c4cAAAQIt-ILhg",Heading=40,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="QMcl48eHg8sAAAQIt-IsCw",Heading=341,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="9SNlG6n9D5kAAAQIt-IsBw",Heading=97,Pitch=-5,LocationID=1 },
                new Coord() {PanoramaID="c9UMhWP_MWm9U0L48xEjYw",Heading=115,Pitch=-5,LocationID=1 }
            };
            coordsT.ForEach(co => context.Coords.Add(co));
            context.SaveChanges();

            List<Coord> coordsP = new List<Coord>()
            {
                new Coord() {PanoramaID="sHm0rJbyg6PvoqG0UXQL6A",Heading=246,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="-mPWY5P2AXOKXTz66sLGZw",Heading=242,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="SsRljZgZSOIKxxZFhBVjeA",Heading=232,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="_j3cinVyU7jfkaqVCJi89w",Heading=210,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="U4ZuCo5Upd2_MblrcckYSw",Heading=299,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="7txwNXYY35JYYxBG0t82cQ",Heading=326,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="e__2nzqG5DKko5g2W2S3rQ",Heading=18,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="iixJzQHfP2JCsisM-y1wdA",Heading=18,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="yWAHMYdbuBCWD10fB2YQdg",Heading=74,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="CSzr83kjxn9_SqdQweSYUg",Heading=108,Pitch=-5,LocationID=2 },
                new Coord() {PanoramaID="sHm0rJbyg6PvoqG0UXQL6A",Heading=74,Pitch=-5,LocationID=2 }
            };
            coordsP.ForEach(co => context.Coords.Add(co));
            context.SaveChanges();

            List<Location> locs = new List<Location>()
            {
                new Location() {Name="Tardis" },
                new Location() {Name="Place du Tertre" }
            };

            locs.ForEach(l => context.Locations.Add(l));
            context.SaveChanges();
        }
    }
}
