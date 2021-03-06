﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAD302CA.Models;
using System.Data.Entity;

namespace RAD302CA.DAL
{
    public class CoordRepo : ICoordRepo
    {
        public CoordsContext context;
        public CoordRepo(CoordsContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public List<Coord> GetByID(int id)
        {
            return (context.Coords.Where(lid => lid.LocationID == id)).ToList();
        }
    }
}