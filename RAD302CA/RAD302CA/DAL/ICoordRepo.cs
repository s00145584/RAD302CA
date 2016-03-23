﻿using RAD302CA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD302CA.DAL
{
    public interface ICoordRepo:IDisposable
    {
        List<Coord> GetByID(int id);
    }
}
