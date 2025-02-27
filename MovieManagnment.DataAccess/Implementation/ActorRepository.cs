using Microsoft.EntityFrameworkCore;
using MovieManagnment.DataAccess.Context;
using MovieManagnment.Domain.Entities;
using MovieManagnment.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagnment.DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        private readonly MovieManagnmentDbConext _context;

        public ActorRepository(MovieManagnmentDbConext context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<Actor> GetActorWithMovie()
        {
            var actorWithMovie = _context.Actors.Include(x => x.Movies).ToList();
            return actorWithMovie;
        }
    }
}
