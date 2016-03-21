using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAD302CA.Models;

namespace RAD302CA.DAL
{
    public class CoordRepository : ICoordRepository
    {
        private CoordDatabaseEntities context;
        public CoordRepository(CoordDatabaseEntities context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public List<CoordTbl> GetCoords()
        {
            return context.CoordTbls.ToList();
        }
    }
}