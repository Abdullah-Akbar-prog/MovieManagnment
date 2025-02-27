using MovieManagnment.DataAccess.Context;
using MovieManagnment.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagnment.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieManagnmentDbConext _context;
        public UnitOfWork(MovieManagnmentDbConext context)
        {
            _context = context;
            Actor = new ActorRepository(_context);
            Movie = new MovieRepository(_context);
            Genre = new GenreReopsitory(_context);
            Biography = new BiographyRepository(_context);
        }

        public IActorRepository Actor {  get; private set; }
        public IMovieRepository Movie {  get; private set; }
        public IBiographyRepository Biography {  get; private set; }
        public IGenreRepository Genre {  get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose() 
        { 
            _context.Dispose();
        }
    }
}
