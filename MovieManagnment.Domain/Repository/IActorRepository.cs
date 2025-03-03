﻿using MovieManagnment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagnment.Domain.Repository
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        IEnumerable<Actor> GetActorWithMovie();
    }
}
