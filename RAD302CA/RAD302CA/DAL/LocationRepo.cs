using RAD302CA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAD302CA.DAL
{
    public class LocationRepo:ILocationRepo
    {
        public CoordsContext context;
        public LocationRepo(CoordsContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public List<Location> GetAll()
        {
            return context.Locations.ToList();
        }
    }
}