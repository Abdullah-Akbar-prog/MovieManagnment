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
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieManagnmentDbConext context) : base(context)
        {
        }
    }
}
